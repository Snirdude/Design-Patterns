using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppFirstStage
{
    internal class FacebookScoreCalculator
    {
        private string m_LoggedInUserName;

        public double Total { get; private set; }

        public Dictionary<string, double> ActivityList { get; }
        
        public FacebookScoreCalculator(string i_LoggedInUserName)
        {
            m_LoggedInUserName = i_LoggedInUserName;
            Total = 0;
            ActivityList = new Dictionary<string, double>();
        }

        public void CalculateTaggedUsersScores(FacebookObjectCollection<User> i_TaggedUsers, double i_Score)
        {
            foreach (User user in i_TaggedUsers)
            {
                if (!ActivityList.ContainsKey(user.Name))
                {
                    ActivityList.Add(user.Name, 0);
                }

                ActivityList[user.Name] += i_Score;
                Total += i_Score;
            }
        }

        public void CalculateStatusesScore(FacebookObjectCollection<Status> i_Statuses, double i_Score)
        {
            foreach(Status status in i_Statuses)
            {
                if (status.From.Name != m_LoggedInUserName)
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

        public void CalculatePostFromUserScore(Post i_Post, double i_Score)
        {
            if (i_Post.From.Name != m_LoggedInUserName)
            {
                if (!ActivityList.ContainsKey(i_Post.From.Name))
                {
                    ActivityList.Add(i_Post.From.Name, 0);
                }

                ActivityList[i_Post.From.Name] += i_Score;
                Total += i_Score;
            }
        }

        public void CalculateLikesScore(FacebookObjectCollection<User> i_LikingUsers, double i_Score)
        {
            foreach (User user in i_LikingUsers)
            {
                if (user.Name == m_LoggedInUserName)
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

        public void CalculateCommentsScore(FacebookObjectCollection<Comment> i_Comments, double i_Score)
        {
            foreach (Comment comment in i_Comments)
            {
                FacebookObjectCollection<Comment> innerComments = comment.Comments;

                if (comment.From.Name != m_LoggedInUserName)
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
                    CalculateCommentsScore(innerComments, i_Score);
                }
            }
        }
    }
}
