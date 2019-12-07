using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soverteria.Model
{
    class Fornecedor
    {
        private String nome;
        private String contato;
        private String foneFornecedor;

        public String FoneFornecedor
        {
            get { return foneFornecedor; }
            set { foneFornecedor = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
       
        public String Contato
        {
            get { return contato; }
            set { contato = value; }
        }
      

       
    }
}
