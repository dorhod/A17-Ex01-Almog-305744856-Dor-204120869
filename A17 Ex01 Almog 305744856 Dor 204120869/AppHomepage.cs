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
            } catch(Exception ex)
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
        List<Photo> m_photoList = new List<Photo>();
        List<User> m_TagsWith = new List<User>();
        List<Photo> m_25photosList;
        List<Photo> m_photosCheckedByUser;
        List<UserWithPhotos> m_PhotosByUserList = new List<UserWithPhotos>();
        AppSettings m_Settings = new AppSettings();
        List<Photo> m_photosToReactOn = new List<Photo>();

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
            fetchAlltaggedPictures();

        }

        private void fetchAlltaggedPictures()
        {
            PicturesColleciton picture = m_LoggedInUser.Pictures;

            foreach (Album album in m_LoggedInUser.Albums)
            {
                addPhotos(album.Photos);
            }
            addPhotos(m_LoggedInUser.PhotosTaggedIn);
  
            m_25photosList = new List<Photo>();
            for (int i = 1; i < 5; i++)
            {
                m_25photosList.Add(m_photoList[i]);

            }

            showPhotos(m_25photosList);
        }

        private void showPhotos(List<Photo> photolist)
        {
            m_photosToReactOn.Clear();
            foreach (Photo photo in photolist)
            {
                imageListFromUser.Images.Add(photo.ImageNormal);
                m_photosToReactOn.Add(photo);
            }

            listViewPhotoDisplay.View = View.LargeIcon;
            listViewPhotoDisplay.LargeImageList = imageListFromUser;
            
            for (int j = 0; j < this.imageListFromUser.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listViewPhotoDisplay.Items.Add(item);
            }
        }

        private void addPhotos(FacebookObjectCollection<Photo> photos)
        { 
            string taggedUserName;
            int IndexOfTaggedUser;
            foreach (Photo photo in photos)
            {
                m_photoList.Add(photo);
                FacebookObjectCollection<PhotoTag> photoTags = photo.Tags;
                if (photo.Tags != null)
                {
                    foreach (PhotoTag photoTag in photoTags)
                    {
                        taggedUserName = photoTag.User.Name;
                        IndexOfTaggedUser = PhotosByUserListContains(taggedUserName);
                        if (IndexOfTaggedUser != -1)
                        {
                            m_PhotosByUserList[IndexOfTaggedUser].AddPhotoToUser(photo);
                        }
                        else
                        {
                            this.m_PhotosByUserList.Add(new UserWithPhotos(photoTag.User, photo));
                        }
                        if (!checkBoxUserTaggedWith.Items.Contains(taggedUserName))
                        {
                            m_TagsWith.Add(photoTag.User);
                            checkBoxUserTaggedWith.Items.Add(taggedUserName);
                        }
                    }
                }
            }
        }

        private int PhotosByUserListContains(string nameOfUser)
        {
            int indexOfTaggedUser = 0;
            foreach (UserWithPhotos taggedUser in this.m_PhotosByUserList)
            {
                if (taggedUser.m_TaggedUser.Name.Equals(nameOfUser))
                    return indexOfTaggedUser;
                indexOfTaggedUser++;
            }

            return -1;
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

        private void buttonSearchPhotos_Click(object sender, EventArgs e)
        {
            m_photosCheckedByUser = new List<Photo>();
            listViewPhotoDisplay.Clear();
            imageListFromUser.Dispose();
            Boolean b_FirstCheck = true;

            foreach (UserWithPhotos taggedUser in m_PhotosByUserList)
            {
                if (checkBoxUserTaggedWith.CheckedItems.Contains(taggedUser.m_TaggedUser.Name))
                {
                    if (b_FirstCheck)
                    {
                        foreach (Photo photo in taggedUser.m_PhotosOfUser)
                        {
                            if (!m_photosCheckedByUser.Contains(photo))
                            {
                                m_photosCheckedByUser.Add(photo);
                            }
                        }
                        b_FirstCheck = false;
                    }
                    else
                    {
                        List<Photo> newPhotoCheckedByUser = new List<Photo>();
                        foreach (Photo photo in m_photosCheckedByUser)
                        {
                            if (taggedUser.IsPhotoExist(photo))
                            {
                                newPhotoCheckedByUser.Add(photo);
                            }
                        }
                        m_photosCheckedByUser = newPhotoCheckedByUser;
                    }
                }
            }

            showPhotos(m_photosCheckedByUser);
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

        private void buttonRandomPhoto_Click(object sender, EventArgs e)
        {
            FacebookClient fbUser = new FacebookClient(m_Settings.m_lastAccessToken);
       
            Post postid = m_LoggedInUser.PostPhoto(@"C:\Users\dorho\Desktop\view.jpg", "Australia");
            //Comment comment =  postid.Comment("Lets test likes");
            postid.Like();
        }

        private void buttonOpenSelectedPhoto_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listViewPhotoDisplay.SelectedIndices[0]);
            UserFeed userFeed = new UserFeed(m_Settings);
            userFeed.Show();

            ImageReaction newImageReaction = new ImageReaction(m_photosToReactOn.ElementAt(listViewPhotoDisplay.SelectedIndices[0]), m_Settings);
            newImageReaction.Show();
        }
        
    }
}
