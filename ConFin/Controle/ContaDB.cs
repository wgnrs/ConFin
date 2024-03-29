﻿using ConFin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.Controle
{
    public class ContaDB
    {
        public static List<Conta> GetContas(NpgsqlConnection conexao)
        {
            List<Conta> lista = new List<Conta>();
            try
            {
                string sql = "select * from conta order by dataVencimento";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int contaId = int.Parse(rd["contaId"].ToString());
                    string descricao = rd["descricao"].ToString();
                    double valor = double.Parse(rd["valor"].ToString());
                    DateTime dataVencimento = DateTime.Parse(rd["dataVencimento"].ToString());
                    DateTime dataPagamento = DateTime.Parse(rd["dataPagamento"].ToString());
                    int situacao = int.Parse(rd["situacao"].ToString());
                    int tipo = int.Parse(rd["tipo"].ToString());
                    int pessoaId = int.Parse(rd["pessoaId"].ToString());
                    Conta conta = new Conta(contaId, descricao, valor, dataVencimento, dataPagamento, situacao, tipo, pessoaId);
                    lista.Add(conta);
                }
                rd.Close();
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);               
            }
            return lista;
        }

        public static bool SetIncluiConta(NpgsqlConnection conexao, Conta conta)
        {
            bool realizou = false;
            try
            {
                string sql = "insert into conta(descricao, valor, dataVencimento, dataPagamento, situacao, tipo, pessoaId)"
                            + "values(@descricao, @valor, @dataVencimento, @dataPagamento, @situacao, @tipo, @pessoaId)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = conta.descricao;
                cmd.Parameters.Add("@valor", NpgsqlTypes.NpgsqlDbType.Numeric).Value = conta.valor;
                cmd.Parameters.Add("@dataVencimento", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = conta.dataVencimento;
                cmd.Parameters.Add("@dataPagamento", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = conta.dataPagamento;
                cmd.Parameters.Add("@situacao", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.situacao;
                cmd.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.tipo;
                cmd.Parameters.Add("@pessoaId", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.pessoaId;
                int valor = cmd.ExecuteNonQuery();
                if(valor == 1)
                {
                    realizou = true;
                }

            }
            catch (NpgsqlException erro)
            {

                MessageBox.Show("Erro de SQL: " + erro.Message);
            }
            return realizou;
        }

        public static bool SetAlteraConta(NpgsqlConnection conexao, Conta conta)
        {
            bool realizou = false;
            try
            {
                string sql = "update conta set descricao = @descricao"
                            + " , valor = @valor "
                            + " , dataVencimento = @dataVencimento "
                            + " , dataPagamento = @dataPagamento "
                            + " , situacao = @situacao "
                            + " , tipo = @tipo "
                            + " , pessoaId = @pessoaId"
                            + " where contaId = @contaId";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = conta.descricao;
                cmd.Parameters.Add("@valor", NpgsqlTypes.NpgsqlDbType.Numeric).Value = conta.valor;
                cmd.Parameters.Add("@dataVencimento", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = conta.dataVencimento;
                cmd.Parameters.Add("@dataPagamento", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = conta.dataPagamento;
                cmd.Parameters.Add("@situacao", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.situacao;
                cmd.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.tipo;
                cmd.Parameters.Add("@pessoaId", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.pessoaId;
                cmd.Parameters.Add("@contaId", NpgsqlTypes.NpgsqlDbType.Integer).Value = conta.contaId;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    realizou = true;
                }

            }
            catch (NpgsqlException erro)
            {

                MessageBox.Show("Erro de SQLa: " + erro.Message);
            }
            return realizou;
        }

        public static  bool SetExcluiConta(NpgsqlConnection conexao, int contaId)
        {
            bool realizou = false;
            try
            {
                string sql = "delete from conta where contaId = @contaId";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@contaId", NpgsqlTypes.NpgsqlDbType.Integer).Value=contaId;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    realizou = true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Errou com sucesso no SQL: " + erro.Message);                
            }
            return realizou;
        }
    }
}
