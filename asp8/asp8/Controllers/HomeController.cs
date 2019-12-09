using asp8.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace asp8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //criar um homen

            Humano homen = new Humano() {
                nome = "Andre",
                apelido = "Carlos"
            };

            //criar um carro
            Automovel carro = new Automovel() {
                marca = "Audi",
                cor = "Metalico"
            };

            //coloca os dois viewmodels dentro do mesmo pacote
            Bag data = new Bag()
            {
                humano = homen,
                automovel = carro
            };

            return View(data);
        }
    }
}