using Microsoft.AspNetCore.Mvc;

namespace asp7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["valor"] = 100;

            return View();
        }
    }
}