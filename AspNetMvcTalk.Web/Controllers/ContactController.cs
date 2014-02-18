using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcTalk.Web.Controllers
{
    public class ContactController : ApplicationController
    {
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Create()
        {
            return RedirectToAction("New");
        }
    }
}