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
            List<Pessoa> lista = PessoaDB.GetPessoas(conexao);
            richTextBoxMostra.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Pessoa pessoa = lista[i];
                richTextBoxMostra.AppendText("Pessoa " + pessoa.pessoaId + " - " + pessoa.nome + " /"+ pessoa.telefone + "\n");
            }
        } 

        private void buttonIncluir_Click_1(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa("Joao da Silva","000.000.000-00","Rua das palmeiras, 30","Jardim America","(99)99999-9999","joao@web.com.br",0,1);
            bool realizou = PessoaDB.SetIncluiPessoa(conexao, pessoa);
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
            Pessoa pessoa = new Pessoa(2, "Joao da Souza", "000.000.000-00", "Rua das GAITA, 52", "Olimpico", "(99)99999-9999", "joao@ueeb.com.br", 0, 1);
            PessoaDB.SetAlteraPessoa(conexao, pessoa);
            bool realizou = PessoaDB.SetAlteraPessoa(conexao, pessoa);
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
            bool realizou = PessoaDB.SetExcluiPessoa(conexao, 4);
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
