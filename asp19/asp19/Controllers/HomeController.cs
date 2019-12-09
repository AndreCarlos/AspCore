using asp19.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp19.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //apresenta o menu inicial
            return View();
        }

        public IActionResult lista_clientes()
        {
            //apresenta a lista de clientes da app
            return View(Dados.todos_os_clientes());
        }

        public IActionResult adicionar_clientes()
        {
            //adicionar um novo cliente
            return View();
        }

        [HttpPost]
        public IActionResult adicionar_cliente(Cliente cliente)
        {
            //guardar os dados do novo cliente
            Dados.adicionar_cliente(cliente);

            return RedirectToAction("adicionar_clientes");
        }

        public IActionResult editar_cliente(int id)
        {
            //editar os dados do cliente selecionado
            return View(Dados.dados_cliente(id));
        }

        [HttpPost]
        public IActionResult editar_cliente(Cliente c)
        {
            Dados.editar_cliente(c);

            return RedirectToAction("lista_clientes");
        }

        public IActionResult eliminar_cliente(int id)
        {
            //eliminar o cliente selecionado
            Dados.eliminar_cliente(id);

            return RedirectToAction("lista_clientes");
        }
    }
}