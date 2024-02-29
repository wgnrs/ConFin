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
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            List<Pessoa> lista = PessoaDB.GetPessoas(conexao);
            dataGridViewMostra.DataSource = lista;
        }
    }
}
