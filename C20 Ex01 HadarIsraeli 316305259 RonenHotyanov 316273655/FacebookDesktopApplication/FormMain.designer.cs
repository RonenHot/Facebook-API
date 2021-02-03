namespace FacebookDesktopApplication
{
    public partial class FormMain
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
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelFetchFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelCheckins = new System.Windows.Forms.Label();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.panelFacebookHomePage = new System.Windows.Forms.Panel();
            this.labelApplication = new System.Windows.Forms.Label();
            this.labelFacebook = new System.Windows.Forms.Label();
            this.panelAppOption = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.buttonFindaMatch = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonOptimalTimePost = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelFirstNameInfo = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelLastNameInfo = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelBirthdayInfo = new System.Windows.Forms.Label();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonFetchData = new System.Windows.Forms.Button();
            this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.panelFacebookHomePage.SuspendLayout();
            this.panelAppOption.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Enabled = false;
            this.checkBoxRememberMe.ForeColor = System.Drawing.Color.White;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(287, 184);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(176, 33);
            this.checkBoxRememberMe.TabIndex = 70;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // labelFetchFriends
            // 
            this.labelFetchFriends.AutoSize = true;
            this.labelFetchFriends.ForeColor = System.Drawing.Color.White;
            this.labelFetchFriends.Location = new System.Drawing.Point(319, 314);
            this.labelFetchFriends.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFetchFriends.Name = "labelFetchFriends";
            this.labelFetchFriends.Size = new System.Drawing.Size(88, 29);
            this.labelFetchFriends.TabIndex = 100;
            this.labelFetchFriends.Text = "Friends:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 28;
            this.listBoxFriends.Location = new System.Drawing.Point(258, 367);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(238, 312);
            this.listBoxFriends.TabIndex = 101;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.ForeColor = System.Drawing.Color.White;
            this.labelEvents.Location = new System.Drawing.Point(638, 314);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(81, 29);
            this.labelEvents.TabIndex = 150;
            this.labelEvents.Text = "Events:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 28;
            this.listBoxEvents.Location = new System.Drawing.Point(567, 367);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(238, 312);
            this.listBoxEvents.TabIndex = 200;
            // 
            // labelCheckins
            // 
            this.labelCheckins.AutoSize = true;
            this.labelCheckins.ForeColor = System.Drawing.Color.White;
            this.labelCheckins.Location = new System.Drawing.Point(937, 314);
            this.labelCheckins.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCheckins.Name = "labelCheckins";
            this.labelCheckins.Size = new System.Drawing.Size(103, 29);
            this.labelCheckins.TabIndex = 400;
            this.labelCheckins.Text = "Checkins:";
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 28;
            this.listBoxCheckins.Location = new System.Drawing.Point(880, 367);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(238, 312);
            this.listBoxCheckins.TabIndex = 401;
            // 
            // panelFacebookHomePage
            // 
            this.panelFacebookHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFacebookHomePage.Controls.Add(this.labelApplication);
            this.panelFacebookHomePage.Controls.Add(this.labelFacebook);
            this.panelFacebookHomePage.Location = new System.Drawing.Point(0, 9);
            this.panelFacebookHomePage.Name = "panelFacebookHomePage";
            this.panelFacebookHomePage.Size = new System.Drawing.Size(173, 134);
            this.panelFacebookHomePage.TabIndex = 10;
            // 
            // labelApplication
            // 
            this.labelApplication.AutoSize = true;
            this.labelApplication.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplication.ForeColor = System.Drawing.Color.Black;
            this.labelApplication.Location = new System.Drawing.Point(28, 75);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(139, 33);
            this.labelApplication.TabIndex = 6;
            this.labelApplication.Text = "Application";
            this.labelApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFacebook
            // 
            this.labelFacebook.AutoSize = true;
            this.labelFacebook.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFacebook.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacebook.ForeColor = System.Drawing.Color.Black;
            this.labelFacebook.Location = new System.Drawing.Point(28, 25);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(119, 33);
            this.labelFacebook.TabIndex = 5;
            this.labelFacebook.Text = "Facebook";
            this.labelFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAppOption
            // 
            this.panelAppOption.Controls.Add(this.buttonLogout);
            this.panelAppOption.Controls.Add(this.buttonPostStatus);
            this.panelAppOption.Controls.Add(this.buttonFindaMatch);
            this.panelAppOption.Controls.Add(this.panelFacebookHomePage);
            this.panelAppOption.Controls.Add(this.buttonLogin);
            this.panelAppOption.Controls.Add(this.buttonOptimalTimePost);
            this.panelAppOption.Location = new System.Drawing.Point(12, 14);
            this.panelAppOption.Name = "panelAppOption";
            this.panelAppOption.Size = new System.Drawing.Size(200, 896);
            this.panelAppOption.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Image = global::FacebookDesktopApplication.Properties.Resources.buttonLogout;
            this.buttonLogout.Location = new System.Drawing.Point(0, 570);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(173, 95);
            this.buttonLogout.TabIndex = 35;
            this.buttonLogout.Text = "Logout from Facebook";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.FlatAppearance.BorderSize = 0;
            this.buttonPostStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostStatus.ForeColor = System.Drawing.Color.White;
            this.buttonPostStatus.Image = global::FacebookDesktopApplication.Properties.Resources.buttonPostStatus1;
            this.buttonPostStatus.Location = new System.Drawing.Point(6, 461);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(158, 99);
            this.buttonPostStatus.TabIndex = 30;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPostStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // buttonFindaMatch
            // 
            this.buttonFindaMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindaMatch.Enabled = false;
            this.buttonFindaMatch.FlatAppearance.BorderSize = 0;
            this.buttonFindaMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindaMatch.ForeColor = System.Drawing.Color.White;
            this.buttonFindaMatch.Image = global::FacebookDesktopApplication.Properties.Resources.buttonFindAMatch;
            this.buttonFindaMatch.Location = new System.Drawing.Point(0, 256);
            this.buttonFindaMatch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonFindaMatch.Name = "buttonFindaMatch";
            this.buttonFindaMatch.Size = new System.Drawing.Size(181, 99);
            this.buttonFindaMatch.TabIndex = 20;
            this.buttonFindaMatch.Text = "Find A Match";
            this.buttonFindaMatch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFindaMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFindaMatch.UseVisualStyleBackColor = true;
            this.buttonFindaMatch.Click += new System.EventHandler(this.buttonFindAMatch_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Image = global::FacebookDesktopApplication.Properties.Resources.buttonLogin;
            this.buttonLogin.Location = new System.Drawing.Point(6, 151);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(173, 95);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Login to Facebook";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonOptimalTimePost
            // 
            this.buttonOptimalTimePost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOptimalTimePost.Enabled = false;
            this.buttonOptimalTimePost.FlatAppearance.BorderSize = 0;
            this.buttonOptimalTimePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptimalTimePost.ForeColor = System.Drawing.Color.White;
            this.buttonOptimalTimePost.Image = global::FacebookDesktopApplication.Properties.Resources.buttonOptimalTimePost;
            this.buttonOptimalTimePost.Location = new System.Drawing.Point(-7, 365);
            this.buttonOptimalTimePost.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonOptimalTimePost.Name = "buttonOptimalTimePost";
            this.buttonOptimalTimePost.Size = new System.Drawing.Size(188, 99);
            this.buttonOptimalTimePost.TabIndex = 25;
            this.buttonOptimalTimePost.Text = "Optimal Time to Post";
            this.buttonOptimalTimePost.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOptimalTimePost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOptimalTimePost.UseVisualStyleBackColor = true;
            this.buttonOptimalTimePost.Click += new System.EventHandler(this.buttonOptimalTimePost_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic);
            this.labelFirstName.ForeColor = System.Drawing.Color.White;
            this.labelFirstName.Location = new System.Drawing.Point(195, 21);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(120, 29);
            this.labelFirstName.TabIndex = 30;
            this.labelFirstName.Text = "First name:";
            // 
            // labelFirstNameInfo
            // 
            this.labelFirstNameInfo.AutoSize = true;
            this.labelFirstNameInfo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic);
            this.labelFirstNameInfo.ForeColor = System.Drawing.Color.White;
            this.labelFirstNameInfo.Location = new System.Drawing.Point(341, 21);
            this.labelFirstNameInfo.Name = "labelFirstNameInfo";
            this.labelFirstNameInfo.Size = new System.Drawing.Size(50, 29);
            this.labelFirstNameInfo.TabIndex = 35;
            this.labelFirstNameInfo.Text = "N/A";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic);
            this.labelLastName.ForeColor = System.Drawing.Color.White;
            this.labelLastName.Location = new System.Drawing.Point(195, 67);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(117, 29);
            this.labelLastName.TabIndex = 40;
            this.labelLastName.Text = "Last name:";
            // 
            // labelLastNameInfo
            // 
            this.labelLastNameInfo.AutoSize = true;
            this.labelLastNameInfo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic);
            this.labelLastNameInfo.ForeColor = System.Drawing.Color.White;
            this.labelLastNameInfo.Location = new System.Drawing.Point(341, 67);
            this.labelLastNameInfo.Name = "labelLastNameInfo";
            this.labelLastNameInfo.Size = new System.Drawing.Size(50, 29);
            this.labelLastNameInfo.TabIndex = 45;
            this.labelLastNameInfo.Text = "N/A";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic);
            this.labelBirthDay.ForeColor = System.Drawing.Color.White;
            this.labelBirthDay.Location = new System.Drawing.Point(195, 107);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(101, 29);
            this.labelBirthDay.TabIndex = 50;
            this.labelBirthDay.Text = "Birthday:";
            // 
            // labelBirthdayInfo
            // 
            this.labelBirthdayInfo.AutoSize = true;
            this.labelBirthdayInfo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic);
            this.labelBirthdayInfo.ForeColor = System.Drawing.Color.White;
            this.labelBirthdayInfo.Location = new System.Drawing.Point(341, 107);
            this.labelBirthdayInfo.Name = "labelBirthdayInfo";
            this.labelBirthdayInfo.Size = new System.Drawing.Size(50, 29);
            this.labelBirthdayInfo.TabIndex = 55;
            this.labelBirthdayInfo.Text = "N/A";
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panelUserInfo.Controls.Add(this.labelFirstName);
            this.panelUserInfo.Controls.Add(this.labelBirthdayInfo);
            this.panelUserInfo.Controls.Add(this.pictureBoxProfile);
            this.panelUserInfo.Controls.Add(this.labelBirthDay);
            this.panelUserInfo.Controls.Add(this.labelFirstNameInfo);
            this.panelUserInfo.Controls.Add(this.labelLastNameInfo);
            this.panelUserInfo.Controls.Add(this.labelLastName);
            this.panelUserInfo.Location = new System.Drawing.Point(258, 23);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(461, 166);
            this.panelUserInfo.TabIndex = 22;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(29, 17);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(134, 119);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonFetchData
            // 
            this.buttonFetchData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchData.Enabled = false;
            this.buttonFetchData.FlatAppearance.BorderSize = 0;
            this.buttonFetchData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchData.ForeColor = System.Drawing.Color.White;
            this.buttonFetchData.Image = global::FacebookDesktopApplication.Properties.Resources.buttonFetchData;
            this.buttonFetchData.Location = new System.Drawing.Point(831, 14);
            this.buttonFetchData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonFetchData.Name = "buttonFetchData";
            this.buttonFetchData.Size = new System.Drawing.Size(173, 95);
            this.buttonFetchData.TabIndex = 75;
            this.buttonFetchData.Text = "Fetch Data";
            this.buttonFetchData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFetchData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFetchData.UseVisualStyleBackColor = true;
            this.buttonFetchData.Click += new System.EventHandler(this.buttonFetchData_Click);
            // 
            // pictureBoxFacebookLogo
            // 
            this.pictureBoxFacebookLogo.Image = global::FacebookDesktopApplication.Properties.Resources.imageFacebookLogoTitle;
            this.pictureBoxFacebookLogo.Location = new System.Drawing.Point(1039, 12);
            this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
            this.pictureBoxFacebookLogo.Size = new System.Drawing.Size(98, 97);
            this.pictureBoxFacebookLogo.TabIndex = 402;
            this.pictureBoxFacebookLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1149, 689);
            this.Controls.Add(this.buttonFetchData);
            this.Controls.Add(this.pictureBoxFacebookLogo);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.panelAppOption);
            this.Controls.Add(this.listBoxCheckins);
            this.Controls.Add(this.labelCheckins);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelFetchFriends);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facebook Application";
            this.panelFacebookHomePage.ResumeLayout(false);
            this.panelFacebookHomePage.PerformLayout();
            this.panelAppOption.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label labelFetchFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelCheckins;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.Button buttonOptimalTimePost;
        private System.Windows.Forms.Panel panelFacebookHomePage;
        private System.Windows.Forms.Label labelFacebook;
        private System.Windows.Forms.Panel panelAppOption;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelFirstNameInfo;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelLastNameInfo;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelBirthdayInfo;
        private System.Windows.Forms.Button buttonFindaMatch;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        private System.Windows.Forms.Button buttonFetchData;
    }
}