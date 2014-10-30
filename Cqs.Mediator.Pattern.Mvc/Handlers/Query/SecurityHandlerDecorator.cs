
using Cqs.Mediator.Pattern.Mvc.Models.Security;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Query
{
    public class SecurityHandlerDecorator<TQuery, TResult> : IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        private readonly IQueryHandler<TQuery, TResult> decorated;
        private readonly ISecurity security;

        public SecurityHandlerDecorator(IQueryHandler<TQuery, TResult> decorated, ISecurity security)
        {
            this.decorated = decorated;
            this.security = security;
        }

        public TResult Handle(TQuery query)
        {
            query.Security = security;
            return decorated.Handle(query);
        }
    }

}
