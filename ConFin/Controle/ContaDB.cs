using ConFin.Modelo;
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
    }
}
