using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace A17_Ex01_UI
{
    public partial class FilterFeed : UserControl
    {
        FacebookClient fbUser;
        List<Post> m_posts = new List<Post>();

        public FilterFeed()
        {
            InitializeComponent();
            fbUser = new FacebookClient(AppSettings.GetSettings().m_lastAccessToken);

        }

        protected override void OnLoad(EventArgs e)
        {
            FatchFeed();
            base.OnLoad(e);
        }

        public void FatchFeed()
        {
            JsonObject results = (JsonObject)fbUser.Get("me/feed?fields=message,likes{name},comments{from},story,source,created_time,picture,from&limit=10000");

            JsonArray posts = (JsonArray)results[0];

            foreach (JsonObject post in posts)
            {

                Post newPost = new Post(post, fbUser);
                m_posts.Add(newPost);
            }

            IEnumerable<Post> orderFeedByLikes = m_posts.OrderByDescending(post => post.likeCount);
            foreach (Post post in orderFeedByLikes)
            {
                if (post.pictureURL == null)
                {
                    flowLayoutPanel.Controls.Add(new MessagePost(post));
                }
                else
                {
                    flowLayoutPanel.Controls.Add(new PhotoPost(post));
                }
            }
        }

    }
}
