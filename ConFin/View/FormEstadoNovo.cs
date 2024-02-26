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
    public partial class FormEstadoNovo : Form
    {
        NpgsqlConnection conexao = null;

        public FormEstadoNovo(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {            
            Estado estado = new Estado(textBoxSigla.Text, textBoxNome.Text);
            bool realizou = EstadoDB.SetIncluiEstado(conexao, estado);
            if (realizou)
            {
                MessageBox.Show("Estado cadastrado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Estado não cadastrado");
            }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
