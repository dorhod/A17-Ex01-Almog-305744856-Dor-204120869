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
        public MessagePost(String i_message, int i_likeAmount)
        {
            InitializeComponent();
            label_message.Text = i_message;
            label_likeAmount.Text = i_likeAmount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
