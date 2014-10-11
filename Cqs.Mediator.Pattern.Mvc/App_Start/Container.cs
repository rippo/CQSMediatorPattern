using System;
using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Controllers;
using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;
using Cqs.Mediator.Pattern.Mvc.Handlers.Processors;
using Cqs.Mediator.Pattern.Mvc.Handlers.Repository;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web.Mvc;

namespace Cqs.Mediator.Pattern.Mvc
{
    public class Container
    {
        public static void Setup()
        {
            var container = new SimpleInjector.Container();
            
            container.Register<IUserRepository, UserRepository>();
            container.RegisterManyForOpenGeneric(typeof(ICommandHandler<>), AppDomain.CurrentDomain.GetAssemblies());

            //TODO Multiple processors register for many, or similar???
            container.Register<ICustomerEnhanceProcessor, CustomerEnhanceProcessor>();

            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}