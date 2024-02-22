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
                rd.Close();
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);                
            }
            return lista;
        }

        public static bool SetIncluiPessoa(NpgsqlConnection conexao, Pessoa pessoa)
        {
            bool realizou = false;
            try
            {
                string sql = "insert into pessoa(nome,cpfcnpj,endereco,bairro,telefone,email,tipo,cidadeId)"
                            + "values (@nome,@cpfcnpj,@endereco,@bairro,@telefone,@email,@tipo,@cidadeId)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.nome;
                cmd.Parameters.Add("@cpfcnpj", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.cpfcnpj;
                cmd.Parameters.Add("@endereco", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.endereco;
                cmd.Parameters.Add("@bairro", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.bairro;
                cmd.Parameters.Add("@telefone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.telefone;
                cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.email;
                cmd.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.tipo;
                cmd.Parameters.Add("@cidadeId", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.cidadeId;
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

        public static bool SetAlteraPessoa(NpgsqlConnection conexao, Pessoa pessoa)
        {
            bool realizou = false;
            try
            {
                string sql = "update pessoa set nome = @nome"
                            + " , cpfcnpj = @cpfcnpj "
                            + " , endereco = @endereco "
                            + " , bairro = @bairro "
                            + " , telefone = @telefone "
                            + " , email = @email "
                            + " , tipo = @tipo "
                            + " , cidadeId = @cidadeId"
                            + " where pessoaId = @pessoaId";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.nome;
                cmd.Parameters.Add("@cpfcnpj", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.cpfcnpj;
                cmd.Parameters.Add("@endereco", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.endereco;
                cmd.Parameters.Add("@bairro", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.bairro;
                cmd.Parameters.Add("@telefone", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.telefone;
                cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoa.email;
                cmd.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.tipo;
                cmd.Parameters.Add("@cidadeId", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.cidadeId;
                cmd.Parameters.Add("@pessoaId", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoa.pessoaId;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    realizou = true;
                }
            }
            catch (NpgsqlException erro)
            {

                MessageBox.Show("Erro de SQLaaa: " + erro.Message);
            }
            return realizou;
        }

        public static bool SetExcluiPessoa(NpgsqlConnection conexao, int pessoaId)
        {
            bool realizou = false;
            try
            {
                string sql = "delete from pessoa where pessoaId = @pessoaId";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@pessoaId", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoaId;
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
