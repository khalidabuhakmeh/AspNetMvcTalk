using System;
using System.Web.Mvc;

namespace AspNetMvcTalk.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Show()
        {
            throw new Exception("This was completely planned, I promise!");
        }
	}
}