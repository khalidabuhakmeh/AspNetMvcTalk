using System.Linq;
using AspNetMvcTalk.Web.Models.Objects;
using Raven.Client.Indexes;

namespace AspNetMvcTalk.Web.Models.Indexes
{
    public class Comments_Index : AbstractIndexCreationTask<Comment>
    {
        public Comments_Index()
        {
            Map = comments => from c in comments
                              select new
                              {
                                  c.CreatedAt,
                                  c.Favorite,
                              };
        }
    }
}