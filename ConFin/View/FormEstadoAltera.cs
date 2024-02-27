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
    public partial class FormEstadoAltera : Form
    {
        NpgsqlConnection conexao = null;
        public FormEstadoAltera(NpgsqlConnection conexao, Estado estado)
        {
            this.conexao = conexao;
            InitializeComponent();
            textBoxSigla.Text = estado.estadoSigla;
            textBoxNome.Text = estado.nome;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado(textBoxSigla.Text, textBoxNome.Text);
            bool realizou = EstadoDB.SetAlteraEstado(conexao, estado);
            if (realizou) 
            {
                MessageBox.Show("Estado alterado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar o estado");
            }
        }
    }
}
