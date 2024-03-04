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
    public partial class FormContaAltera : Form
    {
        NpgsqlConnection conexao = null;
        Conta conta = null;
        public FormContaAltera(NpgsqlConnection conexao,Conta conta)
        {
            this.conexao = conexao;
            this.conta = conta;
            InitializeComponent();
            AjustaCampos();
        }

        private void AjustaCampos()
        {
            List<Pessoa> lista = PessoaDB.GetPessoas(conexao);
            comboBoxPessoa.Items.Clear();
            comboBoxPessoa.DataSource = lista;
            int indice = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                Pessoa pessoa = lista[i];
                if(pessoa.pessoaId == conta.pessoaId)
                {
                    indice = i;
                    break;
                }
            }
            comboBoxPessoa.SelectedIndex = indice;

            textBoxId.Text = conta.contaId.ToString();
            textBoxDescricao.Text = conta.descricao;
            textBoxValor.Text = conta.valor.ToString("N2");
            maskedTextBoxDataVencimento.Text = conta.dataVencimento.ToString();
            maskedTextBoxDataPagamento.Text = conta.dataPagamento.ToString();
            comboBoxTipo.SelectedIndex = conta.tipo;
            comboBoxSituacao.SelectedIndex = conta.situacao;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            conta.descricao = textBoxDescricao.Text;
            conta.valor = double.Parse(textBoxValor.Text);
            conta.dataPagamento = DateTime.Parse(maskedTextBoxDataVencimento.Text);

            DateTime ? valorPadrao = null;
            DateTime dataPagamento = valorPadrao.GetValueOrDefault();
            try
            {
                dataPagamento = DateTime.Parse(maskedTextBoxDataPagamento.Text);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro de conversão de data: " + erro.Message);
            }
            conta.dataPagamento = dataPagamento;
            conta.tipo = comboBoxTipo.SelectedIndex;
            conta.situacao = comboBoxSituacao.SelectedIndex;
            conta.pessoaId = ((Pessoa)comboBoxPessoa.SelectedItem).pessoaId;

            bool realizou = ContaDB.SetAlteraConta(conexao, conta);
            if (realizou)
            {
                MessageBox.Show("Conta alterada com sucesso");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao alterar a conta!");
            }
        }
    }
}
