using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soverteria.Controller
{
    using Model;
    using Dao;

    class UsuarioController
    {
        Conexao c = new Conexao();

        public String cadastrarUsuario(Usuario user) {

            UsuarioDao userDao = new UsuarioDao();
            int u = userDao.cadastrarUsuario(user);

            if (u > 0)
            {
                return ("Cadastro realizado com sucesso," + u + "cadastrado(s)");
            }
            else
            {
                return ("Erro ao cadastrar");
            }
        }
    }
}
