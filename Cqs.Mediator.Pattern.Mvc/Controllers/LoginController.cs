using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;
using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICommandHandler<MoveCustomerViewModel> _handler;

        public LoginController(ICommandHandler<MoveCustomerViewModel> handler)
        {
            _handler = handler;
        }

        public ViewResult Index()
        {
            ViewBag.Message = "Login Controller: Index"; 
            return View("../Home/Index");
        }

    }

}