using System;
using System.Windows.Forms;
using FacebookSystemApplicationLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopApplication
{
    public partial class FormOptimalTime : Form, IBackable
    {
        private readonly ApplicationSystemManager r_ApplicationSystemManager;
        private readonly FacebookObjectCollection<Post> r_UserPosts;

        public FormOptimalTime(FormMain i_HomePage)
        {
            InitializeComponent();
            r_ApplicationSystemManager = i_HomePage.ApplicationSystemManager;
            r_UserPosts = r_ApplicationSystemManager.GetPosts;
            fetchPosts();
        }

        /// <summary>
        /// Fetching all comments *** made by the logged in user ***, to the selected post:
        /// </summary>
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Post selectedPost = r_UserPosts[listBoxPosts.SelectedIndex];
                listBoxComments.DisplayMember = "Message";
                listBoxComments.DataSource = selectedPost.Comments;

                if (checkIfPostsLikedByGreaterThanZero(selectedPost))
                {
                    listBoxLikeBy.DataSource = selectedPost.LikedBy;
                }
                else
                {
                    listBoxLikeBy.Items.Add("No Items");
                }

                buttonShowBestTimeToShare.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("Invalid permission.{0}Reason: LikeBy.", Environment.NewLine));
            }
        }

        private bool checkIfPostsLikedByGreaterThanZero(Post i_Post)
        {
            return i_Post == null ? false : i_Post.LikedBy.Count > 0;
        }

        /// <summary>
        /// Fetching posts *** made by the logged in user***:
        /// </summary>
        private void fetchPosts()
        {
            foreach (Post post in r_UserPosts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (r_UserPosts.Count == 0)
            {
                MessageBox.Show("No posts to retrieve.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        public void Back()
        {
            this.Close();
        }

        private void buttonShowBestTimeToShare_Click(object sender, EventArgs e)
        {
            string bestDay;
            string bestTimeOnDay;

            try
            {
                r_ApplicationSystemManager.BestTimeToPost(r_UserPosts, out bestDay, out bestTimeOnDay);
                MessageBox.Show(
                    string.Format(
                        "The optimal day to post: {0}{1}{2}The optimal time to post: {3}",
                        bestDay,
                        Environment.NewLine,
                        Environment.NewLine,
                        bestTimeOnDay));
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("Invalid permission.{0}Reason: LikeBy.", Environment.NewLine));
            }
        }
    }
}
