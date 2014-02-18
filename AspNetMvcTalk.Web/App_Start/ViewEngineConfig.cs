using System.Web.Mvc;
using RestfulRouting;

namespace AspNetMvcTalk.Web.App_Start
{
    public static class ViewEngineConfig
    {
        public static void Setup()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RestfulRoutingRazorViewEngine());
        }
    }
}