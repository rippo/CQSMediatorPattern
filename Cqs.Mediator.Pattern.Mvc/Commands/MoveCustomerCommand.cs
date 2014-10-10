namespace Cqs.Mediator.Pattern.Mvc.Commands
{
    public class MoveCustomerCommand
    {
        public string CustomerName { get; set; }

        public int CustomerId { get; internal set; }

    }
}