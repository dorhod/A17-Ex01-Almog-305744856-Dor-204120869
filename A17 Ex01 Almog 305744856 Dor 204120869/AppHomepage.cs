using System;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using A17_Ex01_Logic;

namespace A17_Ex01_UI
{
    public partial class AppHomepage : Form
    {
        User m_LoggedInUser;

        public AppHomepage()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            AppSettings Settings = AppSettings.LoadToFile();

            if(AppSettings.GetSettings().LastAccessToken != null)
            {
                LoginResult result = FacebookService.Connect(AppSettings.GetSettings().LastAccessToken);
                checkLoginResult(result);
            }
            base.OnShown(e);
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            AppSettings.SaveToFile();
            base.OnClosing(e);
        }
        
        private void loginToUser()
        {
            if (m_LoggedInUser == null)
            {
                LoginResult result = FacebookService.Login("596174253921671",
                    "public_profile",
                    "user_education_history",
                    "user_birthday",
                    "user_actions.video",
                    "user_actions.news",
                    "user_actions.music",
                    "user_actions.fitness",
                    "user_actions.books",
                    "user_about_me",
                    "user_friends",
                    "publish_actions",
                    "user_events",
                    "user_games_activity",
                    "user_hometown",
                    "user_likes",
                    "user_location",
                    "user_managed_groups",
                    "user_photos",
                    "user_posts",
                    "user_relationships",
                    "user_relationship_details",
                    "user_religion_politics",
                    "user_tagged_places",
                    "user_videos",
                    "user_website",
                    "user_work_history",
                    "read_custom_friendlists",
                    "read_page_mailboxes",
                    "manage_pages",
                    "pages_show_list",
                    "publish_pages",
                    "publish_actions",
                    "rsvp_event"
                    );
                checkLoginResult(result);
            }  
        }

        private void checkLoginResult(LoginResult loginResult)
        {
            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                m_LoggedInUser = loginResult.LoggedInUser;
                AppSettings.GetSettings().LastAccessToken = loginResult.AccessToken;
                buttonLogin.Text = "Logout";
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            Cursor = System.Windows.Forms.Cursors.AppStarting;
            pictureBoxProfilPicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            fetchUserFeed();
            fetchUserPhotos();
            Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void fetchUserFeed()
        {
            TabPage tabPageFeed = new TabPage();
            tabPageFeed.Text = "Feed";
            tabPageFeed.Controls.Add(new FilterWall());
            tabControlFeatureViewer.TabPages.Add(tabPageFeed);
        }

        private void fetchUserPhotos()
        {
            TabPage tabPagePhotos = new TabPage();
            tabPagePhotos.Text = "Photos";
            tabPagePhotos.Controls.Add(new ImageSearcher(m_LoggedInUser));
            tabControlFeatureViewer.TabPages.Add(tabPagePhotos);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser == null)
            {
                loginToUser();
            }
            else
            {
                m_LoggedInUser = null;
                buttonLogin.Text = "Login";
            }
        }

    }
}
