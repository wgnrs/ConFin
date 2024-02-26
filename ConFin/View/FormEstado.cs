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
    public partial class FormEstado : Form
    {
        public NpgsqlConnection conexao = null; //atributo de conexão
        public FormEstado(NpgsqlConnection conexao)
        {
            this.conexao = Conexao.GetConexao();
            InitializeComponent();
            AtualizaGrid();
        }

        private void FormEstado_Load(object sender, EventArgs e)
        {

        }

        private void AtualizaGrid()
        {
            List<Estado> lista = EstadoDB.GetEstados(conexao);
            dataGridViewMostra.DataSource = lista; //recebe o lista como DataSource para mostrar no grid
        }
    }
}
