using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;

namespace Cqs.Mediator.Pattern.Mvc.ViewModels.Customer
{
    public class UpdateCustomerViewModel : ICommand
    {
        public int CustomerId { get; internal set; }

    }
}