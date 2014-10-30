using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;
using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Processors
{
    public class CustomerEnhanceProcessor : ICustomerEnhanceProcessor
    {
        private readonly ICommandHandler<MoveCustomerViewModel> _move;
        private readonly ICommandHandler<DeleteCustomerViewModel> _delete;
        private readonly ICommandHandler<UpdateCustomerViewModel> _update;

        public CustomerEnhanceProcessor(ICommandHandler<MoveCustomerViewModel> move,
            ICommandHandler<DeleteCustomerViewModel> delete,
            ICommandHandler<UpdateCustomerViewModel> update)
        {
            _move = move;
            _delete = delete;
            _update = update;
        }

        public void Enhance(MoveCustomerViewModel moveViewModel, UpdateCustomerViewModel updateViewModel, DeleteCustomerViewModel deleteViewModel)
        {
            _move.Handle(moveViewModel);
            _update.Handle(updateViewModel);
            _delete.Handle(deleteViewModel);
        }
    }
}