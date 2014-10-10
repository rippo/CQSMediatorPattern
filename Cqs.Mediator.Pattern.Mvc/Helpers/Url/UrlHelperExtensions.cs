using System.Web.Mvc;

namespace Cqs.Mediator.Pattern.Mvc.Helpers.Url
{
    public static class UrlHelperExtensions
    {
        public static string QualifiedAction(this UrlHelper url, string actionName, string controllerName, object routeValues = null)
        {
            if (url.RequestContext.HttpContext.Request.Url != null)
                return url.Action(actionName, controllerName, routeValues, url.RequestContext.HttpContext.Request.Url.Scheme);

            return url.Action(actionName, controllerName, routeValues);
        }
    }
}