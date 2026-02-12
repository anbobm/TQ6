using Microsoft.AspNetCore.Mvc.RazorPages;

public class UsersModel : PageModel
{
    private Database _db;

    public List<User> Users { get; set; }

    public UsersModel(Database db)
    {
        _db = db;
    }

    public void OnGet()
    {
        Users = _db.Users.ToList();
    }
}