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
    public partial class FormContaNova : Form
    {
        NpgsqlConnection conexao = null;
        public FormContaNova(NpgsqlConnection conexao)
        {
           this.conexao = conexao;
            InitializeComponent();
            AjustaCampos();
        }

        private void AjustaCampos()
        {
            List<Pessoa> lista = PessoaDB.GetPessoas(this.conexao);
            comboBoxPessoa.Items.Clear();
            comboBoxPessoa.DataSource = lista;
            comboBoxTipo.SelectedIndex = 0;
            comboBoxSituacao.SelectedIndex = 0;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;
            double valor = double.Parse(textBoxValor.Text);
            DateTime dataVencimento = DateTime.Parse(maskedTextBoxDataVencimento.Text);
            DateTime ? valorPadrao = null;
            DateTime dataPagamento = valorPadrao.GetValueOrDefault();
            try
            {
                dataPagamento = DateTime.Parse(maskedTextBoxDataPagamento.Text);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro de conversão de data: " +  erro.Message);                
            }            
            int tipo = comboBoxTipo.SelectedIndex;
            int situacao = comboBoxSituacao.SelectedIndex;
            int pessoaId = ((Pessoa)comboBoxPessoa.SelectedItem).pessoaId;
            Conta conta = new Conta(descricao,valor,dataVencimento,dataPagamento,situacao,tipo,pessoaId);
            bool realizou = ContaDB.SetIncluiConta(conexao, conta);
            if (realizou)
            {
                MessageBox.Show("Conta cadastrada com sucesso!");
                Close();            
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar conta!");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDataPagamento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDataVencimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
