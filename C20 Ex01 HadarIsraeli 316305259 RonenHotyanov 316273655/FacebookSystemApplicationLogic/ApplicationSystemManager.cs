using System;
using C20_Ex01_Hadar_316305259_Ronen_316273655;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookSystemApplicationLogic
{
    public class ApplicationSystemManager
    {
        private readonly User r_LoginUser;
        private MatchAnalyzer m_MatchAnalyzer;
        private BestTimeToShare m_BestTimeToShare;

        public ApplicationSystemManager(User i_LoginUser)
        {
            r_LoginUser = i_LoginUser;
        }

        public User GetUser
        {
            get
            {
                User myUser = null;

                try
                {
                    myUser = r_LoginUser;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's first name");
                }

                return myUser;
            }
        }

		public string GetFirstName
		{
            get
            {
                string userFirstName = string.Empty;

                try
                {
                    userFirstName = r_LoginUser.FirstName;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's first name");
                }

                return userFirstName;
            }
        }

		public string GetLastName
		{
            get
            {
                string userLastName = string.Empty;

                try
                {
                    userLastName = r_LoginUser.LastName;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's last name");
                }

                return userLastName;
            }
        }

		public string GetProfilePicture
		{
            get
            {
                string userPictureURL = string.Empty;

                try
                {
                    userPictureURL = r_LoginUser.PictureNormalURL;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's profile picture");
                }

                return userPictureURL;
            }
        }

		public FacebookObjectCollection<User> GetFriends
		{
            get
            {
                FacebookObjectCollection<User> userFriends;

                try
                {
                    userFriends = r_LoginUser.Friends;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's friends");
                }

                return userFriends;
            }
        }

		public FacebookObjectCollection<Post> GetPosts
		{
            get
            {
                FacebookObjectCollection<Post> userPosts;

                try
                {
                    userPosts = r_LoginUser.Posts;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's posts");
                }

                return userPosts;
            }
        }

        public FacebookObjectCollection<Checkin> GetCheckIns
        {
            get
            {
                FacebookObjectCollection<Checkin> userCheckIns;

                try
                {
                    userCheckIns = r_LoginUser.Checkins;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's posts");
                }

                return userCheckIns;
            }
        }

        public FacebookObjectCollection<Event> GetEvents
		{
            get
            {
                FacebookObjectCollection<Event> userEvents;

                try
                {
                    userEvents = r_LoginUser.Events;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's events");
                }

                return userEvents;
            }
        }

        public string GetBirthday
		{
            get
            {
                string userBirthday = string.Empty;

                try
                {
                    userBirthday = r_LoginUser.Birthday;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Can't fetch user's birthday");
                }

                return userBirthday;
            }
        }

        public void Logout()
        {
            try
            {
                FacebookService.Logout(null);
            }
            catch(Exception)
            {
                throw new Exception("Can't log out successfuly.");
            }
        }

        public FacebookObjectCollection<User> FindAMatchForMe(
					bool i_IsInterestedInGirls,
					bool i_IsInterestedInBoys,
					string i_AgeRange)
		{
            if(m_MatchAnalyzer == null)
            {
                m_MatchAnalyzer = new MatchAnalyzer(r_LoginUser.Friends);
            }

            return m_MatchAnalyzer.FindAMatchForMe(i_IsInterestedInGirls, i_IsInterestedInBoys, i_AgeRange);
		}

        public void BestTimeToPost(FacebookObjectCollection<Post> i_PostCollection, out string o_BestDay, out string o_BestTimeOnDay)
        {
			if (m_BestTimeToShare == null)
			{
				m_BestTimeToShare = new BestTimeToShare();
			}

			m_BestTimeToShare.BestTimeToPost(i_PostCollection, out o_BestDay, out o_BestTimeOnDay);
        }
    }
}
