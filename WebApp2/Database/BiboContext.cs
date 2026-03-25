using Microsoft.EntityFrameworkCore;

namespace WebApp2.Database
{
    public class BiboContext : DbContext
    {
        // Für Dependency Injection (Program.cs -> AddDbContext)
        public BiboContext(DbContextOptions<BiboContext> options)
            : base(options)
        {
        }

        // Für alten Code, der noch "new BiboContext()" macht
        public BiboContext()
        {
        }

        public DbSet<Buch> Bücher { get; set; } = null!;
        public DbSet<Nutzer> Nutzer { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // WICHTIG: Nur konfigurieren, wenn noch NICHT via DI konfiguriert wurde
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=db.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Buch -> Nutzer (Ausleiher)
            modelBuilder.Entity<Buch>()
                .HasOne(b => b.Ausleihender)
                .WithMany(n => n.AusgelieheneBücher)
                .HasForeignKey(b => b.AusleihenderId)
                .OnDelete(DeleteBehavior.SetNull);

            // Buch -> Genre
            modelBuilder.Entity<Buch>()
                .HasOne(b => b.Genre)
                .WithMany(g => g.Bücher)
                .HasForeignKey(b => b.GenreId)
                // GenreId ist int (nicht nullable) -> SetNull würde krachen
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}