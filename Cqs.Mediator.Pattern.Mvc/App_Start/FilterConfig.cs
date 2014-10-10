using System.Web;
using System.Web.Mvc;

namespace Cqs.Mediator.Pattern.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
