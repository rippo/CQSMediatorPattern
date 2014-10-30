using System.Collections.Generic;

namespace Cqs.Mediator.Pattern.Mvc.Models.Users
{
    public static class FakeUsers
    {
        public static IEnumerable<User> Data()
        {
            return new List<User>
            {
                new User {Id = 1, Name = "Rippo", CustomerId = 999},
                new User {Id = 2, Name = "Richard", CustomerId = 999},
                new User {Id = 3, Name = "Robert", CustomerId = 998},
                new User {Id = 4, Name = "Paul", CustomerId = 999},
                new User {Id = 5, Name = "Paula", CustomerId = 999},
                new User {Id = 6, Name = "Junita", CustomerId = 999},
                new User {Id = 7, Name = "Emily", CustomerId = 999},
                new User {Id = 8, Name = "Nico", CustomerId = 999},
                new User {Id = 9, Name = "Scamp", CustomerId = 999},
            };
        }
    }
}