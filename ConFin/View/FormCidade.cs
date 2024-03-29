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
    public partial class FormCidade : Form
    {
        public NpgsqlConnection conexao = null;
        public FormCidade(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            List<Cidade> lista = CidadeDB.GetCidades(conexao);
            dataGridViewMostra.DataSource = lista; //recebe o lista como DataSource para mostrar no grid
        }

        private void buttonNova_Click(object sender, EventArgs e)
        {
            FormCidadeNova form = new FormCidadeNova(conexao);
            form.ShowDialog();
            AtualizaGrid();
        }

        private void buttonAltera_Click(object sender, EventArgs e)
        {
            Cidade cidade = (Cidade)dataGridViewMostra.SelectedRows[0].DataBoundItem;
            FormCidadeAltera form = new FormCidadeAltera(conexao, cidade);
            form.ShowDialog();
            AtualizaGrid();
        }

        private void buttonExclui_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir a cidade?", "Excluir cidade", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Cidade cidade = (Cidade) dataGridViewMostra.SelectedRows[0].DataBoundItem;
                bool realizou = CidadeDB.SetExcluiCidade(conexao, cidade.cidadeId);
                if (realizou)
                {
                    MessageBox.Show("Cidade excluida com sucesso!");
                    AtualizaGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade!");
                }
            }
        }
    }
}
