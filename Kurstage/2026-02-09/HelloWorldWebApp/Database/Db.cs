using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class Db : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=database.db");
}