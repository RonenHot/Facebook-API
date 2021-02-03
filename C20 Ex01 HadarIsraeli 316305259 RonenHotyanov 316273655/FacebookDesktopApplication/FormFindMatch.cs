using System;
using System.Windows.Forms;
using FacebookSystemApplicationLogic;
using FacebookWrapper.ObjectModel;
using Exception = System.Exception;

namespace FacebookDesktopApplication
{
    public partial class FormFindMatch : Form, IBackable
    {
        private readonly ApplicationSystemManager r_ApplicationSystemManager;
        private string m_AgeRange = string.Empty;
        private User m_SelectedMatchUser = null;

        public FormFindMatch(FormMain i_HomePage)
        {
            InitializeComponent();
            r_ApplicationSystemManager = i_HomePage.ApplicationSystemManager;
            fetchAgeRange();
        }

        public void Back()
        {
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void fetchAgeRange()
        {
            listBoxAgeRange.Items.Add("18-20");
            listBoxAgeRange.Items.Add("21-25");
            listBoxAgeRange.Items.Add("26-30");
            listBoxAgeRange.Items.Add("31-35");
            listBoxAgeRange.Items.Add("36-40");
            listBoxAgeRange.Items.Add("40+");
        }

        private void buttonFindYourMatch_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<User> matchCollection = null;

            if(!string.IsNullOrEmpty(m_AgeRange) 
               && (checkBoxFemale.Checked == true || checkBoxMale.Checked == true))
            {
                try
                {
                    matchCollection = r_ApplicationSystemManager.FindAMatchForMe(
                        checkBoxFemale.Checked,
                        checkBoxMale.Checked,
                        m_AgeRange);
                }
                catch(Exception exception)
                {
                    listBoxResults.Items.Clear();
                    buttonViewPictures.Enabled = false;
                    pictureBoxMatch.Image = null;
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    checkMatchCollection(matchCollection);
                }
            }
        }

        private void checkMatchCollection(FacebookObjectCollection<User> i_MatchCollection)
        {
            if (i_MatchCollection != null)
            {
                listBoxResults.Items.Clear();
                listBoxResults.DisplayMember = "Name";
                foreach (User userMatch in i_MatchCollection)
                {
                    listBoxResults.Items.Add(userMatch);
                }
            }
        }

        private void listBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_AgeRange = listBoxAgeRange.SelectedItem as string;
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                displaySelectedMatch();
            }
            catch(Exception)
            {
                MessageBox.Show("You have chosen an empty spot.");
            }
        }

        private void displaySelectedMatch()
        {
            if (listBoxResults.SelectedItems.Count == 1)
            {
                buttonViewPictures.Enabled = true;
                m_SelectedMatchUser = listBoxResults.SelectedItem as User;

                if (m_SelectedMatchUser.PictureNormalURL != null)
                {
                    pictureBoxMatch.LoadAsync(m_SelectedMatchUser.PictureNormalURL);
                }
                else
                {
                    pictureBoxMatch.Image = pictureBoxMatch.ErrorImage;
                }
            }
        }

        private void buttonViewPictures_Click(object sender, EventArgs e)
        {
            FormAlbumPictures startAlbumPictureForm = new FormAlbumPictures(m_SelectedMatchUser);
            startAlbumPictureForm.ShowDialog();
        }
    }
}
