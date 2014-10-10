namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class MoveCustomerCommand
    {
        public string CustomerName { get; set; }

        public int CustomerId { get; internal set; }

    }
}