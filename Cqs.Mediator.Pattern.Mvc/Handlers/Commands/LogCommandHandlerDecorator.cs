namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class LogCommandHandlerDecorator<TCommand> : ICommandHandler<TCommand>
    {
        private readonly ICommandHandler<TCommand> decorated;

        public LogCommandHandlerDecorator(ICommandHandler<TCommand> decorated)
        {
            this.decorated = decorated;
        }

        public void Handle(TCommand viewModel)
        {
            //do some logging here...
            decorated.Handle(viewModel);
        }
    }

}