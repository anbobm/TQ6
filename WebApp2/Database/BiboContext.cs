using Microsoft.EntityFrameworkCore;

namespace WebApp2.Database
{
    public class BiboContext : DbContext
    {
        public DbSet<Buch> Bücher { get; set; } = null!;
        public DbSet<Nutzer> Nutzer { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=db.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buch>()
                .HasOne(b => b.Ausleihender)
                .WithMany(n => n.AusgelieheneBücher)
                .HasForeignKey(b => b.AusleihenderId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
