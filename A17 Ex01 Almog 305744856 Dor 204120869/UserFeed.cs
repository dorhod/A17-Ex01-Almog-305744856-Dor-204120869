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

            fbUser = new FacebookClient(i_Settings.m_lastAccessToken);
        }

        protected override void OnLoad(EventArgs e)
        {
            FatchFeed();
            base.OnLoad(e);
        }

        public void FatchFeed()
        {
            JsonObject results = (JsonObject) fbUser.Get("me/feed?fields=message,message_tags,story_tags,attachments,likes{name},comments{from}&limit=10000");

            JsonArray posts = (JsonArray) results[0];

            foreach (JsonObject post in posts)
            {

                Post newPost = new Post(post);
                m_posts.Add(newPost);
            }

            //FacebookObjectCollection<Post> userFeed = fbUser.NewsFeed;
            IEnumerable<Post> orderFeedByLikes = m_posts.OrderByDescending(post => post.likeCount);
            foreach (Post post in orderFeedByLikes)
            {
                if (post.attachments == null)
                {
                    //panel_Posts.Controls.Add(new MessagePost(post.message, post.likeCount));
                    flowLayoutPanel.Controls.Add(new MessagePost(post.message, post.likeCount));
                }
                else
                {
                    String url = " ";
                    JsonArray temp = (JsonArray) post.attachments[0];
                    foreach(JsonObject obj in temp)
                    {
                        object o_temp;
                        if (obj.TryGetValue("media", out o_temp))
                        {
                            JsonObject media = o_temp as JsonObject;
                            if (media.TryGetValue("image", out o_temp)){

                                JsonObject image = o_temp as JsonObject;

                                if (image.TryGetValue("src", out o_temp))
                                {
                                    url = o_temp as String;
                                }
                            }
                        }
                    }
                    flowLayoutPanel.Controls.Add(new PhotoPost(post.message, post.likeCount, url));
                }
            }

            panel_Posts.CreateControl();
        }

       
        public class Post
        {
            public string id { get; set; }
            public string message { get; set; }
            public string time { get; set; }
            public string story { get; set; }
            public int likeCount { get; set; }
            public JsonObject attachments { get; set; }

            public Post(JsonObject i_post)
            {
                object o_temp;
                if(i_post.TryGetValue("attachments", out o_temp))
                {
                    attachments = o_temp as JsonObject;
                }
                if (i_post.TryGetValue("story_tags", out o_temp))
                {
                    JsonArray likes = o_temp as JsonArray;
                    likeCount = likes.Count;
                }
                if (i_post.TryGetValue("message", out o_temp))
                {
                    message = o_temp as String;
                }
                if(i_post.TryGetValue("story", out o_temp))
                {
                    story = o_temp as String;
                }
                if(i_post.TryGetValue("created_time", out o_temp))
                {
                    time = o_temp as String;
                }
                if(i_post.TryGetValue("id", out o_temp))
                {
                    id = o_temp as String;
                }
                
            }

        }

    }
}
