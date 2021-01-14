using Schedule.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.API.Repositories.Interfaces
{
    public interface IUserRepository : IEntityRepository<User>
    {
        virtual Task<bool> SaveAll() { return null; }
        Task<List<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}
