using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace FacebookApp
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private User m_LoggedInUser = null;
        private AppSettings m_AppSettings;

        public FormMain()
        {
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

                checkedListBoxUsers.Invoke(new Action(() => 
                {
                    checkedListBoxUsers.Items.Add(m_LoggedInUser.Name);
                    foreach (string friendName in friends)
                    {
                        checkedListBoxUsers.Items.Add(friendName);
                    }
                }));
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
            if(m_LoggedInUser != null)
            {
                List<string> friendList = fetchFriendsNames();

                listBoxFriends.Items.Clear();
                foreach (string friend in friendList)
                {
                    listBoxFriends.Items.Add(friend);
                }
            }
        }

        private void buttonGetFriendsByActivity_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser != null)
            {
                List<ListViewItem> listViewItems = new List<ListViewItem>();
                listViewMostActiveFriends.Items.Clear();

                Task.Factory.StartNew(() =>
                {
                    FacebookScoreCalculator calculator = new FacebookScoreCalculator(m_LoggedInUser);

                    double postScore = (double)numericUpDownPostScore.Value;
                    double likeScore = (double)numericUpDownLikeScore.Value;
                    double commentScore = (double)numericUpDownCommentScore.Value;
                    double statusScore = (double)numericUpDownStatusScore.Value;
                    double taggedUsersScore = (double)numericUpDownTaggedUsersScore.Value;

                    calculator.CalculateScore(taggedUsersScore, statusScore, postScore, likeScore, commentScore);

                    foreach (KeyValuePair<string, double> userActivity in calculator.ActivityList)
                    {
                        ListViewItem item = new ListViewItem(userActivity.Key);
                        item.SubItems.Add(string.Format("{0:0.00}%", (userActivity.Value / calculator.Total) * 100));
                        listViewItems.Add(item);
                    }

                    listViewItems.Sort(new ListViewItemComparer((i_FirstItem, i_SecondItem) =>
                    {
                        string firstText = i_FirstItem.SubItems[1].Text;
                        string secondText = i_SecondItem.SubItems[1].Text;
                        double firstPercent = double.Parse(firstText.Substring(0, firstText.Length - 1));
                        double secondPercent = double.Parse(secondText.Substring(0, secondText.Length - 1));

                        return -1 * firstPercent.CompareTo(secondPercent);
                    }));

                    listViewMostActiveFriends.Invoke(new Action(() =>
                    {
                        foreach (ListViewItem item in listViewItems)
                        {
                            listViewMostActiveFriends.Items.Add(item);
                        }
                    }));
                });
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser != null)
            {
                Task.Factory.StartNew(() =>
                {
                    FormEvents form = new FormEvents(m_LoggedInUser.Events);

                    form.ShowDialog();
                });
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser != null)
            {
                Task.Factory.StartNew(() =>
                {
                    FormPost form = new FormPost(m_LoggedInUser);

                    form.ShowDialog();
                });
            }
        }

        private void buttonGetCheckins_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser != null)
            {
                var selectedStringUsers = checkedListBoxUsers.CheckedItems;
                FacebookObjectCollection<User> selectedUsers = new FacebookObjectCollection<User>();
                CheckinIntersector checkinIntersector = CheckinIntersector.GetInstance();

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
        }

        private void buttonNameGenerator_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser != null)
            {
                FormNameGames nameGamesForm = new FormNameGames(m_LoggedInUser);
                nameGamesForm.ShowDialog();
            }
        }
    }
}
