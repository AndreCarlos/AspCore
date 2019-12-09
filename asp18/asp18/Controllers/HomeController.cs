using Microsoft.AspNetCore.Mvc;
using asp18.Models;

namespace asp18.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //view de entrada que apresenta um título, a lista de clientes ou a mensagem indicando que não existem clientes
            return View(Dados.todos_os_dados());
        }

        public IActionResult novo_cliente()
        {
            //apresenta o formulario para adicionar novo cliente
            return View();
        }

        [HttpPost]
        public IActionResult novo_cliente(Cliente item)
        {
            //pede ao model que adicione o novo cliente... caso seja possível
            Dados.adicionarCliente(item);

            return RedirectToAction("Index");
        }

        public IActionResult eliminar(int id)
        {

            //pedir ao model que elimine o registro desejado
            Dados.eliminarCliente(id);

            return RedirectToAction("Index");
        }

        public IActionResult editar(int id)
        {
            //apresentar a view de edicao
            return View(Dados.dados_cliente(id));
        }

        [HttpPost]
        public IActionResult editar(Cliente c)
        {
            //alterar os dados do cliente
            Dados.editar_cliente(c);

            return RedirectToAction("index");
        }
    }
}