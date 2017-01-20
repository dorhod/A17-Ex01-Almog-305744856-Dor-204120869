using System;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using A17_Ex01_Logic;
using System.Threading;

// $G$ RUL-003 (-10) Diagram document should be attached to the solution.
// $G$ CSS-016 (-15) Bad class name - The name of classes derived from Form should begin with Form.
// $G$ CSS-999 (-10) StyleCop errors
// $G$ SFN-001 (-3) Basic facebook experience is poor.

// $G$ THE-001 (-29) your grade on diagrams document - 71. please see comments inside the document. 

namespace A17_Ex01_UI
{
    public partial class FormAppHomepage : Form
    {
        User m_LoggedInUser;
        object key;

        public FormAppHomepage()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            AppSettings Settings = AppSettings.LoadToFile();

            if(AppSettings.GetSettings().LastAccessToken != null)
            {
                try
                {
                    LoginResult result = FacebookService.Connect(AppSettings.GetSettings().LastAccessToken);
                    checkLoginResult(result);
                }catch (Exception ex)
                {
                    AppSettings.GetSettings().LastAccessToken = null;
                }
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

        private void checkLoginResult(LoginResult i_LoginResult)
        {
            if (!string.IsNullOrEmpty(i_LoginResult.AccessToken))
            {
                m_LoggedInUser = i_LoginResult.LoggedInUser;
                AppSettings.GetSettings().LastAccessToken = i_LoginResult.AccessToken;
                buttonLogin.Text = "Logout";
                setUserInfo();
            }
            else
            {
                MessageBox.Show(i_LoginResult.ErrorMessage);
            }
        }

        private void setUserInfo()
        {
            Cursor = System.Windows.Forms.Cursors.AppStarting;
            pictureBoxProfilPicture.LoadAsync(m_LoggedInUser.PictureNormalURL);

            TabPage tabPagePhotos = createTabPage();
            fetchUserPhotos(tabPagePhotos);

            TabPage tabPageFeed = createTabPage();
            fetchUserFeed(tabPageFeed);

            Cursor = System.Windows.Forms.Cursors.Default;
        }

        private TabPage createTabPage()
        {
            TabPage tabPageFeed = new TabPage();
            addPage(tabPageFeed);
            return tabPageFeed;
        }

        private void fetchUserFeed(TabPage tabPageFeed)
        {
            tabPageFeed.Text = "Feed";
            UserControlFilterWall PageFeed = new UserControlFilterWall();
            tabPageFeed.Controls.Add(PageFeed);

            PageFeed.fetchPosts();
        }

        private void fetchUserPhotos(TabPage tabPagePhotos) { 
            tabPagePhotos.Text = "Photos";
            tabPagePhotos.Controls.Add(new UserControlImageSearcher(m_LoggedInUser));
        }


        private void addPage(TabPage page)
        {
            lock (this) { 
                tabControlFeatureViewer.TabPages.Add(page);
            }
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
                pictureBoxProfilPicture.ImageLocation = "";
                tabControlFeatureViewer.TabPages.Clear();
                buttonLogin.Text = "Login";
            }
        }

    }
}
