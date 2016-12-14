using System;
using System.ComponentModel;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Xml.Serialization;
using System.Xml;



namespace A17_Ex01_UI
{
    public partial class AppHomepage : Form
    {
        public AppHomepage()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            AppSettings Settings = AppSettings.LoadToFile();

            if(AppSettings.GetSettings().m_lastAccessToken != null)
            {
                LoginResult result = FacebookService.Connect(AppSettings.GetSettings().m_lastAccessToken);
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
                buttonLogin.Text = "Logout";
            }
            base.OnLoad(e);
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            AppSettings.SaveToFile();
            base.OnClosing(e);

        }

        User m_LoggedInUser;
        
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
                CheckLoginResult(result);
            }
            
        }

        private void CheckLoginResult(LoginResult loginResult)
        {
            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                m_LoggedInUser = loginResult.LoggedInUser;
                AppSettings.GetSettings().m_lastAccessToken = loginResult.AccessToken;
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
            pictureBoxProfilPicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            fetchUserFeed();
            fetchUserPhotos();
        }

        private void fetchUserFeed()
        {
            TabPage tabPageFeed = new TabPage();
            tabPageFeed.Text = "Feed";
            tabPageFeed.Controls.Add(new FilterFeed());
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

        
        private void pictureBoxProfilPicture_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBoxUserTaggedWith_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewPhotoDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxColoredBlockTop_Click(object sender, EventArgs e)
        {

        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {

        }

        private void SwitchPanelView(Control i_View)
        {
 
        }

        private void buttonPhotos_Click(object sender, EventArgs e)
        {
            ImageSearcher imageSearcher = new ImageSearcher(m_LoggedInUser);
            SwitchPanelView(imageSearcher);
        }
    }
}
