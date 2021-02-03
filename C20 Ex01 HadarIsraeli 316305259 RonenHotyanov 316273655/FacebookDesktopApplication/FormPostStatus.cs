using System;
using System.Windows.Forms;
using FacebookSystemApplicationLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApplication
{
    public partial class FormPostStatus : Form
    {
        private readonly ApplicationSystemManager r_ApplicationSystemManager;

        public FormPostStatus(FormMain i_HomePage)
        {
            InitializeComponent();
            r_ApplicationSystemManager = i_HomePage.ApplicationSystemManager;
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            buttonPost.Enabled = textBoxStatus.Text.Length > 0;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_ApplicationSystemManager.GetUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid permission.");
            }
        }
    }
}
