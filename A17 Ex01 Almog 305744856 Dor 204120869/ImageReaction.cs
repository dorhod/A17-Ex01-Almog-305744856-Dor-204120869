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
        public Photo m_CurrentPicture;


        public ImageReaction(Photo i_SelectedPhotoFromUser)
        {
            InitializeComponent();
            m_CurrentPicture = i_SelectedPhotoFromUser;
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            m_CurrentPicture.Like();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            m_CurrentPicture.Comment(textBoxAddAComment.Text);
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            try
            {
                m_CurrentPicture.From.PostPhoto(m_CurrentPicture.URL);
            }
            catch(Exception ex)
            {

            }
        }

        private void pictureBoxSelectedPicture_Click(object sender, EventArgs e)
        {
            pictureBoxSelectedPicture.LoadAsync(m_CurrentPicture.URL);
        }
    }
}
