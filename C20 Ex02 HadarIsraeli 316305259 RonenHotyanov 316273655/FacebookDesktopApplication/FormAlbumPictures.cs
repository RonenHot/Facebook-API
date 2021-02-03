using System;
using System.Windows.Forms;
using FacebookSystemApplicationLogic;
using FacebookWrapper.ObjectModel;
using Exception = System.Exception;

namespace FacebookDesktopApplication
{
    public partial class FormAlbumPictures : Form, IBackable, INextable, ICloseable
    {
        private readonly User r_SelectedMatchedUser;
        private int m_Indexer = 0;
        
        public FormAlbumPictures(PotentialMatchUserProxy i_SelectedMatchedUserProxy)
        {
            InitializeComponent();
            r_SelectedMatchedUser = i_SelectedMatchedUserProxy.FaceBookUser;
            pictureBoxAlbumPhoto.LoadAsync(r_SelectedMatchedUser.Albums[0].Photos[m_Indexer].PictureNormalURL);
        }

        public void Back()
        {
            try
            {
                if(m_Indexer == 1)
                {
                    buttonBack.Enabled = false;
                }

                if(m_Indexer <= r_SelectedMatchedUser.Albums[0].Photos.Count - 1 && !buttonNext.Enabled)
                {
                    buttonNext.Enabled = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Photo.");
            }
            finally
            {
                m_Indexer--;
                pictureBoxAlbumPhoto.LoadAsync(r_SelectedMatchedUser.Albums[0].Photos[m_Indexer].PictureNormalURL);
            }
        }

        public void Next()
        {
            try
            {
                if(r_SelectedMatchedUser.Albums[0].Photos.Count == 1)
                {
                    MessageBox.Show("No more pictrues.");
                    CloseForm();
                    m_Indexer--;
                }
                else if(m_Indexer >= 0 && !buttonBack.Enabled)
                {
                    buttonBack.Enabled = true;
                }

                if(m_Indexer == r_SelectedMatchedUser.Albums[0].Photos.Count - 2)
                {
                    buttonNext.Enabled = false;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Photo.");
            }
            finally
            {
                m_Indexer++;
                pictureBoxAlbumPhoto.LoadAsync(r_SelectedMatchedUser.Albums[0].Photos[m_Indexer].PictureNormalURL);
            }
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
