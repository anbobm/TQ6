using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BiboApp.Database
{
    public class BiboContext : DbContext
    {
        public DbSet<Buch> Buch { get; set; }
        public DbSet<Nutzer> Nutzer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Database/Database.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buch>().ToTable("Buch");
            modelBuilder.Entity<Nutzer>().ToTable("Nutzer");
        }
    }
}