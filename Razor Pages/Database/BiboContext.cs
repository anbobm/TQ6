using Microsoft.EntityFrameworkCore;

namespace Razor_Pages.Database
{
    public class BiboContext : DbContext

    {

        public DbSet<Buch> Bücher { get; set; }

        public DbSet<Nutzer> Nutzer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=bibo.db");
    }
}
