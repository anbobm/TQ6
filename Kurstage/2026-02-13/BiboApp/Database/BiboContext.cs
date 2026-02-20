using Microsoft.EntityFrameworkCore;

public class BiboContext : DbContext
{
    public DbSet<Buch> Bücher { get; set; }

    public DbSet<Nutzer> Nutzer { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<Autor> Autoren { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=bibo.db");
}