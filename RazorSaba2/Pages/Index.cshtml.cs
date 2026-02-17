using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSaba2.Database;
using System.Collections.Generic;
using System.Linq;

namespace RazorSaba2.Pages
{
    public class IndexModel : PageModel
    {
        public List<Buch> Bücher { get; set; } = new();

        public void OnGet()
        {
            var db = new DB_Kontext();
            Bücher = db.Bücher.Where(b => b.Autor!.StartsWith("Lo"))
                .OrderBy(b => b.Titel).ToList(); 
            var buch = new Buch { Autor = "Lord Voldemort",
                Titel = "Harry Potter - Der Gefangene von Askaban", 
                IsAusgeliehen = false };
            db.Bücher.Add(buch); 
            db.SaveChanges();
        }
    }
}


 

