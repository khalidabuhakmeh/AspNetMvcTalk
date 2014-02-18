using AspNetMvcTalk.Web.App_Start;

namespace AspNetMvcTalk.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ViewEngineConfig.Setup();
            RavenDbConfig.Setup();
        }
    }
}
