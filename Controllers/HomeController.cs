using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
        {
            return View();
        }
    public IActionResult Table()
        {
            var studentInfoArray = new[]
                {
                    new StudentInfoModelz {Name ="Ian", StudentId ="0001", StudentAge ="21", Email ="ghostadie69@gmail.com"},
                    new StudentInfoModelz {Name ="Jerome", StudentId ="0002", StudentAge ="18", Email ="chrisnel123@gmail.com"},
                    new StudentInfoModelz {Name ="Liam", StudentId ="0003", StudentAge ="20", Email ="uriels.evangelista@gmail.com"},
                    new StudentInfoModelz {Name ="Mariah", StudentId ="0004", StudentAge ="19", Email ="chiseidelulu19@gmail.com"}
                };
        return View(studentInfoArray);
        }
}
