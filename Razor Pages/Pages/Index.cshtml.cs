using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Pages.Database;

namespace Razor_Pages.Pages
{
    public class IndexModel : PageModel
   {
       public List<Buch> Bücher { get; set; } = new();
       public void OnGet()
       {
      /*    var db = new BiboContext();
            Bücher = db.Bücher.Where(b => b.Autor!.StartsWith("Lo"))
              .OrderBy(b => b.Titel).ToList();
           var buch = new Buch 
           {
            Autor = "Lord Voldemort",
            Titel = "Harry Potter - Der Gefangene von Askaban",
            IsAusgeliehen = false
           };
          db.Bücher.Add(buch);
          db.SaveChanges();*/
       }
   }
}
