using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Soverteria.Dao
{
    using Model;

    class UsuarioDao
    {
        Conexao c = new Conexao();

        public int cadastrarUsuario(Usuario user) {

            String str = "INSERT INTO tbUsuario(nomeUsuario, loginUsuario, senhaUsuario) " +
                "VALUES ('"+ user.Nome+"','"+user.Login+"','"+user.Senha+"')";

            c.conectar();
            SqlCommand cmd = new SqlCommand(str, Conexao.conection);
            int qtde = cmd.ExecuteNonQuery();

            if (qtde > 0)
            {
                return qtde;
            }
            else {
                return 0;
            }
        }
    }
}
