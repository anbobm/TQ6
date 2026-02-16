using Microsoft.EntityFrameworkCore;

namespace HelloWorldWebApp.Database
{
    public class Db : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
            => optionsBuilder.UseSqlite("Data Source=database.db");
        
    }
}
