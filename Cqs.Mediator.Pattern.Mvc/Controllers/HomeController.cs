using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Commands;

namespace Cqs.Mediator.Pattern.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository repo;
        private readonly ICommandHandler<MoveCustomerCommand> handler;

        public HomeController(IUserRepository repo, ICommandHandler<MoveCustomerCommand> handler)
        {
            this.repo = repo;
            this.handler = handler;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Home Controller: Index"; 
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Home Controller: Contact"; 
            return View("Index");
        }

        public ContentResult Test()
        {
            var command = new MoveCustomerCommand
            {
                CustomerName = "My Customer"
            };

            handler.Handle(command);

            return Content("done, new Id: " + command.CustomerId);
        }

        public ActionResult Cms(string id)
        {
            ViewBag.Message = "Home Controller: Cms : " + id;
            return View("Index");
        }


    }
}