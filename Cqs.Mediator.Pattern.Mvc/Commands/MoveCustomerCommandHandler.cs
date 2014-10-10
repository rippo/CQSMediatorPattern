namespace Cqs.Mediator.Pattern.Mvc.Commands
{
    public class MoveCustomerCommandHandler : ICommandHandler<MoveCustomerCommand>
    {

        public virtual void Handle(MoveCustomerCommand command)
        {
            //logic here

            command.CustomerId = 123;
        }
    }
}