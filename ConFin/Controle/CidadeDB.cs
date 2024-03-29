﻿using ConFin.Modelo;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.Controle
{
    public class CidadeDB
    {
        public static List<Cidade> GetCidades(NpgsqlConnection conexao)
        {
            List<Cidade> lista = new List<Cidade>();
            try
            {
                string sql = "select * from cidade order by nome";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int cidadeId = int.Parse(rd["cidadeId"].ToString());
                    string nome = rd["nome"].ToString();
                    string estadoSigla = rd["estadoSigla"].ToString();
                    Cidade cidade = new Cidade(cidadeId, nome, estadoSigla);
                    lista.Add(cidade);
                }
                rd.Close();
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(error.Message);
            }
            return lista;
        }

        public static bool SetIncluiCidade(NpgsqlConnection conexao, Cidade cidade)
        {
            bool realizou = false;
            try
            {
                string sql = "Insert into cidade(nome,estadoSigla) values (@nome,@estadoSigla)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.nome;
                cmd.Parameters.Add("@estadoSigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.estadoSigla;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
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

        public static bool SetAlteraCidade(NpgsqlConnection conexao, Cidade cidade)
        {
            bool realizou = false;
            try
            {
                string sql = "update cidade set nome = @nome, estadoSigla = @estadoSigla where cidadeId = @cidadeId";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@nome", NpgsqlDbType.Varchar).Value = cidade.nome;
                cmd.Parameters.Add("@estadoSigla", NpgsqlDbType.Varchar).Value = cidade.estadoSigla;
                cmd.Parameters.Add("@cidadeId", NpgsqlDbType.Integer).Value = cidade.cidadeId;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    realizou= true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);                
            }
            return realizou;
        }

        public static bool SetExcluiCidade(NpgsqlConnection conexao, int cidadeId)
        {
            bool realizou = false;
            try
            {
                string sql = "delete from cidade where cidadeId = @cidadeId";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@cidadeId", NpgsqlDbType.Integer).Value = cidadeId;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
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
    }
}
