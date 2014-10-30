
using Cqs.Mediator.Pattern.Mvc.Models.Security;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Query
{
    public interface IQuery<TResult>
    {
        ISecurity Security { get; set; }
    }
}