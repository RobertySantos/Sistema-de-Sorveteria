using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soverteria
{
    using Model;
    using View;
    using Controller;
    using Dao;
    using System.Data.SqlClient;

    public partial class CadastroFormaPagto : Form
    {
        public CadastroFormaPagto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void habilitar()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            txtFormaPagto.Enabled = true;
        }

        public void desabilitar() {
            txtFormaPagto.Clear();

            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            txtFormaPagto.Enabled = false;
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
            FormaPagto forma = new FormaPagto();

            forma.DescFormaPagto = txtFormaPagto.Text;

            FormaPagtoController fController = new FormaPagtoController();
            MessageBox.Show(fController.cadastrarFormaPagto(forma));
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
