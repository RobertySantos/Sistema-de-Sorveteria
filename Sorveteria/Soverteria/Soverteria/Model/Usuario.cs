using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soverteria.Model
{
    class Usuario
    {
        private String nome;
        private String login;
        private String senha;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
      

        public String Login
        {
            get { return login; }
            set { login = value; }
        }
       

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
