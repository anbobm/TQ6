using Microsoft.EntityFrameworkCore;

namespace razor.Database
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}


