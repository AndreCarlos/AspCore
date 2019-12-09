using Microsoft.AspNetCore.Mvc;

namespace asp22.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("formulario");
        }

        public string processar()
        {
            return "Estou no processar!";
        }

        public string processar2()
        {
            return "Estou no processar2!";
        }

        [Route("home/processar_final", Name ="teste")]
        public string processar_final()
        {
            return "Estou no processar FINAL!";
        }
    }
}