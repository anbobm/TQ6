using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Libary.Database;

namespace Libary.Pages
{
    public class ListBooksModel : PageModel
    {
        private readonly Db_Context _db;
        public List<Buch> Buecher { get; set; } = new();

        public ListBooksModel(Db_Context db)
        {
            _db = db;
        }
        public void OnGet()
        {

            Buecher = _db.Buecher
                .AsNoTracking()
                .ToList();
        }
    }
}
