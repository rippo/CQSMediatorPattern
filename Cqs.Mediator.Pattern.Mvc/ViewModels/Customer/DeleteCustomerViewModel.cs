using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;

namespace Cqs.Mediator.Pattern.Mvc.ViewModels.Customer
{
    public class DeleteCustomerViewModel : ICommand
    {
        public int CustomerId { get; internal set; }

    }
}