using System.Web.Mvc;
using AspNetMvcTalk.Web.Models.Contact;
using MvcFlash.Core.Extensions;

namespace AspNetMvcTalk.Web.Controllers
{
    public class ContactController : ApplicationController
    {
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Create(NewModel input)
        {
            if (ModelState.IsValid)
            {
                Flash.Success("Thank you", "we have received your message and will reploy as soon as we can.");
                return RedirectToAction("New");
            }

            return View("new", input);

        }
    }
}