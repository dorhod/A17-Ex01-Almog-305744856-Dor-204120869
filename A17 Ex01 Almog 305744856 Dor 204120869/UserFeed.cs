using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A17_Ex01_UI
{
    public partial class UserFeed : Form
    {
        User fbUser;

        public UserFeed(AppSettings i_Settings)
        {
            InitializeComponent();
            LoginResult result = FacebookService.Connect(i_Settings.m_lastAccessToken);
            fbUser = result.LoggedInUser;
        }

        protected override void OnLoad(EventArgs e)
        {
            FatchFeed();
            base.OnLoad(e);
        }

        public void FatchFeed()
        {
            FacebookObjectCollection<Post> userFeed = fbUser.NewsFeed;
            foreach (Post post in userFeed)
            {
                Console.WriteLine(post.Message);
            }
        }


    }
}
