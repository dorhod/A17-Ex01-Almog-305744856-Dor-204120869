using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Dynamic;
using System.Runtime.Serialization;
using System.Linq;

namespace A17_Ex01_UI
{
    public partial class UserFeed : Form
    {
        FacebookClient fbUser;
        List<Post> m_posts = new List<Post>();

        public UserFeed(AppSettings i_Settings)
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
            JsonObject results = (JsonObject)fbUser.Get("me/feed?fields=message,message_tags,story_tags,attachments,likes{name},comments{from}&limit=10000");

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

            panel_Posts.CreateControl();
        }





    }
}
