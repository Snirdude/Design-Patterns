using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppFirstStage
{
    internal class FacebookScoreCalculator
    {
        private User m_LoggedInUser;

        public double Total { get; private set; }

        public Dictionary<string, double> ActivityList { get; }

        public FacebookScoreCalculator(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            Total = 0;
            ActivityList = new Dictionary<string, double>();
        }

        public void CalculateScore(double i_TaggedUserScore, double i_StatusScore, double i_PostScore, double i_LikeScore, double i_CommentScore)
        {
            IEnumerable<Post> postList = fetchPosts();
            FacebookObjectCollection<Link> links = m_LoggedInUser.PostedLinks;
            FacebookObjectCollection<Checkin> checkins = m_LoggedInUser.Checkins;
            FacebookObjectCollection<Status> statuses = m_LoggedInUser.Statuses;

            foreach (Post post in postList)
            {
                calculatePostFromUserScore(post, i_PostScore);
                calculateLikesScore(post.LikedBy, i_LikeScore);
                calculateCommentsScore(post.Comments, i_CommentScore);
                calculateTaggedUsersScores(post.WithUsers, i_TaggedUserScore);
            }

            calculateStatusesScore(statuses, i_StatusScore);
            foreach (Link link in links)
            {
                calculateCommentsScore(link.Comments, i_CommentScore);
                calculateLikesScore(link.LikedBy, i_LikeScore);
            }

            foreach (Checkin checkin in checkins)
            {
                calculateTaggedUsersScores(checkin.WithUsers, i_TaggedUserScore);
            }
        }

        private void calculateTaggedUsersScores(FacebookObjectCollection<User> i_TaggedUsers, double i_Score)
        {
            foreach (User user in i_TaggedUsers)
            {
                if(user.Name == m_LoggedInUser.Name)
                {
                    continue;
                }

                if (!ActivityList.ContainsKey(user.Name))
                {
                    ActivityList.Add(user.Name, 0);
                }

                ActivityList[user.Name] += i_Score;
                Total += i_Score;
            }
        }
                     
        private void calculateStatusesScore(FacebookObjectCollection<Status> i_Statuses, double i_Score)
        {
            foreach(Status status in i_Statuses)
            {
                if (status.From.Name != m_LoggedInUser.Name)
                {
                    if (!ActivityList.ContainsKey(status.From.Name))
                    {
                        ActivityList.Add(status.From.Name, 0);
                    }

                    ActivityList[status.From.Name] += i_Score;
                    Total += i_Score;
                }
            }
        }
                     
        private void calculatePostFromUserScore(Post i_Post, double i_Score)
        {
            if (i_Post.From.Name != m_LoggedInUser.Name)
            {
                if (!ActivityList.ContainsKey(i_Post.From.Name))
                {
                    ActivityList.Add(i_Post.From.Name, 0);
                }

                ActivityList[i_Post.From.Name] += i_Score;
                Total += i_Score;
            }
        }
                     
        private void calculateLikesScore(FacebookObjectCollection<User> i_LikingUsers, double i_Score)
        {
            foreach (User user in i_LikingUsers)
            {
                if (user.Name == m_LoggedInUser.Name)
                {
                    continue;
                }

                if (!ActivityList.ContainsKey(user.Name))
                {
                    ActivityList.Add(user.Name, 0);
                }

                ActivityList[user.Name] += i_Score;
                Total += i_Score;
            }
        }
                     
        private void calculateCommentsScore(FacebookObjectCollection<Comment> i_Comments, double i_Score)
        {
            foreach (Comment comment in i_Comments)
            {
                FacebookObjectCollection<Comment> innerComments = comment.Comments;

                if (comment.From.Name != m_LoggedInUser.Name)
                {
                    if (!ActivityList.ContainsKey(comment.From.Name))
                    {
                        ActivityList.Add(comment.From.Name, 0);
                    }

                    ActivityList[comment.From.Name] += i_Score;
                    Total += i_Score;
                }

                if (innerComments.Count > 0)
                {
                    calculateCommentsScore(innerComments, i_Score);
                }
            }
        }

        private IEnumerable<Post> fetchPosts()
        {
            var posts = m_LoggedInUser.Posts.Where(x => x.Description != null);

            posts = posts.Concat(m_LoggedInUser.PostsTaggedIn.Where(x => x.Description != null)).Distinct();

            return posts;
        }
    }
}
