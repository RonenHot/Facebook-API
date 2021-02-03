using System;
using FacebookWrapper.ObjectModel;
using FacebookSystemApplicationLogic;

namespace C20_Ex02_Hadar_316305259_Ronen_316273655
{
    internal class MatchAnalyzer
    {
        private readonly FacebookObjectCollection<PotentialMatchUserProxy> r_UserFriends;
        private UserRangeSelection m_UserRangeSelection;

        internal MatchAnalyzer(FacebookObjectCollection<User> i_UserFriends)
        {
            r_UserFriends = new FacebookObjectCollection<PotentialMatchUserProxy>();
            initUserFriendsList(i_UserFriends);
        }

        private class UserRangeSelection
        {
            // we always have 2 format a. xx-yy b.xx+yy
            private const int k_FromAgeIndex = 0, k_ToAgeIndex = 1;
            private const int k_NoLimitToAge = 999;
            private const char k_RangeSign = '-', k_AboveSign = '+';

            public int FromAgeRange { get; private set; }

            public int ToAgeRange { get; private set; }

            public UserRangeSelection(string i_AgeRange)
            {
                convertAgeRangeFromStr(i_AgeRange);
            }

            private void convertAgeRangeFromStr(string i_AgeRange)
            {
                string[] ageRange = i_AgeRange.Split(k_RangeSign, k_AboveSign);
                int ageFrom, ageTo;

                if (int.TryParse(ageRange[k_FromAgeIndex], out ageFrom))
                {
                    FromAgeRange = ageFrom;
                    ToAgeRange = k_NoLimitToAge;
                }
                else
                {
                    throw new ArgumentException("Can't convert the age range.");
                }

                if (!string.IsNullOrWhiteSpace(ageRange[k_ToAgeIndex]))
                {
                    if (int.TryParse(ageRange[k_ToAgeIndex], out ageTo))
                    {
                        ToAgeRange = ageTo;
                    }
                    else
                    {
                        throw new ArgumentException("Can't convert the age range.");
                    }
                }
            }
        }

        private void initUserFriendsList(FacebookObjectCollection<User> i_UserFriends)
        {
            foreach (User currentUser in i_UserFriends)
            {
                r_UserFriends.Add(new PotentialMatchUserProxy(currentUser));
            }
        }

        internal FacebookObjectCollection<User> FindAMatchForMe(
            bool i_IsInterestedInGirls,
            bool i_IsInterestedInBoys,
            string i_AgeRange)
        {
            FacebookObjectCollection<User> matchCollection = new FacebookObjectCollection<User>();
            m_UserRangeSelection = new UserRangeSelection(i_AgeRange);

            foreach (PotentialMatchUserProxy currentUserToCheck in r_UserFriends)
            {
                checkUserPotentialMatch(
                    matchCollection,
                    currentUserToCheck,
                    i_IsInterestedInGirls,
                    i_IsInterestedInBoys);
            }

            if (matchCollection.Count == 0)
            {
                throw new ArgumentException("No Match.");
            }

            return matchCollection;
        }

        private void checkUserPotentialMatch(
            FacebookObjectCollection<User> i_MatchCollection,
            PotentialMatchUserProxy i_CurrentUserProxyToCheck,
            bool i_IsInterestedInGirls,
            bool i_IsInterestedInBoys)
        {
            if (isUserInAgeRange(i_CurrentUserProxyToCheck) && i_CurrentUserProxyToCheck.IsFreeForLove)
            {
                if (i_IsInterestedInBoys && i_IsInterestedInGirls)
                {
                    i_MatchCollection.Add(i_CurrentUserProxyToCheck.FaceBookUser);
                }
                else if (i_CurrentUserProxyToCheck.FaceBookUser.Gender.HasValue)
                {
                    if (i_IsInterestedInBoys && (i_CurrentUserProxyToCheck.FaceBookUser.Gender == User.eGender.male))
                    {
                        i_MatchCollection.Add(i_CurrentUserProxyToCheck.FaceBookUser);
                    }
                    else if (i_IsInterestedInGirls && i_CurrentUserProxyToCheck.FaceBookUser.Gender == User.eGender.female)
                    {
                        i_MatchCollection.Add(i_CurrentUserProxyToCheck.FaceBookUser);
                    }
                }
            }
        }

        private bool isUserInAgeRange(PotentialMatchUserProxy i_UserProxyToCheck)
        {
            return m_UserRangeSelection.FromAgeRange <= i_UserProxyToCheck.UserAge
                   && m_UserRangeSelection.ToAgeRange >= i_UserProxyToCheck.UserAge;
        }
    }
}
