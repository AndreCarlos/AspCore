using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp11.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("menu_inicial");
        }

        [HttpGet("home/novo_cliente")]
        public ViewResult novo_cliente_frm()
        {
            return View();
        }

        [HttpPost("home/novo_cliente")]
        public string novo_cliente_gravar()
        {
            //todo mecanismo de gravação dos dados no banco de dados
            return "Novo cliente gravado com sucesso";
        }
    }
}