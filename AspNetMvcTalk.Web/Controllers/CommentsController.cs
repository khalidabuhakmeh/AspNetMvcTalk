using System;
using System.Linq;
using System.Web.Mvc;
using AspNetMvcTalk.Web.Models.Comments;
using AspNetMvcTalk.Web.Models.Indexes;
using AspNetMvcTalk.Web.Models.Objects;
using MvcFlash.Core.Extensions;
using PagedList;
using StructureMap.Query;

namespace AspNetMvcTalk.Web.Controllers
{
    public class CommentsController : ApplicationController
    {
        public ActionResult Index(int? page)
        {
            var pageNumber = Math.Max(1, page ?? 1);
            var model = new IndexModel { Page = pageNumber };

            using (var session = Database.OpenSession())
            {
                model.Comments = session.Query<Comment, Comments_Index>()
                    .OrderByDescending(x => x.CreatedAt)
                    .ToPagedList(model.Page, model.Size);
            }

            return View(model);
        }

        public ActionResult New()
        {
            return View(new NewModel());
        }

        public ActionResult Create(NewModel input)
        {
            if (ModelState.IsValid)
            {
                using (var session = Database.OpenSession())
                {
                    var comment = input.ToComment();
                    session.Store(comment);
                    session.SaveChanges();
                }

                Flash.Success("Hooray!", "your comment will shortly be on the site.");
                return RedirectToAction("Index");
            }

            return View("New", input);
        }
    }
}