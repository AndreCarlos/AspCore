using System.Collections.Generic;
using System.Linq;

namespace asp19.Models
{
    public static class Dados
    {
        //dados da app
        private static List<Cliente> LISTA_CLIENTES = new List<Cliente>();

        public static List<Cliente> todos_os_clientes()
        {
            //todos os clientes da app
            return LISTA_CLIENTES;
        }

        public static void adicionar_cliente(Cliente clienteTemp)
        {
            //buscar o id disponivel 
            int id = 0;
            if (LISTA_CLIENTES.Count != 0) id = LISTA_CLIENTES.Last<Cliente>().id + 1;

            //guardar os dados do novo cliente
            clienteTemp.id = id;
            LISTA_CLIENTES.Add(clienteTemp);
        }

        public static Cliente dados_cliente(int id)
        {
            //devolve os dados do cliente selecionado
            Cliente clienteTemp = LISTA_CLIENTES.Where(i => i.id == id).FirstOrDefault();

            return clienteTemp;
        }

        public static void editar_cliente(Cliente c)
        {
            //editar os dados do cliente selecionado
            LISTA_CLIENTES.First<Cliente>(i => i.id == c.id).nome = c.nome;
            LISTA_CLIENTES.First<Cliente>(i => i.id == c.id).telefone = c.telefone;
        }

        public static void eliminar_cliente(int id)
        {
            //eliminar o cliente da lista de clientes
            var clienteTEmp = LISTA_CLIENTES.First<Cliente>(i => i.id == id);

            LISTA_CLIENTES.Remove(clienteTEmp);
        }
    }
}
