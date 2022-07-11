using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api2._1
{
    public class AppDbConntext : DbContext
    {
        public DbSet<User> Users { get; set; }
       

        public AppDbConntext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        
    }
}
