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
    public partial class ImageReaction : Form
    {
        private Photo m_CurrentPicture;
        private string m_AccessToken;
        FacebookClient fbUser;

        public ImageReaction(Photo i_SelectedPhotoFromUser, string i_AccessToken)
        {
            InitializeComponent();
            m_CurrentPicture = i_SelectedPhotoFromUser;
            m_AccessToken = i_AccessToken;
            fbUser = new FacebookClient(m_AccessToken);
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            m_CurrentPicture.Like();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            //m_CurrentPicture.Comment(textBoxAddAComment.Text);
            fbUser.Get(m_CurrentPicture.URL);

        }

        private void buttonShare_Click(object sender, EventArgs e)
        {            
            try
            {
                //m_CurrentPicture.From.PostPhoto(m_CurrentPicture.URL);
                fbUser.Post(m_CurrentPicture);
            }
            catch(Exception ex)
            {

            }
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
