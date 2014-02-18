using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcTalk.Web.Models.Objects;

namespace AspNetMvcTalk.Web.Models.Comments
{
    public class IndexModel
    {
        public IndexModel()
        {
            Comments = new List<Comment>();
            Size = 5;
        }

        public int Size { get; set; }
        public int Page { get; set; }
        public IList<Comment> Comments { get; set; }

        public string IsInverted(int index)
        {
            return index%2 == 0 ? null : "timeline-inverted";
        }
    }
}