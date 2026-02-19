using Microsoft.EntityFrameworkCore;

namespace BiboApp.Database
{
    public class BiboContext : DbContext
    {
        public DbSet<Buch> Buecher { get; set; }
        public DbSet<Nutzer> Nutzer { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Database/Database.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buch>().ToTable("Buch");
            modelBuilder.Entity<Nutzer>().ToTable("Nutzer");
            modelBuilder.Entity<Genre>().ToTable("Genre");

            // Beziehung Buch -> Genre
            modelBuilder.Entity<Buch>()
                .HasOne(b => b.GenreNavigation)
                .WithMany(g => g.Buecher)
                .HasForeignKey(b => b.Genre);

            // Beziehung Buch -> Nutzer (Ausleihender)
            modelBuilder.Entity<Buch>()
                .HasOne(b => b.Ausleihender)
                .WithMany(n => n.AusgelieheneBücher)
                .HasForeignKey(b => b.AusleihenderId);
        }
    }
}