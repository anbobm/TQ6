using Microsoft.EntityFrameworkCore;

namespace Libary.Database
{
    public class Db_Context : DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> options)
            : base(options)
        {
        }

        public DbSet<Buch> Buecher { get; set; }
        public DbSet<Nutzer> Nutzer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buch>().ToTable("Buch");
            modelBuilder.Entity<Nutzer>().ToTable("Nutzer");
        }
    }
}
