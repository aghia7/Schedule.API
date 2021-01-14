using Microsoft.EntityFrameworkCore;
using Schedule;
using Schedule.API;
using Schedule.API.Models;
using Schedule.API.Repositories;

namespace Schedule.API.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}