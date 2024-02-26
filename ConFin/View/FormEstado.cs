using ConFin.Controle;
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
    public partial class FormEstado : Form
    {
        public NpgsqlConnection conexao = null; //atributo de conexão
        public FormEstado(NpgsqlConnection conexao)
        {
            this.conexao = Conexao.GetConexao();
            InitializeComponent();
        }

        private void FormEstado_Load(object sender, EventArgs e)
        {

        }
    }
}
