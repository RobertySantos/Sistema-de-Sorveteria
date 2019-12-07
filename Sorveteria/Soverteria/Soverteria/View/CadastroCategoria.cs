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

    public partial class CadastroCategoria : Form
    {
        public CadastroCategoria()
        {
            InitializeComponent();
        }

        public void habilitar() {
            txtDescCategoria.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        public void desabilitar() {
            txtDescCategoria.Clear();

            txtDescCategoria.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Conexao c = new Conexao();
            Categoria cate = new Categoria();

            cate.Descricao = txtDescCategoria.Text;

            CategoriaController cateController = new CategoriaController();
            MessageBox.Show(cateController.cadastrarCategoria(cate));
            c.desconectar();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cadastro t = new Cadastro();
            t.Show();
            this.Hide();
        }

       

    }
}
