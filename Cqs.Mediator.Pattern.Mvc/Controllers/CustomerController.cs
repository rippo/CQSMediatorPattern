using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Handlers.Processors;
using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Controllers
{
    public class CustomerController : Controller
    {

        //Shows how we can aggrefate multiple commands into a processor
        private readonly ICustomerEnhanceProcessor _enhanceProcessor;

        public CustomerController(ICustomerEnhanceProcessor enhanceProcessor)
        {
            _enhanceProcessor = enhanceProcessor;
        }

        public ActionResult Index()
        {
            var c1 = new MoveCustomerViewModel { CustomerId = 456, CustomerName = "Test"};
            var c2 = new UpdateCustomerViewModel { CustomerId = 678 };
            var c3 = new DeleteCustomerViewModel { CustomerId = 987 };

            _enhanceProcessor.Enhance(c1, c2, c3);

            ViewBag.Message1 = c1.CustomerId;
            ViewBag.Message2 = c2.CustomerId;
            ViewBag.Message3 = c3.CustomerId;

            ViewBag.CurrentUserId = c2.CustomerId;

            return View();
        }
    }
}