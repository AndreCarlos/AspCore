using Microsoft.AspNetCore.Mvc;

namespace asp21b.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Metodo()
        {
            return "Estou aqui";
        }

        public string Metodo1()
        {
            return "Estou no método 1 do Home Controller";
        }

        public string Metodo2(int id)
        {
            return "Estou no método 2 do Home Controller e o valor de ID = " + id;
        }

        [Route("Metodo3/{nome}")]  //override do template default
        public string Metodo3(string nome)
        {
            return "Estou no método 3 do Home Controller e o meu nome é " + nome;
        }
    }
}