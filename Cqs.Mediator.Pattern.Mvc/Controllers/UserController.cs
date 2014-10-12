using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Handlers.Query;

namespace Cqs.Mediator.Pattern.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IQueryProcessor _queryProcessor;

        public UserController(IQueryProcessor queryProcessor)
        {
            _queryProcessor = queryProcessor;
        }

        public ViewResult Index()
        {
            ViewBag.Message = "User Controller: Index";

            var query = new FindUsersBySearchTextQuery
            {
                SearchText = "r"
            };

            var users = _queryProcessor.Process(query);

            return View("Index", users);
        }

    }

}