using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.Controle
{
    public class Conexao
    {
        public static NpgsqlConnection GetConexao() 
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new NpgsqlConnection("server=localhost;port=5432;user id=postgres;password=1234;database=financeiro");
                conexao.Open();
                //MessageBox.Show("Conectou");
                //Console.WriteLine("Conectou");
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao se conectar ao banco de dados: " + erro.Message);
            }

            return conexao;
        }

        public static void SetFechaConexao(NpgsqlConnection conexao)
        {
            if (conexao != null)
            {
                try
                {
                    conexao.Close();
                    //MessageBox.Show("Fechou a conexão");
                    //Console.WriteLine("Fechou a conexão");
                }
                catch (NpgsqlException erro)
                {
                    MessageBox.Show("Erro ao fechar a conexão do banco de dados: " + erro.Message);
                }
            }                
        }
    }
}
