using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Processors
{
    public interface ICustomerEnhanceProcessor
    {
        void Enhance(MoveCustomerCommand moveCommand, UpdateCustomerCommand updateCommand, DeleteCustomerCommand deleteCommand);
    }
}