using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A17_Ex01_UI
{
    public partial class PhotoPost : UserControl
    {
        public PhotoPost(Post i_NewPost)
        {
            InitializeComponent();

            label_message.Text = i_NewPost.message;
            label_likeAmount.Text = i_NewPost.likeCount.ToString();
            labelSender.Text = i_NewPost.sender;
            labelTime.Text = i_NewPost.time;
            labelStory.Text = i_NewPost.story;
            pictureBox_PostPic.ImageLocation = i_NewPost.pictureURL;
            pictureBoxSenderPhoto.ImageLocation = i_NewPost.senderPictureURL;
        }
    }
}
