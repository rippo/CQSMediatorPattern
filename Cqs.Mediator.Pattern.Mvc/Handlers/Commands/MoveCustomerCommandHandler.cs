namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class MoveCustomerCommandHandler : ICommandHandler<MoveCustomerCommand>
    {

        public virtual void Handle(MoveCustomerCommand command)
        {
            //logic here
            command.CustomerId = command.CustomerId + 1000;
        }
    }
}