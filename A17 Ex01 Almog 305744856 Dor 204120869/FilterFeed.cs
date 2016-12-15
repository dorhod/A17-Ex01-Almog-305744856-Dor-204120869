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
using A17_Ex01_Logic;


namespace A17_Ex01_UI
{
    public partial class FilterFeed : UserControl
    {
        FacebookClient fbUser;
        List<FeedPost> m_Posts = new List<FeedPost>();
        List<PhotoPost> m_ControlsWithPost = new List<PhotoPost>();

        public FilterFeed()
        {
            InitializeComponent();
            fbUser = new FacebookClient(AppSettings.GetSettings().m_lastAccessToken);

        }

        protected override void OnLoad(EventArgs e)
        {
            FatchPosts();
            base.OnLoad(e);
        }

        public void FatchPosts()
        {
            JsonObject results = (JsonObject)fbUser.Get("me/feed?fields=message,likes{name},comments{from},story,source,created_time,picture,from&limit=10000");

            JsonArray posts = (JsonArray)results[0];

            foreach (JsonObject post in posts)
            {
                FeedPost newPost = new FeedPost(post, fbUser);
                m_Posts.Add(newPost);
            }
            FatchFeed();
        }

        private void FatchFeed()
        {
            foreach (FeedPost post in m_Posts)
            {
                m_ControlsWithPost.Add(new PhotoPost(post));
            }

            flowLayoutPanel.Controls.AddRange(m_ControlsWithPost.ToArray());
            flowLayoutPanel.CreateControl();
        }

        private void FatchFeedOrderedByLikes()
        {
            //IEnumerable<PhotoPost> orderFeedByLikes = m_ControlsWithPost.OrderByDescending(post => post.m_LikeAmount);

        }

    }
}
