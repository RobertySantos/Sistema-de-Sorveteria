using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soverteria.Controller
{
    using Model;
    using Dao;

    class FormaPagtoController
    {
        public string cadastrarFormaPagto(FormaPagto forma)
        {

            FormaPagtoDao formaDao = new FormaPagtoDao();
            int f = formaDao.cadastrarFormaPagto(forma);
            if (f > 0)
            {
                return ("Cadastro realizado com sucesso," + f + "cadastrado(s)");
            }
            else
            {
                return ("Erro ao cadastrar");
            }
        }
    }
}
