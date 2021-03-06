﻿using System;
using System.Collections.Generic;
using System.Linq;
using Cqs.Mediator.Pattern.Mvc.Models.Users;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Query
{
    public class FindUsersByNameViewModelHandler : IQueryHandler<FindUsersByNameViewModelQuery, List<User>>
    {

        public List<User> Handle(FindUsersByNameViewModelQuery query)
        {
            var custId = query.Security.CurrentUserId;

            return (from user in FakeUsers.Data()
                where user.Name.StartsWith(query.SearchText, StringComparison.OrdinalIgnoreCase)
                      && user.CustomerId == custId 
                    select user)
                .ToList();
        }
    }
}