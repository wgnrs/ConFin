using ConFin.Controle;
using ConFin.Modelo;
using ConFin.View;
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
    public partial class FormPrincipal : Form
    {
        public NpgsqlConnection conexao = null; //atributo conexão criado
        public FormPrincipal() //metodo construtor
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
            List<Conta> lista = ContaDB.GetContas(conexao);
            richTextBoxMostra.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Conta conta = lista[i];
                richTextBoxMostra.AppendText("Conta " + conta.contaId + " - " + conta.descricao + " /"+ conta.dataVencimento + "\n");
            }
        } 

        private void buttonIncluir_Click_1(object sender, EventArgs e)
        {
            var conta = new Conta("test", 22.55, DateTime.Now, DateTime.Now, 1, 2, 1);
            bool realizou = ContaDB.SetIncluiConta(conexao, conta);
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
            Conta conta = new Conta(13, "Paçoca", 100.00 , DateTime.Now, DateTime.Now, 1, 2, 1);
            ContaDB.SetAlteraConta(conexao, conta);
            bool realizou = ContaDB.SetAlteraConta(conexao, conta);
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
            bool realizou = ContaDB.SetExcluiConta(conexao, 14);
            if (realizou)
            {
                MessageBox.Show("Excluiu");
            }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstado form = new FormEstado(conexao);
            form.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCidade form = new FormCidade(conexao);
            form.ShowDialog();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPessoa form = new FormPessoa(conexao);
            form.ShowDialog();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConta form = new FormConta(conexao);
            form.ShowDialog();
        }
    }
}
