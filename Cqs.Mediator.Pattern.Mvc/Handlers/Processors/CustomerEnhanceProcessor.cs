using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Processors
{
    public class CustomerEnhanceProcessor : ICustomerEnhanceProcessor
    {
        private readonly ICommandHandler<MoveCustomerCommand> _move;
        private readonly ICommandHandler<DeleteCustomerCommand> _delete;
        private readonly ICommandHandler<UpdateCustomerCommand> _update;

        public CustomerEnhanceProcessor(ICommandHandler<MoveCustomerCommand> move,
            ICommandHandler<DeleteCustomerCommand> delete,
            ICommandHandler<UpdateCustomerCommand> update)
        {
            _move = move;
            _delete = delete;
            _update = update;
        }

        public void Enhance(MoveCustomerCommand moveCommand, UpdateCustomerCommand updateCommand, DeleteCustomerCommand deleteCommand)
        {
            _move.Handle(moveCommand);
            _update.Handle(updateCommand);
            _delete.Handle(deleteCommand);
        }
    }
}