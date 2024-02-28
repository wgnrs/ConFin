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
    public partial class FormCidadeAltera : Form
    {
        NpgsqlConnection conexao = null;
        Cidade cidade = null;
        public FormCidadeAltera(NpgsqlConnection conexao, Cidade cidade)
        {
            this.conexao = conexao;
            this.cidade = cidade;
            InitializeComponent();
            textBoxNome.Text = cidade.nome;
            textBoxId.Text = cidade.cidadeId.ToString();
            PopulaComboEstado();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PopulaComboEstado()
        {
            List<Estado> lista = EstadoDB.GetEstados(conexao);
            comboBoxEstado.Items.Clear();
            comboBoxEstado.DataSource = lista;
            int indice = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                Estado estado = lista[i];
                if (estado.estadoSigla == cidade.estadoSigla)
                {
                    indice = i;
                    break;
                }
            }
            comboBoxEstado.SelectedIndex = indice;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
