using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookSystemApplicationLogic
{
    public class LogoutManager
    {
        private readonly List<ILogoutObserver> r_LogoutObservers = new List<ILogoutObserver>();

        public User User { get; set; }

        public bool Visited { get; set; }

        public void AddObserver(ILogoutObserver i_LogoutObserverToAdd)
        {
            r_LogoutObservers.Add(i_LogoutObserverToAdd);
        }

        public void RemoveObserver(ILogoutObserver i_LogoutObserverToRemove)
        {
            r_LogoutObservers.Remove(i_LogoutObserverToRemove);
        }

        private void notifyAllObservers()
        {
            foreach(ILogoutObserver formObserver in r_LogoutObservers)
            {
                formObserver.Update(User.Name);
            }
        }

        public void OnLogout()
        {
            if(!Visited)
            {
                notifyAllObservers();
                Visited = true;
            }
        }
    }
}
