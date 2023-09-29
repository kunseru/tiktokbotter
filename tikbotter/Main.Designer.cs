namespace tikbotter
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.loadButton = new MetroFramework.Controls.MetroButton();
            this.usernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.generalPage = new MetroFramework.Controls.MetroTabPage();
            this.loadedUserDescription = new MetroFramework.Controls.MetroLabel();
            this.likesLabel = new MetroFramework.Controls.MetroLabel();
            this.likesIcon = new System.Windows.Forms.PictureBox();
            this.followingLabel = new MetroFramework.Controls.MetroLabel();
            this.followingIcon = new System.Windows.Forms.PictureBox();
            this.followerLabel = new MetroFramework.Controls.MetroLabel();
            this.followerIcon = new System.Windows.Forms.PictureBox();
            this.verified = new System.Windows.Forms.PictureBox();
            this.spaceholderLines = new MetroFramework.Controls.MetroLabel();
            this.loadedUserNickname = new MetroFramework.Controls.MetroLabel();
            this.spaceholderDot = new MetroFramework.Controls.MetroLabel();
            this.loadedUserUsername = new MetroFramework.Controls.MetroLabel();
            this.loadedUserImage = new System.Windows.Forms.PictureBox();
            this.botterPage = new MetroFramework.Controls.MetroTabPage();
            this.tabControl.SuspendLayout();
            this.generalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.followingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.followerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(199, 24);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(37, 23);
            this.loadButton.Style = MetroFramework.MetroColorStyle.Magenta;
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load";
            this.loadButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(94, 24);
            this.usernameTextbox.MaxLength = 16;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(99, 23);
            this.usernameTextbox.Style = MetroFramework.MetroColorStyle.Magenta;
            this.usernameTextbox.TabIndex = 0;
            this.usernameTextbox.Text = "kunseru";
            this.usernameTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalPage);
            this.tabControl.Controls.Add(this.botterPage);
            this.tabControl.Location = new System.Drawing.Point(8, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(457, 195);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tabControl.TabIndex = 4;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl.UseStyleColors = true;
            // 
            // generalPage
            // 
            this.generalPage.Controls.Add(this.loadedUserDescription);
            this.generalPage.Controls.Add(this.likesLabel);
            this.generalPage.Controls.Add(this.likesIcon);
            this.generalPage.Controls.Add(this.followingLabel);
            this.generalPage.Controls.Add(this.followingIcon);
            this.generalPage.Controls.Add(this.followerLabel);
            this.generalPage.Controls.Add(this.followerIcon);
            this.generalPage.Controls.Add(this.verified);
            this.generalPage.Controls.Add(this.spaceholderLines);
            this.generalPage.Controls.Add(this.loadedUserNickname);
            this.generalPage.Controls.Add(this.spaceholderDot);
            this.generalPage.Controls.Add(this.loadedUserUsername);
            this.generalPage.Controls.Add(this.loadedUserImage);
            this.generalPage.HorizontalScrollbarBarColor = true;
            this.generalPage.Location = new System.Drawing.Point(4, 35);
            this.generalPage.Name = "generalPage";
            this.generalPage.Size = new System.Drawing.Size(449, 156);
            this.generalPage.Style = MetroFramework.MetroColorStyle.Magenta;
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "General";
            this.generalPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.generalPage.VerticalScrollbarBarColor = true;
            // 
            // loadedUserDescription
            // 
            this.loadedUserDescription.AutoSize = true;
            this.loadedUserDescription.Location = new System.Drawing.Point(105, 48);
            this.loadedUserDescription.Name = "loadedUserDescription";
            this.loadedUserDescription.Size = new System.Drawing.Size(184, 19);
            this.loadedUserDescription.Style = MetroFramework.MetroColorStyle.Magenta;
            this.loadedUserDescription.TabIndex = 15;
            this.loadedUserDescription.Text = "live with passion, live musica.ly";
            this.loadedUserDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // likesLabel
            // 
            this.likesLabel.AutoSize = true;
            this.likesLabel.Location = new System.Drawing.Point(340, 92);
            this.likesLabel.Name = "likesLabel";
            this.likesLabel.Size = new System.Drawing.Size(16, 19);
            this.likesLabel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.likesLabel.TabIndex = 14;
            this.likesLabel.Text = "0";
            this.likesLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // likesIcon
            // 
            this.likesIcon.BackColor = System.Drawing.Color.Transparent;
            this.likesIcon.Image = global::tikbotter.Properties.Resources.likes1;
            this.likesIcon.Location = new System.Drawing.Point(310, 89);
            this.likesIcon.Name = "likesIcon";
            this.likesIcon.Size = new System.Drawing.Size(24, 24);
            this.likesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.likesIcon.TabIndex = 13;
            this.likesIcon.TabStop = false;
            // 
            // followingLabel
            // 
            this.followingLabel.AutoSize = true;
            this.followingLabel.Location = new System.Drawing.Point(246, 92);
            this.followingLabel.Name = "followingLabel";
            this.followingLabel.Size = new System.Drawing.Size(16, 19);
            this.followingLabel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.followingLabel.TabIndex = 12;
            this.followingLabel.Text = "0";
            this.followingLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // followingIcon
            // 
            this.followingIcon.BackColor = System.Drawing.Color.Transparent;
            this.followingIcon.Image = global::tikbotter.Properties.Resources.following;
            this.followingIcon.Location = new System.Drawing.Point(210, 89);
            this.followingIcon.Name = "followingIcon";
            this.followingIcon.Size = new System.Drawing.Size(24, 24);
            this.followingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.followingIcon.TabIndex = 11;
            this.followingIcon.TabStop = false;
            // 
            // followerLabel
            // 
            this.followerLabel.AutoSize = true;
            this.followerLabel.Location = new System.Drawing.Point(148, 92);
            this.followerLabel.Name = "followerLabel";
            this.followerLabel.Size = new System.Drawing.Size(16, 19);
            this.followerLabel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.followerLabel.TabIndex = 10;
            this.followerLabel.Text = "0";
            this.followerLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // followerIcon
            // 
            this.followerIcon.BackColor = System.Drawing.Color.Transparent;
            this.followerIcon.Image = global::tikbotter.Properties.Resources.follower1;
            this.followerIcon.Location = new System.Drawing.Point(110, 89);
            this.followerIcon.Name = "followerIcon";
            this.followerIcon.Size = new System.Drawing.Size(24, 24);
            this.followerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.followerIcon.TabIndex = 9;
            this.followerIcon.TabStop = false;
            // 
            // verified
            // 
            this.verified.BackColor = System.Drawing.Color.Transparent;
            this.verified.Image = global::tikbotter.Properties.Resources.verified;
            this.verified.Location = new System.Drawing.Point(246, 22);
            this.verified.Name = "verified";
            this.verified.Size = new System.Drawing.Size(20, 20);
            this.verified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verified.TabIndex = 8;
            this.verified.TabStop = false;
            // 
            // spaceholderLines
            // 
            this.spaceholderLines.AutoSize = true;
            this.spaceholderLines.Location = new System.Drawing.Point(104, 67);
            this.spaceholderLines.Name = "spaceholderLines";
            this.spaceholderLines.Size = new System.Drawing.Size(345, 19);
            this.spaceholderLines.Style = MetroFramework.MetroColorStyle.Magenta;
            this.spaceholderLines.TabIndex = 7;
            this.spaceholderLines.Text = "————————————————————————";
            this.spaceholderLines.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loadedUserNickname
            // 
            this.loadedUserNickname.AutoSize = true;
            this.loadedUserNickname.Location = new System.Drawing.Point(187, 22);
            this.loadedUserNickname.Name = "loadedUserNickname";
            this.loadedUserNickname.Size = new System.Drawing.Size(53, 19);
            this.loadedUserNickname.Style = MetroFramework.MetroColorStyle.Magenta;
            this.loadedUserNickname.TabIndex = 6;
            this.loadedUserNickname.Text = "kunseru";
            this.loadedUserNickname.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // spaceholderDot
            // 
            this.spaceholderDot.AutoSize = true;
            this.spaceholderDot.Location = new System.Drawing.Point(164, 22);
            this.spaceholderDot.Name = "spaceholderDot";
            this.spaceholderDot.Size = new System.Drawing.Size(17, 19);
            this.spaceholderDot.Style = MetroFramework.MetroColorStyle.Magenta;
            this.spaceholderDot.TabIndex = 5;
            this.spaceholderDot.Text = "●";
            this.spaceholderDot.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loadedUserUsername
            // 
            this.loadedUserUsername.AutoSize = true;
            this.loadedUserUsername.Location = new System.Drawing.Point(105, 22);
            this.loadedUserUsername.Name = "loadedUserUsername";
            this.loadedUserUsername.Size = new System.Drawing.Size(53, 19);
            this.loadedUserUsername.Style = MetroFramework.MetroColorStyle.Magenta;
            this.loadedUserUsername.TabIndex = 4;
            this.loadedUserUsername.Text = "kunseru";
            this.loadedUserUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loadedUserImage
            // 
            this.loadedUserImage.BackColor = System.Drawing.Color.Transparent;
            this.loadedUserImage.Image = global::tikbotter.Properties.Resources._default;
            this.loadedUserImage.Location = new System.Drawing.Point(25, 22);
            this.loadedUserImage.Name = "loadedUserImage";
            this.loadedUserImage.Size = new System.Drawing.Size(64, 64);
            this.loadedUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadedUserImage.TabIndex = 3;
            this.loadedUserImage.TabStop = false;
            // 
            // botterPage
            // 
            this.botterPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.botterPage.HorizontalScrollbarBarColor = true;
            this.botterPage.Location = new System.Drawing.Point(4, 35);
            this.botterPage.Name = "botterPage";
            this.botterPage.Size = new System.Drawing.Size(449, 156);
            this.botterPage.Style = MetroFramework.MetroColorStyle.Magenta;
            this.botterPage.TabIndex = 1;
            this.botterPage.Text = "Botter";
            this.botterPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.botterPage.VerticalScrollbarBarColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 250);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.usernameTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "TikTok";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.generalPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.followingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.followerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton loadButton;
        private System.Windows.Forms.PictureBox loadedUserImage;
        private MetroFramework.Controls.MetroTextBox usernameTextbox;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage generalPage;
        private MetroFramework.Controls.MetroLabel loadedUserUsername;
        private MetroFramework.Controls.MetroLabel loadedUserNickname;
        private MetroFramework.Controls.MetroLabel spaceholderDot;
        private MetroFramework.Controls.MetroLabel spaceholderLines;
        private System.Windows.Forms.PictureBox verified;
        private System.Windows.Forms.PictureBox followerIcon;
        private MetroFramework.Controls.MetroLabel followerLabel;
        private MetroFramework.Controls.MetroLabel followingLabel;
        private System.Windows.Forms.PictureBox followingIcon;
        private MetroFramework.Controls.MetroLabel likesLabel;
        private System.Windows.Forms.PictureBox likesIcon;
        private MetroFramework.Controls.MetroLabel loadedUserDescription;
        private MetroFramework.Controls.MetroTabPage botterPage;
    }
}

