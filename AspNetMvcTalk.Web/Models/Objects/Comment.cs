using System;

namespace AspNetMvcTalk.Web.Models.Objects
{
    public class Comment
    {
        public Comment()
        {
            CreatedAt = DateTimeOffset.Now;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Favorite { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}