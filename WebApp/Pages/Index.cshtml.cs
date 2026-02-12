using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    public string Uhrzeit { get; set; }

    public List<Todo> Todos { get; set; }

    public void OnGet(string search)
    {
        Uhrzeit = DateTime.Now.ToString("HH:mm");

        if (!System.IO.File.Exists("todos.json"))
        {
            Todos = new List<Todo>();
        }
        else
        {
            var file = System.IO.File.ReadAllText("todos.json");

            Todos = JsonSerializer.Deserialize<List<Todo>>(file) ?? new List<Todo>();
        }

        if (!String.IsNullOrEmpty(search))
        {
            Todos = Todos.Where(t => t.Titel.Contains(search)).ToList();
        }
    }
}

public class Todo
{
    public string Titel { get; set; }
    public bool Erledigt { get; set; }
}