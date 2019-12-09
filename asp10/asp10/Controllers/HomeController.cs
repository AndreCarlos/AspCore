using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp10.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/aaa")]
        public string Index()
        {
            return "Estou no Index";
        }

        [Route("home/acao1/{id?}")]
        public string acao1(int id)
        {
            return "Estou na acao1. ID = " + id;
        }

        [Route("home/post")]
        public string acao2()
        {
            return "Estou na acao2 NOVO";
        }

        [Route("home/adicionar/{parcela1?}/{parcela2?}")]
        public string adicionar(int parcela1, int parcela2)
        {
            //return "Estou no adicionar. Meu nome completo é = " + nome + " " + apelido;
            return parcela1 + " + " + parcela2 + " = " + (parcela1 + parcela2).ToString();
        }
    }
}