using System.Collections.Generic;
using System.Linq;

namespace asp18.Models
{
    public static class Dados
    {
        private static List<Cliente> LISTA_CLIENTES = new List<Cliente>();

        public static IEnumerable<Cliente> todos_os_dados()
        {
            return LISTA_CLIENTES;
        }

        public static void adicionarCliente(Cliente item)
        {
            //atribuir o id ao item
            item.id = 0;

            if (LISTA_CLIENTES.Count != 0)
            {
                item.id = LISTA_CLIENTES.Last<Cliente>().id + 1;
            }

            LISTA_CLIENTES.Add(item);
        }

        public static void eliminarCliente(int id)
        {
            var item = LISTA_CLIENTES.First<Cliente>(i => i.id == id);
            LISTA_CLIENTES.Remove(item);
        }

        public static Cliente dados_cliente(int id)
        {
            var cliente = LISTA_CLIENTES.Where(i => i.id == id).FirstOrDefault();

            return cliente;
        }

        public static void editar_cliente(Cliente c)
        {
            LISTA_CLIENTES.Where(i => i.id == c.id).First().nome = c.nome;
            LISTA_CLIENTES.Where(i => i.id == c.id).First().telefone = c.telefone;
        }
    }
}
