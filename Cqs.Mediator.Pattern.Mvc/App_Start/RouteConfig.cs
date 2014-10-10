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
                "Test",
                "test",
                new { controller = "Home", action = "Test" }
            );

            routes.MapRoute(
                "SiteMap",
                "sitemap",
                new { controller = "Home", action = "SiteMap" }
            );


            routes.MapRoute(
                "Login",
                "Login/{action}/{id}",
                new { controller = "Login", action = "Index", id = "" }
            );
            //... if you have other controller, specify the name here

            routes.MapRoute(
                "Content",
                "{*id}",
                new { controller = "Home", action = "Cms", id = "" }
            );

        }
    }
}
