using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17_Ex01_UI
{
    public class Post
    {
        public string id { get; set; }
        public string message { get; set; }
        public string time { get; set; }
        public string story { get; set; }
        public int likeCount { get; set; }
        public string sender { get; set; }
        public string senderPictureURL { get; set; }
        public string pictureURL { get; set; }
        public JsonObject from { get; set; }

        public Post(JsonObject i_post, FacebookClient fbUser)
        {
            object o_temp;
            if(i_post.TryGetValue("from", out o_temp))
            {
                from = o_temp as JsonObject;
                if(from.TryGetValue("name", out o_temp))
                {
                    sender = o_temp as String;
                }
                if(from.TryGetValue("id", out o_temp))
                {
                    String id = o_temp as String;
                    FacebookClient fbUser2 = new FacebookClient(AppSettings.GetSettings().m_lastAccessToken);
                    JsonObject result = fbUser2.Get(id + "/?fields=picture{url}") as JsonObject;
                    result = result[0] as JsonObject;
                    result = result[0] as JsonObject;

                    if (result.TryGetValue("url", out o_temp))
                    {
                        senderPictureURL = o_temp as String;
                    }
                }
            }
            if (i_post.TryGetValue("picture", out o_temp))
            {
                pictureURL = o_temp as String;
            }
            if (i_post.TryGetValue("likes", out o_temp))
            {
                JsonObject likes = o_temp as JsonObject;
                JsonArray likeArray = likes[0] as JsonArray;
                likeCount = likeArray.Count;
            }
            if (i_post.TryGetValue("message", out o_temp))
            {
                message = o_temp as String;
            }
            if (i_post.TryGetValue("story", out o_temp))
            {
                story = o_temp as String;
            }
            if (i_post.TryGetValue("created_time", out o_temp))
            {
                time = o_temp as String;
            }
            if (i_post.TryGetValue("id", out o_temp))
            {
                id = o_temp as String;
            }

        }

    }
}

