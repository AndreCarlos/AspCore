using Microsoft.AspNetCore.Mvc;

namespace asp20.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}