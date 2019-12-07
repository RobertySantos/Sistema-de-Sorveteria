using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Soverteria.Dao
{
    using Model;

    class CategoriaDao
    {
        Conexao c = new Conexao();

        public int cadastrarCategoria(Categoria categoria)
        {

            String str = "INSERT INTO tbCategoria(descCategoria )" +
               "VALUES ('" + categoria.Descricao + "')";

            c.conectar();
            SqlCommand cmd = new SqlCommand(str, Conexao.conection);
            int qtde = cmd.ExecuteNonQuery();

            if (qtde > 0)
            {  
                return qtde;
            }
            else
            {
                return 0;
            }
        }
    }
}
