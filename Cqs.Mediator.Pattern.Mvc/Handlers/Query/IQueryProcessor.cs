namespace Cqs.Mediator.Pattern.Mvc.Handlers.Query
{
    public interface IQueryProcessor
    {
        TResult Process<TResult>(IQuery<TResult> query);
    }
}