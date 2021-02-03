using System;
using System.Threading;
using System.Windows.Forms;
using FacebookSystemApplicationLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApplication
{
    public partial class FormMain : Form, ILogoutObserver
    {
        private const string k_NotAvailable = "N/A";
        private readonly ApplicationSettings r_ApplicationSettings;
        private readonly LogoutManager r_LogoutManager = new LogoutManager();
        private ApplicationSystemManagerFacade m_ApplicationSystemManagerFacade;
        private LoginResult m_LoginResult;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;

            r_ApplicationSettings = ApplicationSettings.LoadFromFile();
            this.Size = r_ApplicationSettings.LastWindowSize;
            this.Location = r_ApplicationSettings.LastWindowLocation;
            this.checkBoxRememberMe.Checked = r_ApplicationSettings.RememberUser;

            r_LogoutManager.AddObserver(this);
        }

        private void loginAndInitialize()
        {
            m_LoginResult = FacebookService.Login(
                "219337462756410", // (desig patter's "Design Patterns Course App 2.4" app)
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");

            ///DEPRECATED PERMISSIONS:
            ///"publish_actions"
            ///"user_about_me",
            ///"user_education_history",
            ///"user_actions.video",
            ///"user_actions.news",
            ///"user_actions.music",
            ///"user_actions.fitness",
            ///"user_actions.books",
            ///"user_games_activity",
            ///"user_managed_groups",
            ///"user_relationships",
            ///"user_relationship_details",
            ///"user_religion_politics",
            ///"user_tagged_places",
            ///"user_website",
            ///"user_work_history",
            ///"read_custom_friendlists",
            ///"read_page_mailboxes",
            ///"manage_pages",
            ///"publish_pages",
            ///"publish_actions",
            ///"rsvp_event"
            ///"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
            ///"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
            ///"read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
            ///"read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
            ///"manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)

            // The documentation regarding facebook login and permissions can be found here: 
            // https://developers.facebook.com/docs/facebook-login/permissions#reference
            populateUIFromFacebookData();
        }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }

            set
            {
                m_LoginResult = value;
            }
        }

        public ApplicationSystemManagerFacade ApplicationSystemManagerFacade
        {
            get
            {
                return m_ApplicationSystemManagerFacade;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if(r_ApplicationSettings.RememberUser && !string.IsNullOrEmpty(r_ApplicationSettings.LastAccessToken))
            {
                new Thread(autoLogin).Start();
            }
        }

        private void autoLogin()
        {
            buttonLogin.Invoke(new Action(() => buttonLogin.Enabled = false));
            m_LoginResult = FacebookService.Connect(r_ApplicationSettings.LastAccessToken);
            populateUIFromFacebookData();
            fetchData();
        }

        private void populateUIFromFacebookData()
        {
            this.Invoke(
                new Action(
                    () =>
                        {
                            m_ApplicationSystemManagerFacade = new ApplicationSystemManagerFacade(
                                m_LoginResult.LoggedInUser,
                                r_LogoutManager);
                            this.Text = "Logged in as " + m_ApplicationSystemManagerFacade.FirstName + " "
                                        + m_ApplicationSystemManagerFacade.LastName;
                            fetchUserInfo();
                        }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            r_ApplicationSettings.LastWindowSize = this.Size;
            r_ApplicationSettings.LastWindowLocation = this.Location;
            r_ApplicationSettings.RememberUser = this.checkBoxRememberMe.Checked;

            if(r_ApplicationSettings.RememberUser)
            {
                r_ApplicationSettings.LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                r_ApplicationSettings.LastAccessToken = null;
            }

            r_ApplicationSettings.SaveToFile();
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_ApplicationSystemManagerFacade.ProfilePicture);
            labelFirstNameInfo.Text = m_ApplicationSystemManagerFacade.FirstName;
            labelLastNameInfo.Text = m_ApplicationSystemManagerFacade.LastName;
            labelBirthdayInfo.Text = m_ApplicationSystemManagerFacade.Birthday;

            buttonLogin.Enabled = false;
            checkBoxRememberMe.Enabled = true;
            buttonFindaMatch.Enabled = true;
            buttonOptimalTimePost.Enabled = true;
            buttonPostStatus.Enabled = true;
            buttonLogout.Enabled = true;
            buttonFetchData.Enabled = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInitialize();
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(
                new Action(
                    () =>
                        {
                            friendListBindingSource.DataSource = m_ApplicationSystemManagerFacade.Friends;
                            if(m_ApplicationSystemManagerFacade.Friends.Count == 0)
                            {
                                MessageBox.Show("No friends to retrieve.");
                            }
                        }));
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(
                new Action(
                    () =>
                        {
                            eventBindingSource.DataSource = m_ApplicationSystemManagerFacade.Events;

                            if(m_ApplicationSystemManagerFacade.Events.Count == 0)
                            {
                                MessageBox.Show("No events to retrieve.");
                            }
                        }));
        }

        private void fetchCheckins()
        {
            listBoxCheckins.Invoke(
                new Action(
                    () =>
                        {
                            foreach (Checkin checkin in m_ApplicationSystemManagerFacade.CheckIns)
                            {
                                listBoxCheckins.Items.Add(checkin.Place.Name);
                            }

                            if (m_ApplicationSystemManagerFacade.CheckIns.Count == 0)
                            {
                                MessageBox.Show("No checkins to retrieve.");
                            }
                        }));
        }

        private void buttonFindAMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFindMatch startMatchForm =
                FormFactory.CreateNewForm(FormFactory.eFormType.FormFindMatch) as FormFindMatch;
            startMatchForm.ShowDialog();
            this.Show();
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            FormPostStatus startPostStatusForm =
                FormFactory.CreateNewForm(FormFactory.eFormType.FormPostStatus) as FormPostStatus;
            startPostStatusForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_ApplicationSystemManagerFacade.Logout();
            pictureBoxProfile.Image = null;
            labelFirstNameInfo.Text = k_NotAvailable;
            labelLastNameInfo.Text = k_NotAvailable;
            labelBirthdayInfo.Text = k_NotAvailable;

            buttonLogin.Enabled = true;
            checkBoxRememberMe.Enabled = false;
            buttonFindaMatch.Enabled = false;
            buttonOptimalTimePost.Enabled = false;
            buttonPostStatus.Enabled = false;
            buttonFetchData.Enabled = false;
            buttonLogout.Enabled = false;

            listBoxCheckins.Items.Clear();
            friendListBindingSource.DataSource = null;
            eventBindingSource.DataSource = null;
        }

        private void buttonOptimalTimePost_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOptimalTime startOptimalTimeForm =
                FormFactory.CreateNewForm(FormFactory.eFormType.FormOptimalTime) as FormOptimalTime;
            startOptimalTimeForm.ShowDialog();
            this.Show();
        }

        private void buttonFetchData_Click(object sender, EventArgs e)
        {
            fetchData();
        }

        private void fetchData()
        {
            new Thread(fetchFriends).Start();
            new Thread(fetchCheckins).Start();
            new Thread(fetchEvents).Start();
        }

        void ILogoutObserver.Update(string i_UserName)
        {
            MessageBox.Show(string.Format("The user '{0}' has logged out of the system.", i_UserName));
        }
    }
}