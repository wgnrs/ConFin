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
    public partial class FormCidadeNova : Form
    {
        NpgsqlConnection conexao = null;
        public FormCidadeNova(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            PopulaComboEstado();
        }

        private void PopulaComboEstado()
        {
            List<Estado> lista = EstadoDB.GetEstados(conexao);
            comboBoxEstado.Items.Clear();
            comboBoxEstado.DataSource = lista;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            Estado estado = (Estado) comboBoxEstado.SelectedItem;
            Cidade cidade = new Cidade(nome, estado.estadoSigla);
            bool realizou = CidadeDB.SetIncluiCidade(conexao, cidade);
            if (realizou)
            {
                MessageBox.Show("Cidade cadastrada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar cidade!");
            }
        }
    }
}
