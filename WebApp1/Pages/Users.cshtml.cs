using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class UsersModel : PageModel
    {
        public List<User> Users { get; set; }
        public void OnGet()
        {
            var db = new Db();
            Users = db.Users.ToList();
        }
    }
}
