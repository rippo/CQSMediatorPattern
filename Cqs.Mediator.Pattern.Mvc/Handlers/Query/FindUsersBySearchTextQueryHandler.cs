using System;
using System.Collections.Generic;
using System.Linq;
using Cqs.Mediator.Pattern.Mvc.Models.Users;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Query
{
    public class FindUsersBySearchTextQueryHandler : IQueryHandler<FindUsersBySearchTextQuery, List<User>>
    {
        //private readonly NorthwindUnitOfWork db;

        public FindUsersBySearchTextQueryHandler() //NorthwindUnitOfWork db)
        {
            //this.db = db;
        }

        public List<User> Handle(FindUsersBySearchTextQuery query)
        {
            return (from user in FakeUsers.Data()
                    where user.Name.StartsWith(query.SearchText, StringComparison.OrdinalIgnoreCase)
                    select user)
                .ToList();
        }
    }
}