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
    public partial class MessagePost : UserControl
    {
        public MessagePost(Post i_NewPost)
        {
            InitializeComponent();
            label_message.Text = i_NewPost.message;
            label_likeAmount.Text = i_NewPost.likeCount.ToString();
            labelSender.Text = i_NewPost.sender;
            labelTime.Text = i_NewPost.time;
            labelStory.Text = i_NewPost.story;
            pictureBoxSenderPhoto.ImageLocation = i_NewPost.senderPictureURL;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
