using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Facebook;
using A17_Ex01_Logic;

namespace A17_Ex01_UI
{
    public partial class FilterWall : UserControl
    {
        private readonly FacebookClient r_FbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);
        private List<WallPost> m_Posts = new List<WallPost>();
        private List<Post> m_ControlsWithPost = new List<Post>();

        public FilterWall()
        {
            InitializeComponent();
            FetchPosts();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public void FetchPosts()
        {
            JsonObject results = (JsonObject)r_FbUser.Get("me/feed?fields=message,likes{name},comments{from},story,source,created_time,picture,from&limit=10000");

            JsonArray posts = (JsonArray)results[0];

            foreach (JsonObject post in posts)
            {
                WallPost newPost = new WallPost(post, r_FbUser);
                m_Posts.Add(newPost);
            }

            fetchFeed();
        }


        private void fetchFeed()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (WallPost post in m_Posts.Take(30))
            {
                flowLayoutPanel.Controls.Add(new Post(post));
            }

        }

        private void fatchFeedOrderedByLikes()
        {
            IEnumerable<Post> orderFeedByLikes = m_ControlsWithPost.OrderByDescending(post => post.LikeAmount);
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.AddRange(orderFeedByLikes.ToArray());
        }

        private void comboBoxWallFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxWallFilter.SelectedIndex == 0)
            {
                fetchFeed();
            }
            else
            {
                fatchFeedOrderedByLikes();
            }
        }
    }
}
