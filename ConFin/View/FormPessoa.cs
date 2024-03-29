﻿using ConFin.Controle;
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
    public partial class FormPessoa : Form
    {
        NpgsqlConnection conexao = null;
        public FormPessoa(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            dataGridViewMostra.AutoGenerateColumns = false;
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            List<Pessoa> lista = PessoaDB.GetPessoas(conexao);
            dataGridViewMostra.DataSource = lista;
        }

        private void buttonNova_Click(object sender, EventArgs e)
        {
            FormPessoaNovo form = new FormPessoaNovo(conexao);
            form.ShowDialog();
            AtualizaGrid();
        }

        private void buttonAltera_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = (Pessoa)dataGridViewMostra.SelectedRows[0].DataBoundItem;
            FormPessoaAltera form = new FormPessoaAltera(conexao, pessoa);
            form.ShowDialog();
            AtualizaGrid();
        }

        private void buttonExclui_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir esta pessoa?", "Excluir pessoa", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Pessoa pessoa = (Pessoa)dataGridViewMostra.SelectedRows[0].DataBoundItem;
                bool realizou = PessoaDB.SetExcluiPessoa(conexao, pessoa.pessoaId);
                if (realizou)
                {
                    MessageBox.Show("Pessoa excluida com sucesso!");
                    AtualizaGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a pessoa!");
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!");
            }
        }
    }
}
