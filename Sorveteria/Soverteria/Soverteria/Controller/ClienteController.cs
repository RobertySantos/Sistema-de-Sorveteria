using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Soverteria.Controller
{
    using Model;
    using Dao;

    class ClienteController
    {
        ClienteDao cli = new ClienteDao();
        public Boolean cadastrar(Cliente cliente)
        {

            cli.cadastrarCliente(cliente);

            return true;

        }
        public Boolean editar(Cliente cliente) {
            cli.editarUsuario(cliente);
            return true;
        }
        public DataTable listarClientes()
        {
            return cli.dadosUsuario();
        }
        public DataTable listarClientesPesquisa(String nome)
        {
            return cli.dadosUsuario(nome);
        }

       /* public string cadastrarCliente(Cliente cliente) {

            ClienteDao cdao = new ClienteDao(); 
            int fones = cdao.cadastrarCliente(cliente);
            if (fones > 0)
            {
                return ("Cadastro realizado com sucesso," + fones + "cadastrado(s)");
            }
            else {
                return ("Erro ao cadastrar");
            }
        }*/
    }
}
