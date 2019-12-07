using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soverteria.Controller
{
    using Model;
    using Dao;

    class CategoriaController
    {
        public string cadastrarCategoria(Categoria categoria)
        {

            CategoriaDao cateDao = new CategoriaDao();
            int f = cateDao.cadastrarCategoria(categoria);
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
