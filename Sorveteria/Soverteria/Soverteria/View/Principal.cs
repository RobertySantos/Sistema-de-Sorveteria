using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Soverteria
{
    using Model;
    using Dao;
    using View;
    public partial class Principal : Form
    {
        public Principal()
        {
            Thread t = new Thread(new ThreadStart(splahScreen));
            t.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            t.Abort();
        }

        public void splahScreen()
        {
            Application.Run(new Splash());
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro t = new Cadastro();
            t.Show();
            this.Hide();
        }

    }
}
