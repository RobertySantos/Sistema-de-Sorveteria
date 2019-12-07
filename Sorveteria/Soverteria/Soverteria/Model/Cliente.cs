using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soverteria.Model
{
    class Cliente
    {
        private int id;
        private String nome;
        private String rua;
        private String cpf;
        private String rg;
        private String bairro;
        private String cidade;
        private String uf;
        private String cep;
        private int numero;
        private String complemento;
        private List<String> listaFone = new List<string>();

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
       

        public String Rua
        {
            get { return rua; }
            set { rua = value; }
        }
      

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
       
        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }
     
        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
      

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
  

        public String Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
     

      

        public List<String> ListaFone
        {
            get { return listaFone; }
            set { listaFone = value; }
        }
    }
}
