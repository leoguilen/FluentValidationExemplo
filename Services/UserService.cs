using ServiceExample.Domain;
using System;
using System.Collections.Generic;

namespace ServiceExample.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public void CreateUser(User user)
        {
            user.Id = Guid.NewGuid();
            _users.Add(user);
        }

        public List<User> GetUsers()
        {
            return _users;
        }
    }
}
