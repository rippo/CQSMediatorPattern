using System.Collections.Generic;

namespace Cqs.Mediator.Pattern.Mvc.Models.Users
{
    public static class FakeUsers
    {
        public static IEnumerable<User> Data()
        {
            return new List<User>
            {
                new User {Id = 1, Name = "Rippo"},
                new User {Id = 2, Name = "Richard"},
                new User {Id = 3, Name = "Robert"},
                new User {Id = 4, Name = "Paul"},
                new User {Id = 5, Name = "Paula"},
                new User {Id = 6, Name = "Junita"},
                new User {Id = 7, Name = "Emily"},
                new User {Id = 8, Name = "Nico"},
                new User {Id = 9, Name = "Scamp"},
            };
        }
    }
}