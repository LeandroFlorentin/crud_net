using Microsoft.EntityFrameworkCore;
using web_api_users.Models;

namespace web_api_users.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
