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
using System.Dynamic;

namespace A17_Ex01_UI
{
    public partial class ImageReaction : Form
    {
        private Photo m_CurrentPicture;
        FacebookClient fbUser;

        public ImageReaction(Photo i_SelectedPhotoFromUser, AppSettings i_Settings)
        {
            InitializeComponent();
            m_CurrentPicture = i_SelectedPhotoFromUser;
            fbUser = new FacebookClient(i_Settings.m_lastAccessToken);
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {

            dynamic parameters = new ExpandoObject(); parameters.idobject = "";

           // dynamic result = fbUser.Post("/me/feed", parameters);


            fbUser.Post("/" + m_CurrentPicture.Id + "/likes", fbUser.AccessToken);
            try
            {
                m_CurrentPicture.Like();
            }
            catch (Exception E)
            {
                m_CurrentPicture.Unlike();
            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            //m_CurrentPicture.Comment(textBoxAddAComment.Text);
            fbUser.Get(m_CurrentPicture.URL);

        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            //try
            //{
               // Dictionary<string, object> parameters = new Dictionary<string, object>();
                //parameters.Add("message", textBoxAddAComment.Text);
                //parameters.Add("link", m_CurrentPicture.Link);
                //parameters.Add("picture", "postInfo.ImageUrl");
                dynamic parameters = new ExpandoObject();
                parameters.message = textBoxAddAComment.Text;
                parameters.link = m_CurrentPicture.Link;
                parameters.picture = "postInfo.ImageUrl";
            
            var tags = new[]
            {
               new {x = 0, y = 0, tag_uid = 10154908964634642},
            };
            parameters.story_tags = m_CurrentPicture.Tags;

            fbUser.Post("me/feed", parameters);
            //fbUser.Post("me/feed", parameters);
                
            
           // }
            //catch(Exception ex)
            //{
              //  Console.WriteLine(ex.ToString());
           // }
        }


        private void pictureBoxSelectedPicture_Click(object sender, EventArgs e)
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
    }
}
