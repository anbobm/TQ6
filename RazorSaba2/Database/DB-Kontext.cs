using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RazorSaba2.Database
{
    public class DB_Kontext: DbContext
    {

        public DbSet<Buch> Bücher { get; set; }

        public DbSet<Nutzer> Nutzer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Db2.db");
    }
}



