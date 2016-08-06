using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppFirstStage
{
    internal class CheckinIntersector
    {
        public IEnumerable<Checkin> IntersectCheckins(FacebookObjectCollection<User> i_SelectedUsers)
        {
            FacebookObjectCollection<Checkin> sharedCheckins = new FacebookObjectCollection<Checkin>();

            foreach (User selectedUser in i_SelectedUsers)
            {
                foreach (User friend in selectedUser.Friends)
                {
                    foreach (Checkin checkin in friend.Checkins)
                    {
                        bool isCheckinShared = true;

                        foreach (User innerSelectedUser in i_SelectedUsers)
                        {
                            if (!checkin.WithUsers.Select(x => x.Name).Contains(innerSelectedUser.Name) && checkin.From.Name != innerSelectedUser.Name && !checkin.TaggedUsers.Select(x => x.Name).Contains(innerSelectedUser.Name))
                            {
                                isCheckinShared = false;
                                break;
                            }
                        }

                        if (isCheckinShared)
                        {
                            sharedCheckins.Add(checkin);
                        }
                    }
                }

                foreach (Checkin checkin in selectedUser.Checkins)
                {
                    bool isCheckinShared = true;

                    foreach (string otherUserName in i_SelectedUsers.Where(x => x.Name != selectedUser.Name).Select(x => x.Name))
                    {
                        if (!checkin.WithUsers.Select(x => x.Name).Contains(otherUserName))
                        {
                            isCheckinShared = false;
                            break;
                        }
                    }

                    if (isCheckinShared)
                    {
                        sharedCheckins.Add(checkin);
                    }
                }
            }

            return sharedCheckins.Distinct();
        }
    }
}
