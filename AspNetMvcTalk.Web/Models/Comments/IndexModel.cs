using System.Collections.Generic;
using AspNetMvcTalk.Web.Models.Objects;
using PagedList;

namespace AspNetMvcTalk.Web.Models.Comments
{
    public class IndexModel
    {
        public IndexModel()
        {
            Size = 5;
            Comments = new StaticPagedList<Comment>(new List<Comment>(), 1, Size, 0);
        }

        public int Size { get; set; }
        public int Page { get; set; }
        public IPagedList<Comment> Comments { get; set; }

        public string IsInverted(int index)
        {
            return index%2 == 0 ? null : "timeline-inverted";
        }
    }
}