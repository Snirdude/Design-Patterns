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
                List<string> friends = fetchFriends();

                m_SynchronizationContext.Send(o =>
                {
                    foreach(string friendName in friends)
                    {
                        comboBoxChooseFriend.Items.Add(friendName);
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

        private List<string> fetchFriends()
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
            LoginResult result = FacebookService.Login("220724224990682", "public_profile", "user_friends", "user_posts", "user_photos", "user_likes");
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
            listViewMostActiveFriends.Clear();
            listBoxFriends.Items.Clear();
            listBoxPicturesWithFriend.Items.Clear();
            comboBoxChooseFriend.Items.Clear();
            comboBoxChooseFriend.Text = "";
            checkBoxRememberMe.Checked = false;
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.IsChecked = checkBoxRememberMe.Checked;
        }

        private void buttonGetFriends_Click(object sender, EventArgs e)
        {
            List<string> friendList = fetchFriends();

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
                List<string> friendList = fetchFriends();
                List<Post> postList = fetchPosts();
                Dictionary<Post, List<string>> eachPostLikedBy = fetchPostsLikedByUsers(postList);
                Dictionary<Post, List<Comment>> eachPostCommentsFromList = fetchPostsComments(postList);
                Dictionary<Post, List<string>> eachPostTaggedInUsers = fetchPostsTaggedUsers(postList);
                Dictionary<string, double> activityList = new Dictionary<string, double>();
                List<Status> statuses = m_LoggedInUser.Statuses.ToList();
                double totalLikes = 0;

                foreach (Post post in postList)
                {
                    totalLikes += calculatePostFromUserScore(activityList, post);
                    totalLikes += calculatePostLikesScore(activityList, eachPostLikedBy[post]);
                    totalLikes += calculateCommentsScore(activityList, eachPostCommentsFromList[post]);
                    totalLikes += calculatePostTaggedScore(activityList, eachPostTaggedInUsers[post]);
                }

                foreach(Status status in statuses)
                {
                    totalLikes += calculateStatusesScore(activityList, status);
                }
                
                foreach (KeyValuePair<string, double> userActivity in activityList)
                {
                    ListViewItem item = new ListViewItem(userActivity.Key);
                    item.SubItems.Add(string.Format("{0:0.00}%", (((userActivity.Value) / totalLikes) * 100)));
                    listViewItems.Add(item);
                }

                listViewItems.Sort(new ListViewItemComparerDescending());
                m_SynchronizationContext.Send(o =>
                {
                    listViewMostActiveFriends.Items.AddRange(listViewItems.ToArray());
                }, null);
            });
        }

        private double calculateStatusesScore(Dictionary<string, double> i_ActivityList, Status i_Status)
        {
            double result = 0;

            if (i_Status.From.Name != m_LoggedInUser.Name)
            {
                if (!i_ActivityList.ContainsKey(i_Status.From.Name))
                {
                    i_ActivityList.Add(i_Status.From.Name, 0);
                }

                i_ActivityList[i_Status.From.Name] += 3;
                result += 3;
            }

            return result;
        }

        private double calculatePostFromUserScore(Dictionary<string, double> i_ActivityList, Post i_Post)
        {
            double result = 0;

            if(i_Post.From.Name != m_LoggedInUser.Name)
            {
                if(!i_ActivityList.ContainsKey(i_Post.From.Name))
                {
                    i_ActivityList.Add(i_Post.From.Name, 0);
                }

                i_ActivityList[i_Post.From.Name]++;
                result++;
            }

            return result;
        }

        private double calculatePostLikesScore(Dictionary<string, double> i_ActivityList, List<string> i_LikingUsers)
        {
            double result = 0;

            foreach (string user in i_LikingUsers)
            {
                if (!i_ActivityList.ContainsKey(user))
                {
                    i_ActivityList.Add(user, 0);
                }

                i_ActivityList[user]++;
                result++;
            }

            return result;
        }

        private double calculatePostTaggedScore(Dictionary<string, double> i_ActivityList, List<string> i_TaggedUsers)
        {
            double result = 0;

            foreach (string user in i_TaggedUsers)
            {
                if (!i_ActivityList.ContainsKey(user))
                {
                    i_ActivityList.Add(user, 0);
                }

                i_ActivityList[user] += 5;
                result += 5;
            }

            return result;
        }

        private double calculateCommentsScore(Dictionary<string, double> i_ActivityList, List<Comment> i_CommentList)
        {
            double result = 0;

            foreach (Comment comment in i_CommentList)
            {
                List<Comment> innerList = comment.Comments.ToList();
                
                if (!i_ActivityList.ContainsKey(comment.From.Name))
                {
                    i_ActivityList.Add(comment.From.Name, 0);
                }

                i_ActivityList[comment.From.Name] += 2;
                result += 2;
                result += calculateCommentsLikesScore(i_ActivityList, comment);
                if (innerList.Count > 0)
                {
                    result += calculateCommentsScore(i_ActivityList, innerList);
                }
            }

            return result;
        }

        private double calculateCommentsLikesScore(Dictionary<string, double> i_ActivityList, Comment i_Comment)
        {
            double result = 0;

            foreach(User user in i_Comment.LikedBy)
            {
                if (!i_ActivityList.ContainsKey(user.Name))
                {
                    i_ActivityList.Add(user.Name, 0);
                }

                i_ActivityList[user.Name]++;
                result++;
            }

            return result;
        }

        private List<Post> fetchPosts()
        {
            List<Post> posts = m_LoggedInUser.Posts.Where(x => x.Description != null).ToList();

            return posts;
        }

        private Dictionary<Post, List<string>> fetchPostsTaggedUsers(List<Post> i_PostList)
        {
            Dictionary<Post, List<string>> toReturn = new Dictionary<Post, List<string>>();

            foreach(Post post in i_PostList)
            {
                toReturn[post] = post.TaggedUsers.Select(x => x.Name).ToList();
            }

            return toReturn;
        }

        private Dictionary<Post, List<Comment>> fetchPostsComments(List<Post> i_PostList)
        {
            Dictionary<Post, List<Comment>> toReturn = new Dictionary<Post, List<Comment>>();

            foreach(Post post in i_PostList)
            {
                toReturn[post] = post.Comments.ToList();
            }

            return toReturn;
        }

        private Dictionary<Post, List<string>> fetchPostsLikedByUsers(List<Post> i_PostList)
        {
            Dictionary<Post, List<string>> toReturn = new Dictionary<Post, List<string>>();

            foreach(Post post in i_PostList)
            {
                toReturn[post] = post.LikedBy.Select(x => x.Name).ToList();
            }

            return toReturn;
        }

        private void buttonGetPicturesWithFriend_Click(object sender, EventArgs e)
        {
            if(comboBoxChooseFriend.SelectedItem != null)
            {
                string friendName = comboBoxChooseFriend.SelectedItem.ToString();

                listBoxPicturesWithFriend.Items.Clear();
                Task.Factory.StartNew(() =>
                {
                    List<Photo> photos = fetchPhotos();
                    Dictionary<Photo, List<PhotoTag>> photosTags = new Dictionary<Photo, List<PhotoTag>>();
                    List<string> filteredPhotosNames = new List<string>();
                    bool pictureWithFriend;

                    foreach(Photo photo in photos)
                    {
                        if(photo.Tags != null)
                        {
                            photosTags.Add(photo, photo.Tags.ToList());
                        }
                    }

                    foreach (KeyValuePair<Photo, List<PhotoTag>> photoAndTags in photosTags)
                    {
                        pictureWithFriend = false;
                        foreach (var tag in photoAndTags.Value)
                        {
                            if (tag.User.Name == friendName)
                            {
                                pictureWithFriend = true;
                                break;
                            }
                        }

                        if (pictureWithFriend)
                        {
                            filteredPhotosNames.Add(photoAndTags.Key.Name);
                        }
                    }

                    m_SynchronizationContext.Send(o =>
                    {
                        foreach (string photoName in filteredPhotosNames)
                        {
                            listBoxPicturesWithFriend.Items.Add(photoName);
                        }
                    }, null);
                });
            }
            else
            {
                MessageBox.Show("Please choose a friend");
            }
        }

        private List<Photo> fetchPhotos()
        {
            List<Photo> photos = new List<Photo>();

            foreach (Album album in m_LoggedInUser.Albums)
            {
                photos.AddRange(album.Photos.ToList());
            }

            return photos;
        }

        private void listBoxPicturesWithFriend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string photoName = listBoxPicturesWithFriend.SelectedItem.ToString();
            Photo selectedPhoto = null;
            Task.Factory.StartNew(() =>
            {
                List<Photo> photos = fetchPhotos();

                foreach (Photo photo in photos)
                {
                    if (photo.Name == photoName)
                    {
                        selectedPhoto = photo;
                        break;
                    }
                }

                m_SynchronizationContext.Send(o =>
                {
                    FormPictureWithFriend form = new FormPictureWithFriend(selectedPhoto);
                    form.ShowDialog();
                }, null);
            });
        }
    }
}
