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
            List<Estado> lista = EstadoDB.GetEstados(conexao);
            richTextBoxMostra.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Estado estado = lista[i];
                richTextBoxMostra.AppendText("Estado" + estado.estadoSigla + " - " + estado.nome + "\n");
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
    }
}
