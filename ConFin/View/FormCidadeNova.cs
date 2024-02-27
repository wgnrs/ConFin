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
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
