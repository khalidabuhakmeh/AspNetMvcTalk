using System.Web.Routing;
using AspNetMvcTalk.Web.App_Start;
using AspNetMvcTalk.Web.Controllers;
using RestfulRouting;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Routes), "Start")]

namespace AspNetMvcTalk.Web.App_Start
{
    public class Routes : RouteSet
    {
        public override void Map(IMapper map)
        {
            map.DebugRoute("routedebug");
            map.Root<CommentsController>(c => c.Index());
            map.Resources<CommentsController>(c => c.Only("index", "new", "create"));
            map.Resource<ContactController>(c => c.Only("new", "create"));

            /*
             * Note: You can register and next resources
             * 
            map.Root<HomeController>(x => x.Index());
            
            map.Resources<BlogsController>(blogs =>
            {
                blogs.As("weblogs");
                blogs.Only("index", "show");
                blogs.Collection(x => x.Get("latest"));

                blogs.Resources<PostsController>(posts =>
                {
                    posts.Except("create", "update", "destroy");
                    posts.Resources<CommentsController>(c => c.Except("destroy"));
                });
            });

            map.Area<Controllers.Admin.BlogsController>("admin", admin =>
            {
                admin.Resources<Controllers.Admin.BlogsController>();
                admin.Resources<Controllers.Admin.PostsController>();
            });
             */
        }

        public static void Start()
        {
            var routes = RouteTable.Routes;
            routes.MapRoutes<Routes>();
        }
    }
}