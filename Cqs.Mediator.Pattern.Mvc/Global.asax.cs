using System.Web.Mvc;
using System.Web.Routing;

namespace Cqs.Mediator.Pattern.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //ControllerBuilder.Current.SetControllerFactory(new BlahControllerFactory());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Container.Setup();
        }
    }

}
