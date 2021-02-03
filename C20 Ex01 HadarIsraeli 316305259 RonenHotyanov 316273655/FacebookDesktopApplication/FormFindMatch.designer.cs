namespace FacebookDesktopApplication
{
    public partial class FormFindMatch
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
            this.labelFetchResults = new System.Windows.Forms.Label();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.labelFindYourOne = new System.Windows.Forms.Label();
            this.pictureBoxMatch = new System.Windows.Forms.PictureBox();
            this.labelInterestedIn = new System.Windows.Forms.Label();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.labeAgeRange = new System.Windows.Forms.Label();
            this.listBoxAgeRange = new System.Windows.Forms.ListBox();
            this.buttonFindYourMatch = new System.Windows.Forms.Button();
            this.buttonViewPictures = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFetchResults
            // 
            this.labelFetchResults.AutoSize = true;
            this.labelFetchResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.labelFetchResults.ForeColor = System.Drawing.Color.White;
            this.labelFetchResults.Location = new System.Drawing.Point(140, 434);
            this.labelFetchResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFetchResults.Name = "labelFetchResults";
            this.labelFetchResults.Size = new System.Drawing.Size(87, 29);
            this.labelFetchResults.TabIndex = 1;
            this.labelFetchResults.Text = "Results:";
            // 
            // listBoxResults
            // 
            this.listBoxResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.listBoxResults.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 28;
            this.listBoxResults.Location = new System.Drawing.Point(67, 479);
            this.listBoxResults.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(242, 172);
            this.listBoxResults.TabIndex = 10;
            this.listBoxResults.SelectedIndexChanged += new System.EventHandler(this.listBoxResults_SelectedIndexChanged);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.buttonBack);
            this.panelTitle.Controls.Add(this.pictureBoxFacebookLogo);
            this.panelTitle.Controls.Add(this.labelFindYourOne);
            this.panelTitle.Location = new System.Drawing.Point(0, -2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(833, 103);
            this.panelTitle.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(706, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(107, 94);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxFacebookLogo
            // 
            this.pictureBoxFacebookLogo.BackgroundImage = global::FacebookDesktopApplication.Properties.Resources.imageFacebookLogoTitle;
            this.pictureBoxFacebookLogo.Location = new System.Drawing.Point(22, 0);
            this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
            this.pictureBoxFacebookLogo.Size = new System.Drawing.Size(98, 97);
            this.pictureBoxFacebookLogo.TabIndex = 6;
            this.pictureBoxFacebookLogo.TabStop = false;
            // 
            // labelFindYourOne
            // 
            this.labelFindYourOne.AutoSize = true;
            this.labelFindYourOne.Font = new System.Drawing.Font("Calibri", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindYourOne.ForeColor = System.Drawing.Color.White;
            this.labelFindYourOne.Location = new System.Drawing.Point(150, 21);
            this.labelFindYourOne.Name = "labelFindYourOne";
            this.labelFindYourOne.Size = new System.Drawing.Size(297, 58);
            this.labelFindYourOne.TabIndex = 5;
            this.labelFindYourOne.Text = "Find Your One";
            // 
            // pictureBoxMatch
            // 
            this.pictureBoxMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.pictureBoxMatch.Location = new System.Drawing.Point(360, 479);
            this.pictureBoxMatch.Name = "pictureBoxMatch";
            this.pictureBoxMatch.Size = new System.Drawing.Size(173, 163);
            this.pictureBoxMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatch.TabIndex = 11;
            this.pictureBoxMatch.TabStop = false;
            // 
            // labelInterestedIn
            // 
            this.labelInterestedIn.AutoSize = true;
            this.labelInterestedIn.ForeColor = System.Drawing.Color.White;
            this.labelInterestedIn.Location = new System.Drawing.Point(205, 139);
            this.labelInterestedIn.Name = "labelInterestedIn";
            this.labelInterestedIn.Size = new System.Drawing.Size(138, 29);
            this.labelInterestedIn.TabIndex = 12;
            this.labelInterestedIn.Text = "Interested in:";
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.ForeColor = System.Drawing.Color.White;
            this.checkBoxMale.Location = new System.Drawing.Point(210, 185);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(85, 33);
            this.checkBoxMale.TabIndex = 13;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.ForeColor = System.Drawing.Color.White;
            this.checkBoxFemale.Location = new System.Drawing.Point(210, 233);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(105, 33);
            this.checkBoxFemale.TabIndex = 14;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // labeAgeRange
            // 
            this.labeAgeRange.AutoSize = true;
            this.labeAgeRange.ForeColor = System.Drawing.Color.White;
            this.labeAgeRange.Location = new System.Drawing.Point(529, 139);
            this.labeAgeRange.Name = "labeAgeRange";
            this.labeAgeRange.Size = new System.Drawing.Size(116, 29);
            this.labeAgeRange.TabIndex = 15;
            this.labeAgeRange.Text = "Age range:";
            // 
            // listBoxAgeRange
            // 
            this.listBoxAgeRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.listBoxAgeRange.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxAgeRange.FormattingEnabled = true;
            this.listBoxAgeRange.ItemHeight = 28;
            this.listBoxAgeRange.Location = new System.Drawing.Point(531, 185);
            this.listBoxAgeRange.Name = "listBoxAgeRange";
            this.listBoxAgeRange.Size = new System.Drawing.Size(114, 116);
            this.listBoxAgeRange.TabIndex = 16;
            this.listBoxAgeRange.SelectedIndexChanged += new System.EventHandler(this.listBoxAgeRange_SelectedIndexChanged);
            // 
            // buttonFindYourMatch
            // 
            this.buttonFindYourMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.buttonFindYourMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindYourMatch.FlatAppearance.BorderSize = 0;
            this.buttonFindYourMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindYourMatch.ForeColor = System.Drawing.Color.White;
            this.buttonFindYourMatch.Image = global::FacebookDesktopApplication.Properties.Resources.buttonFindYourMatch;
            this.buttonFindYourMatch.Location = new System.Drawing.Point(319, 305);
            this.buttonFindYourMatch.Name = "buttonFindYourMatch";
            this.buttonFindYourMatch.Size = new System.Drawing.Size(176, 83);
            this.buttonFindYourMatch.TabIndex = 17;
            this.buttonFindYourMatch.Text = "Find your match";
            this.buttonFindYourMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFindYourMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonFindYourMatch.UseVisualStyleBackColor = false;
            this.buttonFindYourMatch.Click += new System.EventHandler(this.buttonFindYourMatch_Click);
            // 
            // buttonViewPictures
            // 
            this.buttonViewPictures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.buttonViewPictures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewPictures.Enabled = false;
            this.buttonViewPictures.FlatAppearance.BorderSize = 0;
            this.buttonViewPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewPictures.ForeColor = System.Drawing.Color.White;
            this.buttonViewPictures.Location = new System.Drawing.Point(616, 521);
            this.buttonViewPictures.Name = "buttonViewPictures";
            this.buttonViewPictures.Size = new System.Drawing.Size(176, 83);
            this.buttonViewPictures.TabIndex = 18;
            this.buttonViewPictures.Text = "View more pictures";
            this.buttonViewPictures.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonViewPictures.UseVisualStyleBackColor = false;
            this.buttonViewPictures.Click += new System.EventHandler(this.buttonViewPictures_Click);
            // 
            // FormFindMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.BackgroundImage = global::FacebookDesktopApplication.Properties.Resources.backgroundFindAMatch;
            this.ClientSize = new System.Drawing.Size(834, 654);
            this.Controls.Add(this.buttonViewPictures);
            this.Controls.Add(this.labeAgeRange);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.listBoxAgeRange);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.labelInterestedIn);
            this.Controls.Add(this.pictureBoxMatch);
            this.Controls.Add(this.labelFetchResults);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.buttonFindYourMatch);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormFindMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Your One";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label labelFetchResults;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelFindYourOne;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxMatch;
        private System.Windows.Forms.Label labelInterestedIn;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.Label labeAgeRange;
        private System.Windows.Forms.ListBox listBoxAgeRange;
        private System.Windows.Forms.Button buttonFindYourMatch;
        private System.Windows.Forms.Button buttonViewPictures;
    }

    #endregion
}