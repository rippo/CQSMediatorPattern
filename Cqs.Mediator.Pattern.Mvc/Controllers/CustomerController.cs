using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;

namespace Cqs.Mediator.Pattern.Mvc.Controllers
{


    public class CustomerController : Controller
    {
        private readonly ICommandHandler<MoveCustomerCommand> _move;
        private readonly ICommandHandler<DeleteCustomerCommand> _delete;
        private readonly ICommandHandler<UpdateCustomerCommand> _update;

        public CustomerController(ICommandHandler<MoveCustomerCommand> move,
                                  ICommandHandler<DeleteCustomerCommand> delete,
                                  ICommandHandler<UpdateCustomerCommand> update)
        {
            _move = move;
            _delete = delete;
            _update = update;
        }

        public ActionResult Index()
        {
            var c1 = new MoveCustomerCommand { CustomerId = 456 };
            _move.Handle(c1);
            ViewBag.Message1 = c1.CustomerId;

            var c2 = new UpdateCustomerCommand { CustomerId = 678 };
            _update.Handle(c2);
            ViewBag.Message2 = c2.CustomerId;

            var c3 = new DeleteCustomerCommand { CustomerId = 987 };
            _delete.Handle(c3);
            ViewBag.Message3 = c3.CustomerId;

            return View();
        }
    }
}