using Microsoft.AspNetCore.Mvc;

namespace asp16.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}