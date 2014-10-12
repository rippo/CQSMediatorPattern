using System.Diagnostics;
using SimpleInjector;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Query
{
    public sealed class QueryProcessor : IQueryProcessor
    {
        private readonly Container _container;

        public QueryProcessor(Container container)
        {
            _container = container;
        }

        [DebuggerStepThrough]
        public TResult Process<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof (IQueryHandler<,>).MakeGenericType(query.GetType(), typeof (TResult));

            dynamic handler = _container.GetInstance(handlerType);

            return handler.Handle((dynamic) query);
        }
    }
}