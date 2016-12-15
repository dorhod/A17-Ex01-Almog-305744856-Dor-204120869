
using System.Windows.Forms;
using A17_Ex01_Logic;

namespace A17_Ex01_UI
{
    public partial class Post : UserControl
    {
        public int LikeAmount { get; set; }

        public Post(WallPost i_NewPost)
        {
            InitializeComponent();

            label_message.Text = i_NewPost.Message;
            LikeAmount = i_NewPost.LikeCount;
            label_likeAmount.Text = LikeAmount.ToString();
            labelSender.Text = i_NewPost.Sender;
            labelTime.Text = i_NewPost.Time;
            labelStory.Text = i_NewPost.Story;
            pictureBox_PostPic.ImageLocation = i_NewPost.PictureURL;

            pictureBoxSenderPhoto.ImageLocation = i_NewPost.SenderPictureURL;
        }
    }
}
