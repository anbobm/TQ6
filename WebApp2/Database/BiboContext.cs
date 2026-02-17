using Microsoft.EntityFrameworkCore;

namespace WebApp2.Database
{
    public class BiboContext : DbContext
    {
        public DbSet<Buch> Bücher { get; set; } = null!;
        public DbSet<Nutzer> Nutzer { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=db.db");
    }
}
