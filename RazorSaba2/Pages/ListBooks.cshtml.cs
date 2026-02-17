using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSaba2.Database;
using System.Collections.Generic;
using System.Linq;

namespace RazorSaba2.Pages
{
    public class ListBooksModel : PageModel
    {
        public List<Buch> Bücher { get; set; } = new();

        public void OnGet()
        {
            var db = new DB_Kontext();
            Bücher = db.Bücher.ToList();
        }
    }
}







