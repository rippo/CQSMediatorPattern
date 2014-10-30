using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Processors
{
    public interface ICustomerEnhanceProcessor
    {
        void Enhance(MoveCustomerViewModel moveViewModel, UpdateCustomerViewModel updateViewModel, DeleteCustomerViewModel deleteViewModel);
    }
}