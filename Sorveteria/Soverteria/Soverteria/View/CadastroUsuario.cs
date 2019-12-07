using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soverteria.View
{
    using Model;
    using Controller;
    using System.Data.SqlClient;

    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void habilitar() {

            txtLogin.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            btnCadastrar.Enabled = true;
            btnCancelar.Enabled = true;
            
        }

        public void desabilitar() {

            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();

            txtLogin.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = false;
            
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();
            Usuario user = new Usuario();

            user.Nome = txtNome.Text;
            user.Login = txtLogin.Text;
            user.Senha = txtSenha.Text;

            UsuarioController userController = new UsuarioController();
            MessageBox.Show(userController.cadastrarUsuario(user));
            c.desconectar();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cadastro tc = new Cadastro();
            tc.Show();
            this.Hide();
        }

       

       
    }
}
