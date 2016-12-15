using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A17_Ex01_Logic
{
    public static class PostReaction
    {
        public static void CommentOnPost(String i_Message, String i_PostID)
        {
            Dictionary<string, object> commentDicitonay = new Dictionary<string, object>
            {
                {"id", i_PostID},
                {"message", i_Message}
            };

            connectAndPost(commentDicitonay, "/comments");
        }

        public static void SharePost(String i_Message, String i_PostLink)
        {
            Dictionary<string, object> shareDicitonay = new Dictionary<string, object>
                {
                    {"message", i_Message},
                    {"link", i_PostLink},
                    {"picture", "postInfo.ImageUrl"},
                    {"story_tags", " " }
                };

            connectAndPost(shareDicitonay, "me/feed");
        }

        private static void connectAndPost(Dictionary<string, object> i_Parmeters, String i_Request)
        {
            try
            {
                FacebookClient fbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);
                fbUser.Post(i_Request, i_Parmeters);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
    }
}
