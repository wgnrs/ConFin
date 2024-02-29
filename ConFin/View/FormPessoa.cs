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
    public partial class FormPessoa : Form
    {
        NpgsqlConnection conexao = null;
        public FormPessoa(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            dataGridViewMostra.AutoGenerateColumns = false;
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            List<Pessoa> lista = PessoaDB.GetPessoas(conexao);
            dataGridViewMostra.DataSource = lista;
        }

        private void buttonNova_Click(object sender, EventArgs e)
        {
            FormPessoaNovo form = new FormPessoaNovo(conexao);
            form.ShowDialog();
            AtualizaGrid();
        }
    }
}
