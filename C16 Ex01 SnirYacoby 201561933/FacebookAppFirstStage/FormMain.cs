using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace FacebookAppFirstStage
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private User m_LoggedInUser;
        private AppSettings m_AppSettings;
        private Thread m_MainThread = Thread.CurrentThread;
        private SynchronizationContext m_SynchronizationContext;

        public FormMain()
        {
            m_SynchronizationContext = SynchronizationContext.Current;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            gMapControlFriendCheckins.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControlFriendCheckins.SetPositionByKeywords("Tel-Aviv, Israel");
            m_AppSettings = AppSettings.LoadFromFile();
            if (m_AppSettings.IsChecked)
            {
                this.Location = m_AppSettings.Location;
                this.Size = m_AppSettings.Size;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if(m_AppSettings.IsChecked)
            {
                LoginResult result = FacebookService.Connect(m_AppSettings.AccessToken);
                doWhenLogin(result);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_AppSettings.Location = this.Location;
            m_AppSettings.Size = this.Size;
            m_AppSettings.SaveToFile();
        }

        private void doWhenLogin(LoginResult i_Result)
        {
            m_LoggedInUser = i_Result.LoggedInUser;
            pictureBoxProfile.Image = m_LoggedInUser.ImageNormal;
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonLogin.Text = m_LoggedInUser.Name;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            checkBoxRememberMe.Enabled = true;
            Task.Factory.StartNew(() =>
            {
                List<string> friends = fetchFriendsNames();

                m_SynchronizationContext.Send(o =>
                {
                    checkedListBoxUsers.Items.Add(m_LoggedInUser.Name);
                    foreach (string friendName in friends)
                    {
                        checkedListBoxUsers.Items.Add(friendName);
                    }

                }, null);
            });

            if (m_AppSettings.IsChecked)
            {
                checkBoxRememberMe.Checked = m_AppSettings.IsChecked;
            }
            else
            {
                m_AppSettings.AccessToken = i_Result.AccessToken;
            }
        }

        private List<string> fetchFriendsNames()
        {
            List<string> list = new List<string>();

            foreach(User user in m_LoggedInUser.Friends)
            {
                list.Add(user.Name);
            }

            return list;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult result = FacebookService.Login("220724224990682", "public_profile", "user_friends", "user_posts", "user_photos", "user_likes", "user_events", "publish_actions", "user_location");
            m_AppSettings.AccessToken = result.AccessToken;
            doWhenLogin(result);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(new Action(doWhenLogout));
        }

        private void doWhenLogout()
        {
            m_AppSettings.SaveToFile();
            m_LoggedInUser = null;
            buttonLogin.Text = "Login";
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            checkBoxRememberMe.Enabled = false;
            pictureBoxProfile.Image = null;
            listViewMostActiveFriends.Items.Clear();
            listBoxFriends.Items.Clear();
            checkedListBoxUsers.Items.Clear();
            checkBoxRememberMe.Checked = false;
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.IsChecked = checkBoxRememberMe.Checked;
        }

        private void buttonGetFriends_Click(object sender, EventArgs e)
        {
            List<string> friendList = fetchFriendsNames();

            listBoxFriends.Items.Clear();
            foreach(string friend in friendList)
            {
                listBoxFriends.Items.Add(friend);
            }
        }

        private void buttonGetFriendsByActivity_Click(object sender, EventArgs e)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            listViewMostActiveFriends.Items.Clear();

            Task.Factory.StartNew(() =>
            {
                IEnumerable<Post> postList = fetchPosts();
                FacebookObjectCollection<Link> links = m_LoggedInUser.PostedLinks;
                FacebookObjectCollection<Checkin> checkins = m_LoggedInUser.Checkins;
                FacebookObjectCollection<Status> statuses = m_LoggedInUser.Statuses;
                FacebookScoreCalculator calculator = new FacebookScoreCalculator(m_LoggedInUser.Name);
                double postScore = (double)numericUpDownPostScore.Value;
                double likeScore = (double)numericUpDownLikeScore.Value;
                double commentScore = (double)numericUpDownCommentScore.Value;
                double statusScore = (double)numericUpDownStatusScore.Value;
                double taggedUsersScore = (double)numericUpDownTaggedUsersScore.Value;

                foreach (Post post in postList)
                {
                    calculator.CalculatePostFromUserScore(post, postScore);
                    calculator.CalculateLikesScore(post.LikedBy, likeScore);
                    calculator.CalculateCommentsScore(post.Comments, commentScore);
                    calculator.CalculateTaggedUsersScores(post.WithUsers, taggedUsersScore);
                }

                calculator.CalculateStatusesScore(statuses, statusScore);

                foreach(Link link in links)
                {
                    calculator.CalculateCommentsScore(link.Comments, commentScore);
                    calculator.CalculateLikesScore(link.LikedBy, likeScore);
                }

                foreach(Checkin checkin in checkins)
                {
                    calculator.CalculateTaggedUsersScores(checkin.WithUsers, taggedUsersScore);
                }

                foreach (KeyValuePair<string, double> userActivity in calculator.ActivityList)
                {
                    ListViewItem item = new ListViewItem(userActivity.Key);
                    item.SubItems.Add(string.Format("{0:0.00}%", (((userActivity.Value) / calculator.Total) * 100)));
                    listViewItems.Add(item);
                }

                listViewItems.Sort(new ListViewItemComparerDescending());
                m_SynchronizationContext.Send(o =>
                {
                    foreach (ListViewItem item in listViewItems)
                    {
                        listViewMostActiveFriends.Items.Add(item);
                    }
                }, null);
            });
        }

        private IEnumerable<Post> fetchPosts()
        {
            var posts = m_LoggedInUser.Posts.Where(x => x.Description != null);

            posts = posts.Concat(m_LoggedInUser.PostsTaggedIn.Where(x => x.Description != null)).Distinct();

            return posts;
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                List<Event> events = m_LoggedInUser.Events.ToList();
                FormEvents form = new FormEvents(events);

                form.ShowDialog();
            });
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                FormPost form = new FormPost(m_LoggedInUser);

                form.ShowDialog();
            });
        }

        private void buttonGetCheckins_Click(object sender, EventArgs e)
        {
            var selectedStringUsers = checkedListBoxUsers.CheckedItems;
            FacebookObjectCollection<User> selectedUsers = new FacebookObjectCollection<User>();
            CheckinIntersector checkinIntersector = new CheckinIntersector();

            if (selectedStringUsers.Contains(m_LoggedInUser.Name))
            {
                selectedUsers.Add(m_LoggedInUser);
            }

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (selectedStringUsers.Contains(friend.Name))
                {
                    selectedUsers.Add(friend);
                }
            }

            Task.Factory.StartNew(() =>
            {
                var sharedCheckins = checkinIntersector.IntersectCheckins(selectedUsers);
                gMapControlFriendCheckins.Overlays.Clear();
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                foreach (Checkin checkin in sharedCheckins)
                {
                    Page place = checkin.Place;
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng((double)place.Location.Latitude, (double)place.Location.Longitude), GMarkerGoogleType.red);
                    markersOverlay.Markers.Add(marker);
                }

                gMapControlFriendCheckins.Overlays.Add(markersOverlay);
            });
        }

        private void buttonNameGenerator_Click(object sender, EventArgs e)
        {
            FormNameGames form = new FormNameGames(m_LoggedInUser);
            form.ShowDialog();
        }
    }
}
