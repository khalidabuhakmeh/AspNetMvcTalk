using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcTalk.Web.Controllers
{
    public class CommentsController : ApplicationController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View("New");
        }
	}
}