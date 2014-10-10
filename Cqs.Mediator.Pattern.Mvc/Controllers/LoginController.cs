using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;

namespace Cqs.Mediator.Pattern.Mvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICommandHandler<MoveCustomerCommand> handler;

        public LoginController(ICommandHandler<MoveCustomerCommand> handler)
        {
            this.handler = handler;
        }

        public ViewResult Index()
        {
            ViewBag.Message = "Login Controller: Index"; 
            return View("../Home/Index");
        }

    }

}