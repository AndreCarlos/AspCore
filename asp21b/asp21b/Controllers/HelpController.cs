using Microsoft.AspNetCore.Mvc;

namespace asp21b.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Metodo1()
        {
            return "Estou no método 1 do Help Controller";
        }
    }
}