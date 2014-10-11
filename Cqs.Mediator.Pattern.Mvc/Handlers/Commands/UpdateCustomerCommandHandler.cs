namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class UpdateCustomerCommandHandler : ICommandHandler<UpdateCustomerCommand>
    {

        public virtual void Handle(UpdateCustomerCommand command)
        {
            //logic here
            command.CustomerId = command.CustomerId + 2000;
        }
    }
}