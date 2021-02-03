namespace FacebookDesktopApplication
{
    public partial class FormOptimalTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelFetchPosts = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.labelFetchComments = new System.Windows.Forms.Label();
            this.listBoxLikeBy = new System.Windows.Forms.ListBox();
            this.labelFetchLikeBy = new System.Windows.Forms.Label();
            this.panelBestTimeToShare = new System.Windows.Forms.Panel();
            this.labelBestTimeToShare = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.buttonShowBestTimeToShare = new System.Windows.Forms.Button();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.likedByBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBestTimeToShare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedByBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 28;
            this.listBoxPosts.Location = new System.Drawing.Point(15, 181);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(238, 200);
            this.listBoxPosts.TabIndex = 102;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // labelFetchPosts
            // 
            this.labelFetchPosts.AutoSize = true;
            this.labelFetchPosts.ForeColor = System.Drawing.Color.White;
            this.labelFetchPosts.Location = new System.Drawing.Point(90, 130);
            this.labelFetchPosts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFetchPosts.Name = "labelFetchPosts";
            this.labelFetchPosts.Size = new System.Drawing.Size(69, 29);
            this.labelFetchPosts.TabIndex = 103;
            this.labelFetchPosts.Text = "Posts:";
            // 
            // listBoxComments
            // 
            this.listBoxComments.DataSource = this.commentsBindingSource;
            this.listBoxComments.DisplayMember = "Message";
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 28;
            this.listBoxComments.Location = new System.Drawing.Point(300, 181);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(238, 200);
            this.listBoxComments.TabIndex = 104;
            this.listBoxComments.ValueMember = "Comments";
            // 
            // labelFetchComments
            // 
            this.labelFetchComments.AutoSize = true;
            this.labelFetchComments.ForeColor = System.Drawing.Color.White;
            this.labelFetchComments.Location = new System.Drawing.Point(362, 130);
            this.labelFetchComments.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFetchComments.Name = "labelFetchComments";
            this.labelFetchComments.Size = new System.Drawing.Size(122, 29);
            this.labelFetchComments.TabIndex = 105;
            this.labelFetchComments.Text = "Comments:";
            // 
            // listBoxLikeBy
            // 
            this.listBoxLikeBy.DataSource = this.likedByBindingSource;
            this.listBoxLikeBy.DisplayMember = "Name";
            this.listBoxLikeBy.FormattingEnabled = true;
            this.listBoxLikeBy.ItemHeight = 28;
            this.listBoxLikeBy.Location = new System.Drawing.Point(613, 181);
            this.listBoxLikeBy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBoxLikeBy.Name = "listBoxLikeBy";
            this.listBoxLikeBy.Size = new System.Drawing.Size(238, 200);
            this.listBoxLikeBy.TabIndex = 106;
            this.listBoxLikeBy.ValueMember = "About";
            // 
            // labelFetchLikeBy
            // 
            this.labelFetchLikeBy.AutoSize = true;
            this.labelFetchLikeBy.ForeColor = System.Drawing.Color.White;
            this.labelFetchLikeBy.Location = new System.Drawing.Point(683, 130);
            this.labelFetchLikeBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFetchLikeBy.Name = "labelFetchLikeBy";
            this.labelFetchLikeBy.Size = new System.Drawing.Size(80, 29);
            this.labelFetchLikeBy.TabIndex = 107;
            this.labelFetchLikeBy.Text = "LikeBy:";
            // 
            // panelBestTimeToShare
            // 
            this.panelBestTimeToShare.Controls.Add(this.labelBestTimeToShare);
            this.panelBestTimeToShare.Controls.Add(this.buttonBack);
            this.panelBestTimeToShare.Controls.Add(this.pictureBoxFacebookLogo);
            this.panelBestTimeToShare.Location = new System.Drawing.Point(1, 1);
            this.panelBestTimeToShare.Name = "panelBestTimeToShare";
            this.panelBestTimeToShare.Size = new System.Drawing.Size(868, 100);
            this.panelBestTimeToShare.TabIndex = 10;
            // 
            // labelBestTimeToShare
            // 
            this.labelBestTimeToShare.AutoSize = true;
            this.labelBestTimeToShare.Font = new System.Drawing.Font("Calibri", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestTimeToShare.ForeColor = System.Drawing.Color.White;
            this.labelBestTimeToShare.Location = new System.Drawing.Point(148, 22);
            this.labelBestTimeToShare.Name = "labelBestTimeToShare";
            this.labelBestTimeToShare.Size = new System.Drawing.Size(389, 58);
            this.labelBestTimeToShare.TabIndex = 20;
            this.labelBestTimeToShare.Text = "Best Time to Share";
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(743, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(107, 94);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxFacebookLogo
            // 
            this.pictureBoxFacebookLogo.Image = global::FacebookDesktopApplication.Properties.Resources.imageFacebookLogoTitle;
            this.pictureBoxFacebookLogo.Location = new System.Drawing.Point(11, 0);
            this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
            this.pictureBoxFacebookLogo.Size = new System.Drawing.Size(98, 97);
            this.pictureBoxFacebookLogo.TabIndex = 7;
            this.pictureBoxFacebookLogo.TabStop = false;
            // 
            // buttonShowBestTimeToShare
            // 
            this.buttonShowBestTimeToShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowBestTimeToShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowBestTimeToShare.ForeColor = System.Drawing.Color.White;
            this.buttonShowBestTimeToShare.Location = new System.Drawing.Point(267, 444);
            this.buttonShowBestTimeToShare.Name = "buttonShowBestTimeToShare";
            this.buttonShowBestTimeToShare.Size = new System.Drawing.Size(341, 54);
            this.buttonShowBestTimeToShare.TabIndex = 108;
            this.buttonShowBestTimeToShare.Text = "Show best time to share";
            this.buttonShowBestTimeToShare.UseVisualStyleBackColor = true;
            this.buttonShowBestTimeToShare.Click += new System.EventHandler(this.buttonShowBestTimeToShare_Click);
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Comment);
            // 
            // likedByBindingSource
            // 
            this.likedByBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // FormOptimalTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.BackgroundImage = global::FacebookDesktopApplication.Properties.Resources.backgroundBestTimeToShare;
            this.ClientSize = new System.Drawing.Size(865, 535);
            this.Controls.Add(this.buttonShowBestTimeToShare);
            this.Controls.Add(this.panelBestTimeToShare);
            this.Controls.Add(this.labelFetchLikeBy);
            this.Controls.Add(this.listBoxLikeBy);
            this.Controls.Add(this.labelFetchComments);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.labelFetchPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormOptimalTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Best Time to Share";
            this.panelBestTimeToShare.ResumeLayout(false);
            this.panelBestTimeToShare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedByBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelFetchPosts;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label labelFetchComments;
        private System.Windows.Forms.ListBox listBoxLikeBy;
        private System.Windows.Forms.Label labelFetchLikeBy;
        private System.Windows.Forms.Panel panelBestTimeToShare;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelBestTimeToShare;
        private System.Windows.Forms.Button buttonShowBestTimeToShare;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.BindingSource likedByBindingSource;
    }
}