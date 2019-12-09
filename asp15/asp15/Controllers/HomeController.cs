using Microsoft.AspNetCore.Mvc;

namespace asp15.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}