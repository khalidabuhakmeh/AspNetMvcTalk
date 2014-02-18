using System.Web.Mvc;
using AspNetMvcTalk.Web.App_Start;

namespace AspNetMvcTalk.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ViewEngineConfig.Setup();
            RavenDbConfig.Setup();
            ValidationConfig.Setup();

            // for elmah
            GlobalFilters.Filters.Add(new HandleErrorAttribute());
        }
    }
}
