using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Schedule.API.Models;
using Schedule.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbContext;

        public UserRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUser(int id)
        {
            User user = await _dbContext.Users.Include(x => x.Photos).FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _dbContext.Users.Include(x => x.Photos).ToListAsync();
        }
    }
}
