using System.Web.Mvc;
using System.Web.Routing;

namespace Cqs.Mediator.Pattern.Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "HomePage",
                "",
                new { controller = "Home", action = "Index", id = "" }
            );

            //Home contoller action methods
            routes.MapRoute(
                "Contact",
                "contact",
                new { controller = "Home", action = "Contact" }
            );

            routes.MapRoute(
                "test",
                "test",
                new { controller = "Home", action = "Test" }
            );

            //controller routes, need to define them...
            routes.MapRoute(
                "Login",
                "Login/{action}/{id}",
                new { controller = "Login", action = "Index", id = "" }
            );
            //... if you have other controller, specify the name here


            routes.MapRoute(
                "Sitemap",
                "sitemap.xml",
                new { controller = "Home", action = "SiteMapXml" }
                );

            routes.MapRoute(
                "Content",
                "{*id}",
                new { controller = "Home", action = "Cms", id = "" }
            );

        }
    }
}
