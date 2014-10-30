namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand viewModel);
    }
}