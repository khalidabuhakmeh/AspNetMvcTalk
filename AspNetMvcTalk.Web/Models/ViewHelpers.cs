using System.Web.Mvc;

namespace AspNetMvcTalk.Web.Models
{
    public static class ViewHelpers
    {
        public static string MemberPictureUrl(this UrlHelper url, string member)
        {
            return url.Content(string.Format("~/content/img/{0}.png", member));
        }
    }
}