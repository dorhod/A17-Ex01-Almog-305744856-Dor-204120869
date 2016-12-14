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
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Dynamic;
using System.Net;



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
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(AppSettings));
                using (XmlReader reader = XmlReader.Create(@"UserSetting.xml"))
                {
                    m_Settings = (AppSettings)ser.Deserialize(reader);
                }


                if (m_Settings.m_lastAccessToken != null)
                {
                    LoginResult result = FacebookService.Connect(m_Settings.m_lastAccessToken);
                    CheckLoginResult(result);
                }
            } catch(Exception exp)
            {

            }

            base.OnLoad(e);
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {

            m_Settings.Save();
            base.OnClosing(e);

        }

        User m_LoggedInUser;
        AppSettings m_Settings = new AppSettings();
        
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
                m_Settings.m_lastAccessToken = loginResult.AccessToken;
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
            FilterFeed filterFeed = new FilterFeed(m_Settings);
            SwitchPanelView(filterFeed);
        }

        private void SwitchPanelView(Control i_View)
        {
            panel_FeatureViewer.Controls.Clear();
            panel_FeatureViewer.Controls.Add(i_View);
        }

        private void buttonPhotos_Click(object sender, EventArgs e)
        {
            ImageSearcher imageSearcher = new ImageSearcher(m_Settings, m_LoggedInUser);
            SwitchPanelView(imageSearcher);
        }
    }
}
