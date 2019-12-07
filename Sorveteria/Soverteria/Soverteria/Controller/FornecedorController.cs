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

    class FornecedorController
    {
        FornecedorDao fdao = new FornecedorDao();

        public string cadastrarFornecedor(Fornecedor fornecedor)
        {
 
            int f = fdao.cadastrarFornecedor(fornecedor);
            if (f > 0)
            {
                return ("Cadastro realizado com sucesso," + f + "cadastrado(s)");
            }
            else
            {
                return ("Erro ao cadastrar");
            }
        }

        public DataTable listarFornecedores()
        {
            return fdao.preenchergrid();
        }

        public DataTable listarFornecedoresPesquisa(string nome)
        {
            return fdao.preenchergrid(nome);
        }
    }
}
