namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class DeleteCustomerCommandHandler : ICommandHandler<DeleteCustomerCommand>
    {

        public virtual void Handle(DeleteCustomerCommand command)
        {
            //logic here
            command.CustomerId = command.CustomerId + 3000;
        }
    }
}