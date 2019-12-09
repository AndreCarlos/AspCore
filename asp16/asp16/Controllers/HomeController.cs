using Microsoft.AspNetCore.Mvc;

namespace asp16.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}