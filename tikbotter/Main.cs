using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;
using tikbotter.service;

namespace tikbotter
{
    public partial class Main : MetroForm
    {

        private TikTokService TikTokService { get; } = new TikTokService();

        public Main()
        {
            InitializeComponent();

            {
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(loadedUserImage.DisplayRectangle);
                loadedUserImage.Region = new Region(path);
            }
        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            JObject userDetails = await TikTokService.GetUserDetailsAsync(usernameTextbox.Text);

            if (userDetails != null)
            {
                loadedUserImage.Load(userDetails["profile_image"].ToString());
                loadedUserUsername.Text = userDetails["username"].ToString();
                loadedUserNickname.Text = userDetails["nickname"].ToString();
                loadedUserDescription.Text = userDetails["description"].ToString();
                verified.Visible = bool.Parse(userDetails["verified"].ToString());
                followerLabel.Text = userDetails["followers"].ToString();
                followingLabel.Text = userDetails["following"].ToString();
                likesLabel.Text = userDetails["total_heart"].ToString();
            }
        }
    }
}
