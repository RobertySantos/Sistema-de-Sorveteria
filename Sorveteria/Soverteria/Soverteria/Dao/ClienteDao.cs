using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Soverteria
{
    using Model;

    class ClienteDao
    {
        Conexao con = new Conexao();
        public void cadastrarCliente(Cliente cliente)
        {
            String str = "Insert INTO tbCliente(nomeCliente, cpfCliente, rgCliente, logradouroCliente," +
            "numCliente,compCliente, bairroCliente, cepCliente, cidadeCliente, ufCliente) VALUES" +
            "('" + cliente.Nome + "'," + cliente.Cpf + ",'" + cliente.Rg + "','" + cliente.Rua + "'," + cliente.Numero + ",'" +
            cliente.Complemento + "','" + cliente.Bairro + "'," + cliente.Cep + ",'" + cliente.Cidade + "','" + cliente.Uf + "')";
            SqlCommand cmd = new SqlCommand(str, Conexao.conection);
            con.conectar();
            int qtd = cmd.ExecuteNonQuery();


            con.desconectar();

        }
        public DataTable dadosUsuario()
        {
            String str = "select codCliente , nomeCliente as 'Nome Cliente', cpfCliente as 'CPF', rgCliente as 'RG', logradouroCliente as  'Rua',"
            + "numCliente as 'Número Casa', compCliente as 'Complemento', cidadeCliente as 'Cidade',cepCliente as 'Cep', bairroCliente as 'Bairro' from tbCliente";
            SqlCommand cmd = new SqlCommand(str, Conexao.conection);
            con.conectar();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.desconectar();
            return dt;
        }
        public DataTable dadosUsuario(String nome)
        {
            String str = "select codCliente , nomeCliente as 'Nome Cliente', cpfCliente as 'CPF', rgCliente as 'RG', logradouroCliente as  'Rua',"
            + "numCliente as 'Número Casa', compCliente as 'Complemento',cidadeCliente as 'Cidade', cepCliente as 'Cep', bairroCliente as 'Bairro' from tbCliente where"
            + " nomeCliente like '" + nome + "%' ";
            SqlCommand cmd = new SqlCommand(str, Conexao.conection);
            con.conectar();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.desconectar();
            return dt;
        }

        public void editarUsuario(Cliente cliente)
        {
            String str = "UPDATE tbCliente SET nomeCliente = '"+cliente.Nome+"',cpfCliente = '"+cliente.Cpf+"',"
            +"rgCliente = '"+cliente.Rg+"',logradouroCliente='"+cliente.Rua+"',numCliente='"+cliente.Numero+"',compCliente='"+cliente.Complemento+"',cidadeCliente='"+cliente.Cidade+"',"
            +"cepCliente='"+cliente.Cep+"',bairroCliente='"+cliente.Bairro+"' from tbCliente where codCliente = "+cliente.Id+" ";

            SqlCommand cmd = new SqlCommand(str, Conexao.conection);
            con.conectar();
            cmd.ExecuteNonQuery();

            con.desconectar();
        }
    }
}
