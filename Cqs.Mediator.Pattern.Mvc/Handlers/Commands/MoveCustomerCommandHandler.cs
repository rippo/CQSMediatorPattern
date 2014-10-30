using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class MoveCustomerCommandHandler : ICommandHandler<MoveCustomerViewModel>
    {

        public virtual void Handle(MoveCustomerViewModel viewModel)
        {
            //logic here
            viewModel.CustomerId = viewModel.CustomerId + 1000;
        }
    }
}