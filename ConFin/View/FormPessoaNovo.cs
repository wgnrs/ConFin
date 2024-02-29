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
    public partial class FormPessoaNovo : Form
    {
        NpgsqlConnection conexao = null;
        public FormPessoaNovo(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            PopulaComboCidade();
            comboBoxTipo.SelectedIndex = 0;
        }

        private void PopulaComboCidade()
        {
            List<Cidade> lista = CidadeDB.GetCidades(conexao);
            comboBoxCidade.Items.Clear();
            comboBoxCidade.DataSource = lista;
            if(comboBoxCidade.Items.Count > 0 )
            {
                comboBoxCidade.SelectedIndex = 0;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(textBoxNome.Text,
                            textBoxCPFCNPJ.Text,
                            textBoxEndereco.Text,
                            textBoxBairro.Text,
                            textBoxTelefone.Text,
                            textBoxEmail.Text,
                            comboBoxTipo.SelectedIndex,
                            ((Cidade)comboBoxCidade.SelectedItem).cidadeId);
            bool realizou = PessoaDB.SetIncluiPessoa(conexao, pessoa);
            if(realizou)
            {
                MessageBox.Show("Pessoa cadastrada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar a pessoa!");
            }
        }
    }
}
