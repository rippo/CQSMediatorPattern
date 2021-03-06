﻿using System;
using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;
using Cqs.Mediator.Pattern.Mvc.Handlers.Processors;
using Cqs.Mediator.Pattern.Mvc.Handlers.Query;
using Cqs.Mediator.Pattern.Mvc.Handlers.Repository;
using Cqs.Mediator.Pattern.Mvc.Models.Security;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web.Mvc;

namespace Cqs.Mediator.Pattern.Mvc
{
    public static class ContainerConfig
    {
        public static readonly SimpleInjector.Container Container = new SimpleInjector.Container();

        public static void Init()
        {

            //Container.Register<IMediator, Mediator>();

            Container.RegisterManyForOpenGeneric(typeof(ICommandHandler<>), AppDomain.CurrentDomain.GetAssemblies());
            Container.RegisterManyForOpenGeneric(typeof(IQueryHandler<,>), typeof(IQueryHandler<,>).Assembly);

            Container.Register<IQueryProcessor, QueryProcessor>();

            //Decorate each returned ICommandHandler<T> object with a LogCommandHandlerDecorator<T>. 
            Container.RegisterDecorator(typeof(ICommandHandler<>), typeof(LogCommandHandlerDecorator<>));
            Container.RegisterDecorator(typeof(IQueryHandler<,>), typeof(SecurityHandlerDecorator<,>));

            //TODO register for many, or similar???
            Container.Register<ICustomerEnhanceProcessor, CustomerEnhanceProcessor>();
            Container.Register<IUserRepository, UserRepository>();
            Container.Register<ISecurity, Security>();

            Container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(Container));
        }
    }

}