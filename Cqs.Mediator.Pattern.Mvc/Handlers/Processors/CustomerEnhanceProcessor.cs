using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;
using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Processors
{
    public class CustomerEnhanceProcessor : ICustomerEnhanceProcessor
    {
        private readonly ICommandHandler<MoveCustomerViewModel> move;
        private readonly ICommandHandler<DeleteCustomerViewModel> delete;
        private readonly ICommandHandler<UpdateCustomerViewModel> update;

        public CustomerEnhanceProcessor(ICommandHandler<MoveCustomerViewModel> move,
            ICommandHandler<DeleteCustomerViewModel> delete,
            ICommandHandler<UpdateCustomerViewModel> update)
        {
            this.move = move;
            this.delete = delete;
            this.update = update;
        }

        public void Enhance(MoveCustomerViewModel moveViewModel, UpdateCustomerViewModel updateViewModel, DeleteCustomerViewModel deleteViewModel)
        {
            move.Handle(moveViewModel);
            update.Handle(updateViewModel);
            delete.Handle(deleteViewModel);
        }
    }
}