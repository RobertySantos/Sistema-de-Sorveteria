using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Soverteria.Model
{
      class Conexao
    {
         //public static SqlConnection con = new SqlConnection(@"Server=(local); Database=bdLoja; Integrated Security=SSPI;");
          public static SqlConnection conection = new SqlConnection(@"Server=(local); Database=bdLoja; Integrated Security=SSPI;");

         public String conectar()
         {
             try
             {
                 conection.Open();
                 return ("Conexão realizada com sucesso");
             }
             catch (SqlException e)
             {
                 return (e.ToString());
             }
         }

         public String desconectar()
         {

             try
             {
                 conection.Close();
                 return ("Conexão encerrada");
             }
             catch (SqlException e)
             {
                 return (e.ToString());
             }
         }

    }
}
