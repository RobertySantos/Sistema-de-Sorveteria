using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soverteria.View
{
    using Model;
    using Controller;
    using Dao;
    using System.Data.SqlClient;

    public partial class CadastroFornecedor : Form
    {
        Fornecedor forne = new Fornecedor();
        FornecedorController forneController = new FornecedorController();

        public CadastroFornecedor()
        {
            InitializeComponent();
            dataGridView1.DataSource = forneController.listarFornecedores();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 125;
        }

        public void habilitar() {
            txtContato.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Enabled = true;

            btnCancelar.Enabled = true;
            btnRelatorio.Enabled = true;
            btnSalvar.Enabled = true;
        }

        public void limparCampos() {
            txtNome.Clear();
            txtContato.Clear();
            txtTelefone.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Conexao c = new Conexao();
         

            forne.Nome = txtNome.Text;
            forne.Contato = txtContato.Text;
            forne.FoneFornecedor = txtTelefone.Text;

           
            MessageBox.Show(forneController.cadastrarFornecedor(forne));
            c.desconectar();
            limparCampos();

            dataGridView1.DataSource = forneController.listarFornecedores();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cadastro t = new Cadastro();
            t.Show();
            this.Hide();
        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = forneController.listarFornecedoresPesquisa(textBox1.Text);
        }

      
    }
}
