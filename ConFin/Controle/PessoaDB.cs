using ConFin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.Controle
{
    public class PessoaDB
    {
        public static List<Pessoa> GetPessoas(NpgsqlConnection conexao)
        {
            List<Pessoa> lista = new List<Pessoa>();
            try
            {
                string sql = "select * from pessoa order by nome";
                NpgsqlCommand cdm = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader rd = cdm.ExecuteReader();
                while (rd.Read())
                {
                    int pessoaId = int.Parse(rd["pessoaId"].ToString());
                    string nome = rd["nome"].ToString();
                    string cpfcnpj = rd["cpfcnpj"].ToString();
                    string endereco = rd["endereco"].ToString();
                    string bairro = rd["bairro"].ToString();
                    string telefone = rd["telefone"].ToString();
                    string email = rd["email"].ToString();
                    int tipo = int.Parse(rd["tipo"].ToString());
                    int cidadeId = int.Parse(rd["cidadeId"].ToString());
                    Pessoa pessoa = new Pessoa(pessoaId, nome, cpfcnpj, endereco, bairro, telefone, email, tipo, cidadeId);
                    lista.Add(pessoa);

                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);                
            }
            return lista;
        }
    }
}
