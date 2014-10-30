namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class LogCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
    {
        private readonly ICommandHandler<TCommand> _decorated;

        public LogCommandHandlerDecorator(ICommandHandler<TCommand> decorated)
        {
            this._decorated = decorated;
        }

        public void Handle(TCommand viewModel)
        {
            //do some logging here...
            _decorated.Handle(viewModel);
        }
    }
}