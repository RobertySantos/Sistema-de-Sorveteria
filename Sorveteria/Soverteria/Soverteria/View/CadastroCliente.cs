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
    using Controller;
    using View;
    using Dao;
    using System.Data.SqlClient;

    public partial class CadastroCliente : Form
    {
        ClienteController con = new ClienteController();
        Cliente cliente = new Cliente();
        public CadastroCliente()
        {
            InitializeComponent();
            dataGridView1.DataSource = con.listarClientes();
            dataGridView1.Columns[0].Visible = false;
            desabilitar();
        }
      
        public void habilitar() {
            txtNome.Enabled = true;
            txtRG.Enabled = true;
            txtCPF.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtCEP.Enabled = true;
            txtRua.Enabled = true;
            txtTelefone.Enabled = true;
            cbEstados.Enabled = true;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            btnRelatorio.Enabled = true;
            
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            btnNovo.Enabled = false;
 
        }

        public void desabilitar() {

            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtComplemento.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            listaFone.Items.Clear();
            

            txtNome.Enabled = false;
            txtRG.Enabled = false;
            txtCPF.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtCEP.Enabled = false;
            txtRua.Enabled = false;
            txtTelefone.Enabled = false;
            cbEstados.Enabled = false;

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            btnRelatorio.Enabled = false;

            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            btnNovo.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cliente.Id = 0;
            habilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            cliente.Nome = txtNome.Text;
            cliente.Rg = txtRG.Text;
            cliente.Rua = txtRua.Text;
            cliente.Cpf = txtCPF.Text;
            cliente.Cep = txtCEP.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Uf = Convert.ToString(cbEstados.SelectedItem);
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Complemento = txtComplemento.Text;

            if (cliente.Id > 0)
            {
                con.editar(cliente);
             }
            else
            {
                con.cadastrar(cliente);
            }

            dataGridView1.DataSource = con.listarClientes();
            dataGridView1.Columns[0].Visible = false;
            desabilitar();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaFone.Items.Add(txtTelefone.Text);
            txtTelefone.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listaFone.Items.RemoveAt(listaFone.SelectedIndex);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cadastro t = new Cadastro();
            t.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.listarClientesPesquisa(textBox1.Text);
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cliente.Id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCPF.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtRG.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtRua.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNumero.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtComplemento.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtCidade.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtCEP.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtBairro.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
        }
        
    }
}
