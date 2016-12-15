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
        private readonly FacebookClient     r_FbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);
        private List<WallPost>              m_Posts;
        private int                         m_PostsAmountToDisplay;

        public FilterWall()
        {
            InitializeComponent();
            m_PostsAmountToDisplay = 10;
            fetchPosts();          
        }

        private void fetchPosts()
        {
            try
            {
                m_Posts = new List<WallPost>();

                JsonObject results = (JsonObject)r_FbUser.Get("me/feed?fields=message,likes{name},comments{from},story,source,created_time,picture,from&limit=10000");
                JsonArray posts = (JsonArray)results[0];

                foreach (JsonObject post in posts)
                {
                    WallPost newPost = new WallPost(post, r_FbUser);
                    m_Posts.Add(newPost);
                }

                loadFeed();
            }
            finally
            {

            }
        }

        private void setFeed(List<WallPost> i_PhotosToDisplay)
        {
            flowLayoutPanel.Controls.Clear();
            foreach (WallPost post in i_PhotosToDisplay.Take(m_PostsAmountToDisplay))
            {
                flowLayoutPanel.Controls.Add(new Post(post));
            }
        }

        private void fatchFeedOrderedByLikes()
        {
            IEnumerable<WallPost> orderFeedByLikes = m_Posts.OrderByDescending(post => post.LikeCount);
            setFeed(orderFeedByLikes.ToList());
        }

        private void comboBoxWallFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFeed();
        }

        private void comboBoxNumberToDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_PostsAmountToDisplay = comboBoxNumberToDisplay.SelectedItem.ToString() == "All" ? m_Posts.Count : int.Parse(comboBoxNumberToDisplay.SelectedItem.ToString());
            loadFeed();
        }

        private void loadFeed()
        {
            if (comboBoxWallFilter.SelectedIndex == 1)
            {
                fatchFeedOrderedByLikes();
            }
            else
            {
                setFeed(m_Posts);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }
    }
}
