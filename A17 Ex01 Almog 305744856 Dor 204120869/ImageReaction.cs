using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Dynamic;
using A17_Ex01_Logic;

namespace A17_Ex01_UI
{
    public partial class ImageReaction : Form
    {
        private Photo m_CurrentPicture;
        FacebookClient fbUser;

        public ImageReaction(Photo i_SelectedPhotoFromUser)
        {
            InitializeComponent();
            m_CurrentPicture = i_SelectedPhotoFromUser;
            fbUser = new FacebookClient(AppSettings.GetSettings().m_lastAccessToken);
            displayPhoto();
        }

        private void displayPhoto()
        {
            try
            {
                pictureBoxSelectedPicture.Image = m_CurrentPicture.ImageNormal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> commentDicitonay = new Dictionary<string, object>
            {
                {"id", m_CurrentPicture.Id},
                {"message", textBoxAddAComment.Text}
            };

            fbUser.Post("/comments", commentDicitonay);
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
           try
           {
                dynamic parameters = new ExpandoObject();
                parameters.message = textBoxAddAComment.Text;
                parameters.link = m_CurrentPicture.Link;
                parameters.picture = "postInfo.ImageUrl";
                parameters.story_tags = " ";

                fbUser.Post("me/feed", parameters);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    
        private void pictureBoxSelectedPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
