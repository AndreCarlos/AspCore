using Microsoft.AspNetCore.Mvc;

namespace asp16.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}