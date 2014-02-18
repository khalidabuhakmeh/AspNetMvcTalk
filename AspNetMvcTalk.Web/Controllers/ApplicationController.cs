using System;
using System.Web.Mvc;
using Raven.Client;
using RestfulRouting.Format;

namespace AspNetMvcTalk.Web.Controllers
{
    public abstract class ApplicationController : Controller
    {
        protected virtual IDocumentStore Database { get; set; }

        protected ApplicationController()
        {
            // calling structure map to resolve our database, magic!
            Database = DependencyResolver.Current.GetService<IDocumentStore>();
        }

        protected ActionResult RespondTo(Action<FormatCollection> format)
        {
            return new FormatResult(format);
        }
    }
}