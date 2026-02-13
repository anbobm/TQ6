using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSaba.Database;

namespace RazorSaba.Pages
{
    public class UsersModel : PageModel
    {
        public List<User> Users { get; set; } = new();
        public void OnGet()
        {
            var db = new Db();
            Users = db.Users.ToList();
        }
    }
    }

