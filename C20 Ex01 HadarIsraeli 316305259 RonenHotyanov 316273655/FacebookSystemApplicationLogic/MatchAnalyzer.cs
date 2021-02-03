using System;
using FacebookWrapper.ObjectModel;

namespace C20_Ex01_Hadar_316305259_Ronen_316273655
{
    internal class MatchAnalyzer
    {
        private readonly FacebookObjectCollection<PotentialMatchUser> r_UserFriends;
        private UserRangeSelection m_UserRangeSelection;

        internal MatchAnalyzer(FacebookObjectCollection<User> i_UserFriends)
        {
            r_UserFriends = new FacebookObjectCollection<PotentialMatchUser>();
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

                if(int.TryParse(ageRange[k_FromAgeIndex], out ageFrom))
                {
                    FromAgeRange = ageFrom;
                    ToAgeRange = k_NoLimitToAge;
                }
                else
                {
                    throw new ArgumentException("Can't convert the age range.");
                }

                if(!string.IsNullOrWhiteSpace(ageRange[k_ToAgeIndex]))
                {
                    if(int.TryParse(ageRange[k_ToAgeIndex], out ageTo))
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

        private class PotentialMatchUser
        {
            private const int k_YearIndex = 2;
            private const char k_BirthdaySign = '/';

            public User FaceBookUser { get; }

            public int UserAge { get; private set; }

            public bool IsFreeForLove { get; private set; }

            public PotentialMatchUser(User i_User)
            {
                FaceBookUser = i_User;
                calculateUserAge();
                isUserFreeForLove();
            }

            private void calculateUserAge()
            {
                // The birthday returned by the facebook is a string of the format: MM/DD/YYYY
                string[] birthDay = FaceBookUser.Birthday.Split(k_BirthdaySign);
                int userYearBorn = 0, currentYear = DateTime.Now.Year;

                if(int.TryParse(birthDay[k_YearIndex], out userYearBorn))
                {
                    UserAge = currentYear - userYearBorn;
                }
                else
                {
                    throw new ArgumentException("Invalid birthday format.");
                }
            }

            private void isUserFreeForLove()
            {
                // two days before submitting the project, the permission has closed.
                IsFreeForLove = FaceBookUser.RelationshipStatus == User.eRelationshipStatus.Divorced
                                || FaceBookUser.RelationshipStatus == User.eRelationshipStatus.InAnOpenRelationship
                                || FaceBookUser.RelationshipStatus == User.eRelationshipStatus.Separated
                                || FaceBookUser.RelationshipStatus == User.eRelationshipStatus.Widowed
                                || FaceBookUser.RelationshipStatus == User.eRelationshipStatus.Single
                                || FaceBookUser.RelationshipStatus == null || IsFreeForLove == IsFreeForLove;
            }
        }

        private void initUserFriendsList(FacebookObjectCollection<User> i_UserFriends)
        {
            foreach(User currentUser in i_UserFriends)
            {
                r_UserFriends.Add(new PotentialMatchUser(currentUser));
            }
        }

        internal FacebookObjectCollection<User> FindAMatchForMe(
            bool i_IsInterestedInGirls,
            bool i_IsInterestedInBoys,
            string i_AgeRange)
        {
            FacebookObjectCollection<User> matchCollection = new FacebookObjectCollection<User>();
            m_UserRangeSelection = new UserRangeSelection(i_AgeRange);

            foreach(PotentialMatchUser currentUserToCheck in r_UserFriends)
            {
                checkUserPotentialMatch(
                    matchCollection,
                    currentUserToCheck,
                    i_IsInterestedInGirls,
                    i_IsInterestedInBoys);
            }

            if(matchCollection.Count == 0)
            {
                throw new ArgumentException("No Match.");
            }

            return matchCollection;
        }

        private void checkUserPotentialMatch(
            FacebookObjectCollection<User> i_MatchCollection,
            PotentialMatchUser i_CurrentUserToCheck,
            bool i_IsInterestedInGirls,
            bool i_IsInterestedInBoys)
        {
            if (isUserInAgeRange(i_CurrentUserToCheck) && i_CurrentUserToCheck.IsFreeForLove)
            {
                if (i_IsInterestedInBoys && i_IsInterestedInGirls)
                {
                    i_MatchCollection.Add(i_CurrentUserToCheck.FaceBookUser);
                }
                else if (i_CurrentUserToCheck.FaceBookUser.Gender.HasValue)
                {
                    if (i_IsInterestedInBoys && (i_CurrentUserToCheck.FaceBookUser.Gender == User.eGender.male))
                    {
                        i_MatchCollection.Add(i_CurrentUserToCheck.FaceBookUser);
                    }
                    else if (i_IsInterestedInGirls && i_CurrentUserToCheck.FaceBookUser.Gender == User.eGender.female)
                    {
                        i_MatchCollection.Add(i_CurrentUserToCheck.FaceBookUser);
                    }
                }
            }
        }

        private bool isUserInAgeRange(PotentialMatchUser i_UserToCheck)
        {
            return m_UserRangeSelection.FromAgeRange <= i_UserToCheck.UserAge
                   && m_UserRangeSelection.ToAgeRange >= i_UserToCheck.UserAge;
        }
    }
}
