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
    public partial class FormPessoaAltera : Form
    {
        NpgsqlConnection conexao = null;
        Pessoa pessoa = null;
        public FormPessoaAltera(NpgsqlConnection conexao, Pessoa pessoa)
        {
            this.conexao = conexao;
            this.pessoa = pessoa;
            InitializeComponent();
            AjustaDados();
        }

        private void AjustaDados()
        {
            List<Cidade> lista = CidadeDB.GetCidades(conexao);
            comboBoxCidade.Items.Clear();
            comboBoxCidade.DataSource = lista;
            int indice = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                Cidade cidade = lista[i];
                if (cidade.cidadeId == pessoa.cidadeId)
                {
                    indice = i;
                    break;
                }
            }
            comboBoxCidade.SelectedIndex = indice;

            if(pessoa.tipo == 0)
            {
                comboBoxTipo.SelectedIndex = 0;
            }
            else
            {
                comboBoxTipo.SelectedIndex = 1;
            }

            textBoxId.Text = pessoa.pessoaId.ToString();
            textBoxNome.Text = pessoa.nome;
            textBoxCPFCNPJ.Text = pessoa.cpfcnpj;
            textBoxEndereco.Text = pessoa.endereco;
            textBoxBairro.Text = pessoa.bairro;
            textBoxTelefone.Text = pessoa.telefone;
            textBoxEmail.Text = pessoa.email;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
