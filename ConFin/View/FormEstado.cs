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

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            FormEstadoNovo form = new FormEstadoNovo(conexao);
            form.ShowDialog();
            AtualizaGrid();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Estado estado = (Estado) dataGridViewMostra.SelectedRows[0].DataBoundItem;
            FormEstadoAltera form = new FormEstadoAltera(conexao, estado);
            form.ShowDialog();
            AtualizaGrid();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o estado?", "Excluir estado", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Estado estado = (Estado)dataGridViewMostra.SelectedRows[0].DataBoundItem;
                bool realizou = EstadoDB.SetExcluiEstado(conexao, estado.estadoSigla);
                if (realizou)
                {
                    MessageBox.Show("Estado excluido com sucesso!");
                    AtualizaGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o estado!");
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }
    }
}
