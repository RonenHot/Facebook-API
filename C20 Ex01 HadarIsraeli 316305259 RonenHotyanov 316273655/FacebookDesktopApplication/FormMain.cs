using System;
using System.Windows.Forms;
using FacebookSystemApplicationLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApplication
{
    public partial class FormMain : Form
    {
        private const string k_NotAvailable = "N/A";
        private readonly ApplicationSettings r_ApplicationSettings;
        private ApplicationSystemManager m_ApplicationSystemManager;
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

        public ApplicationSystemManager ApplicationSystemManager
        {
            get
            {
                return m_ApplicationSystemManager;
            }
        }

        private void populateUIFromFacebookData()
        {
            m_ApplicationSystemManager = new ApplicationSystemManager(m_LoginResult.LoggedInUser);
            this.Text = "Logged in as " + m_ApplicationSystemManager.GetFirstName + " "
                        + m_ApplicationSystemManager.GetLastName;
            fetchUserInfo();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if(r_ApplicationSettings.RememberUser && !string.IsNullOrEmpty(r_ApplicationSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(r_ApplicationSettings.LastAccessToken);
                populateUIFromFacebookData();
            }
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
            pictureBoxProfile.LoadAsync(m_ApplicationSystemManager.GetProfilePicture);
            labelFirstNameInfo.Text = m_ApplicationSystemManager.GetFirstName;
            labelLastNameInfo.Text = m_ApplicationSystemManager.GetLastName;
            labelBirthdayInfo.Text = m_ApplicationSystemManager.GetBirthday;

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
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach(User friend in m_ApplicationSystemManager.GetFriends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if(m_ApplicationSystemManager.GetFriends.Count == 0)
            {
                MessageBox.Show("No friends to retrieve.");
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach(Event fbEvent in m_ApplicationSystemManager.GetEvents)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if(m_ApplicationSystemManager.GetEvents.Count == 0)
            {
                MessageBox.Show("No events to retrieve.");
            }
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in m_ApplicationSystemManager.GetCheckIns)
            {
                listBoxCheckins.Items.Add(checkin.Place.Name);
            }

            if(m_ApplicationSystemManager.GetCheckIns.Count == 0)
            {
                MessageBox.Show("No checkins to retrieve.");
            }
        }

        private void buttonFindAMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFindMatch startMatchForm = new FormFindMatch(this);
            startMatchForm.ShowDialog();
            this.Show();
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            FormPostStatus startPostStatusForm = new FormPostStatus(this);
            startPostStatusForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_ApplicationSystemManager.Logout();
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

            listBoxFriends.Items.Clear();
            listBoxEvents.Items.Clear();
            listBoxCheckins.Items.Clear();
        }

        private void buttonOptimalTimePost_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOptimalTime startOptimalTimeForm = new FormOptimalTime(this);
            startOptimalTimeForm.ShowDialog();
            this.Show();
        }

        private void buttonFetchData_Click(object sender, EventArgs e)
        {
            fetchFriends();
            fetchCheckins();
            fetchEvents();
        }
    }
}