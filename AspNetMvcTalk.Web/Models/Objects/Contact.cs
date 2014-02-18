using System;

namespace AspNetMvcTalk.Web.Models.Objects
{
    public class Contact
    {
        public Contact()
        {
            CreatedAt = DateTimeOffset.Now;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}