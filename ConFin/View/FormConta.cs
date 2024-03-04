using ConFin.Controle;
using ConFin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.View
{
    public partial class FormConta : Form
    {
        NpgsqlConnection conexao = null;
        public FormConta(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            dataGridViewMostra.AutoGenerateColumns = false;
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            List<Conta> lista = ContaDB.GetContas(conexao);
            dataGridViewMostra.DataSource = lista;
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            FormContaNova form = new FormContaNova(conexao);
            form.ShowDialog();
            AtualizaGrid();
        }
    }
}
