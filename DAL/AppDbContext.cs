using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.DAL
{
    public class AppDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
