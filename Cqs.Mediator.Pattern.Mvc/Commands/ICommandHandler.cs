namespace Cqs.Mediator.Pattern.Mvc.Commands
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }
}