using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A17_Ex01_Logic;

namespace A17_Ex01_UI
{
    public partial class FormImageReaction : Form
    {
        private Photo m_CurrentPicture;

        public FormImageReaction(Photo i_SelectedPhotoFromUser)
        {
            InitializeComponent();
            m_CurrentPicture = i_SelectedPhotoFromUser;
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
            PostReaction.CommentOnPost(textBoxAddAComment.Text, m_CurrentPicture.Id);
            this.Close();
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            PostReaction.SharePost(textBoxAddAComment.Text, m_CurrentPicture.Link);
            this.Close();
        }

    }
}
