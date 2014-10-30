using System.Collections.Generic;
using Cqs.Mediator.Pattern.Mvc.Models.Users;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Query
{
    public class FindUsersByNameViewModelQuery : IQuery<List<User>>
    {
        public string SearchText { get; set; }
    }
}