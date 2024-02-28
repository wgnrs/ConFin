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
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
