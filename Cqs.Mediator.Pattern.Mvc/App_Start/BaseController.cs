//using System;
//using System.Web.Mvc;
//using System.Web.Routing;
//using System.Web.SessionState;

//namespace Cqs.Mediator.Pattern.Mvc.Controllers
//{
//    public class BlahControllerFactory : IControllerFactory
//    {
//        public IController CreateController(RequestContext requestContext, string controllerName)
//        {
//            if (requestContext == null)
//            {
//                throw new ArgumentNullException("requestContext");
//            }

//            if (String.IsNullOrEmpty(controllerName))
//            {
//                throw new ArgumentException("MissingControllerName");
//            }

//            var controllerType = base. GetControllerType(requestContext, controllerName);

//            // This is where a 404 is normally returned
//            // Replaced with route to catchall controller
//            if (controllerType == null)
//            {
//                // Build the dynamic route variable with all segments
//                var dynamicRoute = "";
//                foreach (var segment in requestContext.RouteData.Values.Values)
//                {
//                    dynamicRoute += segment + "/";
//                }
//                // Remove the last '/'
//                dynamicRoute = dynamicRoute.Substring(0, dynamicRoute.Length - 1);

//                // Route to the Catchall controller
//                controllerName = "Home";
//                controllerType = GetControllerType(requestContext, controllerName);
//                requestContext.RouteData.Values["Controller"] = controllerName;
//                requestContext.RouteData.Values["action"] = "Cms";
//                requestContext.RouteData.Values["dynamicRoute"] = dynamicRoute;
//            }

//            IController controller = GetControllerInstance(requestContext, controllerType);
//            return controller;
//        }

//        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
//        {
//            return SessionStateBehavior.Default;
//        }

//        public void ReleaseController(IController controller)
//        {
//        }
//    }


//}