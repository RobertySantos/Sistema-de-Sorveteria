using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Soverteria.Dao
{
    using Model;

    class FornecedorDao
    {
        Conexao c = new Conexao();
        public int cadastrarFornecedor(Fornecedor fornecedor)
        {
            String str = "INSERT INTO tbFornecedor(nomeFornecedor, contatoFornecedor, foneFornecedor)" +
               "VALUES ('" + fornecedor.Nome + "','" + fornecedor.Contato + "','" + fornecedor.FoneFornecedor +  "')";

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

        public DataTable preenchergrid()
        {
            string str = "select codFornecedor, nomeFornecedor as 'Nome Completo', contatoFornecedor as 'Contado', foneFornecedor as 'Telefone' from tbFornecedor";

            SqlCommand cmd = new SqlCommand(str, Conexao.conection);
            c.conectar();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            c.desconectar();
            return dt;
        }

        public DataTable preenchergrid(string nome)
        {
            string str = "select * from tbFornecedor " +
                         "where nomeFornecedor like '" + nome + "%'";
           
            SqlCommand cmd = new SqlCommand(str, Conexao.conection);
            c.conectar();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            c.desconectar();
            return dt;
        }
    }
}
