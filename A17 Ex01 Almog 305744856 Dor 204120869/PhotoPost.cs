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
        public PhotoPost(String i_message, int i_likeAmount, string url)
        {
            InitializeComponent();

            label_LikesAmount.Text = i_likeAmount.ToString();
            pictureBox_PostPic.ImageLocation = url;
        }
    }
}
