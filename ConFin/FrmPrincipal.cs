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

namespace ConFin
{
    public partial class FrmPrincipal : Form
    {
        public NpgsqlConnection conexao = null; //atributo conexão criado
        public FrmPrincipal() //metodo construtor
        {
            conexao = Conexao.GetConexao(); //instanciando o obj conexao com um conexao pronta utilizando o metodo getconexao
            InitializeComponent(); //metodo de criação de formulário
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexao.SetFechaConexao(conexao);
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            List<Cidade> lista = CidadeDB.GetCidades(conexao);
            richTextBoxMostra.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Cidade cidade = lista[i];
                richTextBoxMostra.AppendText("Cidade " + cidade.cidadeId + " - " + cidade.nome + " /"+ cidade.estadoSigla + "\n");
            }
        } 

        private void buttonIncluir_Click_1(object sender, EventArgs e)
        {
            Estado estado = new Estado("RJ", "Rio de Janeiro");
            bool realizou = EstadoDB.SetIncluiEstado(conexao, estado);
            if (realizou)
            {
                MessageBox.Show("Foi incluído");
            }
            else
            {
                MessageBox.Show("Erro ao incluir");
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado("RJ", "Rio Niterói");
            EstadoDB.SetAlteraEstado(conexao, estado);
            bool realizou = EstadoDB.SetAlteraEstado(conexao, estado);
            if(realizou)
            {
                MessageBox.Show("Alterado");
            }
            else
            {
                MessageBox.Show("Erro ao alterar");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            bool realizou = EstadoDB.SetExcluiEstado(conexao, "RJ");
            if (realizou)
            {
                MessageBox.Show("Excluiu");
            }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }
        }
    }
}
