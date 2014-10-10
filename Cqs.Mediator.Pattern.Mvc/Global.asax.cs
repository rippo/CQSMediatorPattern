using System;
using System.Web.Mvc;
using System.Web.Routing;
using Cqs.Mediator.Pattern.Mvc.Commands;
using SimpleInjector;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web.Mvc;

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


            var container = new Container();
            container.Register<IUserRepository, UserRepository>();
            container.RegisterManyForOpenGeneric(typeof(ICommandHandler<>), AppDomain.CurrentDomain.GetAssemblies());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

    }



    public interface IUserRepository
    {
        string GetMe();
    }

    public class UserRepository : IUserRepository
    {
        public string GetMe()
        {
            return "Rippo";
        }
    }
}
