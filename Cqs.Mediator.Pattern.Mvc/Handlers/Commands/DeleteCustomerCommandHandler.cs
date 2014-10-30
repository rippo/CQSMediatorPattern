using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class DeleteCustomerCommandHandler : ICommandHandler<DeleteCustomerViewModel>
    {

        public virtual void Handle(DeleteCustomerViewModel viewModel)
        {
            //logic here
            viewModel.CustomerId = viewModel.CustomerId + 3000;
        }
    }
}