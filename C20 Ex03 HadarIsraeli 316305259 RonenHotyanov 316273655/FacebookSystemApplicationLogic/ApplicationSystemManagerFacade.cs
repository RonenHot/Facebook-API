using FacebookWrapper.ObjectModel;

namespace FacebookSystemApplicationLogic
{
    public class ApplicationSystemManagerFacade
    {
        private readonly ApplicationUserDetails r_LoggedUserDetails;
        private MatchAnalyzer m_MatchAnalyzer;
        private BestTimeToShare m_BestTimeToShare;

        public ApplicationSystemManagerFacade(User i_LoggedUser, LogoutManager i_LogoutManager)
        {
            r_LoggedUserDetails = new ApplicationUserDetails(i_LoggedUser, i_LogoutManager);
        }

        public User User
        {
            get
            {
                return r_LoggedUserDetails.User;
            }
        }

		public string FirstName
		{
            get
            {
                return r_LoggedUserDetails.FirstName;
            }
        }

		public string LastName
		{
            get
            {
                return r_LoggedUserDetails.LastName;
            }
        }

		public string ProfilePicture
		{
            get
            {
                return r_LoggedUserDetails.ProfilePicture;
            }
        }

		public FacebookObjectCollection<User> Friends
		{
            get
            {
                return r_LoggedUserDetails.Friends;
            }
        }

		public FacebookObjectCollection<Post> Posts
		{
            get
            {
                return r_LoggedUserDetails.Posts;
            }
        }

        public FacebookObjectCollection<Checkin> CheckIns
        {
            get
            {
                return r_LoggedUserDetails.CheckIns;
            }
        }

        public FacebookObjectCollection<Event> Events
		{
            get
            {
                return r_LoggedUserDetails.Events;
            }
        }

        public string Birthday
		{
            get
            {
                return r_LoggedUserDetails.Birthday;
            }
        }

        public void Logout()
        {
            r_LoggedUserDetails.Logout();
        }

        public FacebookObjectCollection<User> FindAMatchForMe(
					bool i_IsInterestedInGirls,
					bool i_IsInterestedInBoys,
					string i_AgeRange)
		{
            if(m_MatchAnalyzer == null)
            {
                m_MatchAnalyzer = new MatchAnalyzer(r_LoggedUserDetails.User.Friends);
            }

            return m_MatchAnalyzer.FindAMatchForMe(i_IsInterestedInGirls, i_IsInterestedInBoys, i_AgeRange);
		}

        public void BestTimeToPost(FacebookObjectCollection<Post> i_PostCollection, out string o_BestDay, out string o_BestTimeOnDay)
        {
			if (m_BestTimeToShare == null)
            {
                m_BestTimeToShare = new BestTimeToShare() { FactorStrategy = new CommentLikeStrategy() };
            }

			m_BestTimeToShare.BestTimeToPost(i_PostCollection, out o_BestDay, out o_BestTimeOnDay);
        }
    }
}
