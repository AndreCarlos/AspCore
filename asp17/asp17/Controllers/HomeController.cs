using asp17.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace asp17.Controllers
{
    public class HomeController : Controller
    {
        //definição da lista de dados
        List<Cliente> lista_clientes;

        public HomeController()
        {
            //construtor da classe
            lista_clientes = new List<Cliente>()
                {
                new Cliente() { id = 0,  nome = "Andre", apelido = "Carlos" },
                new Cliente() { id = 1,  nome = "Ana", apelido = "Silva" },
                new Cliente() { id = 2, nome = "Carlos", apelido = "Oliveira" }
            };
        }

        public IActionResult Index()
        {
            //List<Cliente> lista_clientes = new List<Cliente>();
            //lista_clientes.Add(new Cliente() { nome = "Andre", apelido = "Carlos"});
            //lista_clientes.Add(new Cliente() { nome = "Ana", apelido = "Silva" });
            //lista_clientes.Add(new Cliente() { nome = "Carlos", apelido = "Oliveira" });

            //Cliente novo_cliente = new Cliente();
            //novo_cliente.nome = "Andre";
            //novo_cliente.apelido = "Carlos";

            return View(lista_clientes);
        }

        public ViewResult detalhes(int id)
        {
            return View(lista_clientes[id]);
        }
    }
}