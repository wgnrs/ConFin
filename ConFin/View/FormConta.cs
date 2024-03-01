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
    public partial class FormConta : Form
    {
        NpgsqlConnection conexao = null;
        public FormConta(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            List<Conta> lista = ContaDB.GetContas(conexao);
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {

        }
    }
}