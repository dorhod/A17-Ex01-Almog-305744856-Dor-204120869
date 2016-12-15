using Facebook;
using System;

namespace A17_Ex01_Logic
{
    public class WallPost
    {
        public string       Id { get; set; }
        public string       Message { get; set; }
        public string       Time { get; set; }
        public string       Story { get; set; }
        public int          LikeCount { get; set; }
        public string       Sender { get; set; }
        public string       SenderPictureURL { get; set; }
        public string       PictureURL { get; set; }
        public JsonObject   From { get; set; }

        public WallPost(JsonObject i_Post, FacebookClient i_FbUser)
        {
            From = parseJson<JsonObject>("from", i_Post);
            if(From != null)
            {
                Sender = parseJson<string>("name", From);
                String fromId = parseJson<string>("id", From);
                if(fromId != null)
                {
                    FacebookClient fbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);
                    JsonObject result = fbUser.Get(fromId + "/?fields=picture{url}") as JsonObject;
                    result = (result[0] as JsonObject)[0] as JsonObject;
                    SenderPictureURL = parseJson<string>("url", result);
                }
            }
            
            PictureURL = parseJson<string>("picture", i_Post);
            Message = parseJson<string>("message", i_Post);
            Story = parseJson<string>("story", i_Post);
            Time = parseJson<string>("created_time", i_Post);
            Id = parseJson<string>("id", i_Post);

            JsonObject likes = parseJson<JsonObject>("likes", i_Post);
            if (likes != null)
            {
                JsonArray likeArray = likes[0] as JsonArray;
                LikeCount = likeArray.Count;
            }
        }

        private T parseJson<T>(String i_Value, JsonObject i_Json)
        {
            object jsonParse;
            i_Json.TryGetValue(i_Value, out jsonParse);
            
            return (T) jsonParse;
        }
    }
}

