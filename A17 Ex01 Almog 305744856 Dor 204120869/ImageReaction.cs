using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;
using System.Dynamic;
using A17_Ex01_Logic;

namespace A17_Ex01_UI
{
    public partial class ImageReaction : Form
    {
        private Photo m_CurrentPicture;
        private readonly FacebookClient r_FbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);

        public ImageReaction(Photo i_SelectedPhotoFromUser)
        {
            InitializeComponent();
            m_CurrentPicture = i_SelectedPhotoFromUser;
            r_FbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);
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

            r_FbUser.Post("/comments", commentDicitonay);
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
                r_FbUser.Post("me/feed", parameters);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    
    }
}
