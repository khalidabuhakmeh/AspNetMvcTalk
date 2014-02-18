using System;
using System.Web.Mvc;
using MvcFlash.Core;
using Raven.Client;
using RestfulRouting.Format;

namespace AspNetMvcTalk.Web.Controllers
{
    public abstract class ApplicationController : Controller
    {
        protected virtual IDocumentStore Database { get; set; }
        protected virtual IFlashPusher Flash { get; set; }

        protected ApplicationController()
        {
            // calling structure map to resolve our database, magic!
            Database = DependencyResolver.Current.GetService<IDocumentStore>();
            Flash = DependencyResolver.Current.GetService<IFlashPusher>();
        }

        protected ActionResult RespondTo(Action<FormatCollection> format)
        {
            return new FormatResult(format);
        }
    }
}