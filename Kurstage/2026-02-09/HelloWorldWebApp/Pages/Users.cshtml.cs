using Microsoft.AspNetCore.Mvc.RazorPages;

public class UsersModel : PageModel
{
    public List<User> Users { get; set; }

    public void OnGet()
    {
        var db = new Db();
        Users = db.Users.ToList();
    }
}