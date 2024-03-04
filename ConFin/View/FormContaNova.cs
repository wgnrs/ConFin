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
    public partial class FormContaNova : Form
    {
        NpgsqlConnection conexao = null;
        public FormContaNova(NpgsqlConnection conexao)
        {
           this.conexao = conexao;
            InitializeComponent();
            AjustaCampos();
        }

        private void AjustaCampos()
        {
            List<Pessoa> lista = PessoaDB.GetPessoas(this.conexao);
            comboBoxPessoa.Items.Clear();
            comboBoxPessoa.DataSource = lista;
            comboBoxTipo.SelectedIndex = 0;
            comboBoxSituacao.SelectedIndex = 0;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
