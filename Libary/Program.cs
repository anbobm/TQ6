
using Libary.Database;
using Microsoft.EntityFrameworkCore;

namespace Libary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            // DbContext registrieren – Pfad zur DB im /Database-Ordner
            builder.Services.AddDbContext<Db_Context>(options =>
                options.UseSqlite(
                    $"Data Source={Path.Combine("Database", "database.db")}"
                ));

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
