using System.Web.Mvc;
using AspNetMvcTalk.Web.Models.Contact;

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
                return RedirectToAction("New");
            }

            return View("new", input);

        }
    }
}