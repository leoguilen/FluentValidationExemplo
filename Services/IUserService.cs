using ServiceExample.Domain;
using System.Collections.Generic;

namespace ServiceExample.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        void CreateUser(User ponto);
    }
}
