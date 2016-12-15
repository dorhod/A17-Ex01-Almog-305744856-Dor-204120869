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
            FacebookClient fbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);

            Dictionary<string, object> commentDicitonay = new Dictionary<string, object>
            {
                {"id", i_PostID},
                {"message", i_Message}
            };

            try
            {
                fbUser.Post("/comments", commentDicitonay);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void SharePost(String i_Message, String i_PostLink)
        {
            FacebookClient fbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);

            Dictionary<string, object> shareDicitonay = new Dictionary<string, object>
                {
                    {"message", i_Message},
                    {"link", i_PostLink},
                    {"picture", "postInfo.ImageUrl"},
                    {"story_tags", " " }
                };
            try
            {
                fbUser.Post("me/feed", shareDicitonay);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
    }
}
