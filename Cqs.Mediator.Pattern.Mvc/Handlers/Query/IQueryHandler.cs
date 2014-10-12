namespace Cqs.Mediator.Pattern.Mvc.Handlers.Query
{
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}