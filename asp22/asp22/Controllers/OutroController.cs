using Microsoft.AspNetCore.Mvc;

namespace asp22.Controllers
{
    public class OutroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string processar()
        {
            return "Estou no processar! (OutroController)";
        }
    }
}