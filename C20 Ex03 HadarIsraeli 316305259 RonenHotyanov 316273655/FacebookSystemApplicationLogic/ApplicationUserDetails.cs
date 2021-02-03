using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookSystemApplicationLogic
{
    internal class ApplicationUserDetails
    {
        private readonly User r_LoginUser;
        private readonly LogoutManager r_LogoutManagerUser;

        internal ApplicationUserDetails(User i_LoginUser, LogoutManager i_LogoutManager)
        {
            r_LoginUser = i_LoginUser;
            r_LogoutManagerUser = i_LogoutManager;
            r_LogoutManagerUser.User = i_LoginUser;
        }

        internal User User
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
                    throw new ArgumentException("Can't fetch user");
                }

                return myUser;
            }
        }

        internal string FirstName
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

        internal string LastName
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

        internal string ProfilePicture
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

        internal FacebookObjectCollection<User> Friends
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

        internal FacebookObjectCollection<Post> Posts
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

        internal FacebookObjectCollection<Checkin> CheckIns
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

        internal FacebookObjectCollection<Event> Events
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

        internal string Birthday
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

        internal void Logout()
        {
            try
            {
                r_LogoutManagerUser.Visited = false;
                FacebookService.Logout(r_LogoutManagerUser.OnLogout);
            }
            catch (Exception)
            {
                throw new Exception("Can't log out successfully.");
            }
        }
    }
}
