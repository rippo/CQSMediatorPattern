using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;

namespace Cqs.Mediator.Pattern.Mvc.ViewModels.Customer
{
    public class MoveCustomerViewModel : ICommand
    {
        public string CustomerName { get; set; }

        public int CustomerId { get; internal set; }

    }
}