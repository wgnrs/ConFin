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
    public class EstadoDB
    {
        public static List<Estado> GetEstados(NpgsqlConnection conexao)
        {
            List<Estado> lista = new List<Estado>(); 
            try
            {
                string sql = "select * from estado order by estadosigla";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao); //objeto da classe npgsql que representa um comando sql 
                NpgsqlDataReader rd = cmd.ExecuteReader(); //o metodo ExecuteReader retorna uma lista de objeto do tipo "DataReader" NpgsqlDataReader é a classe para lidar com esse retorno.
                while (rd.Read()) //rd é a lista de obj
                {
                    string estadosigla = rd["estadosigla"].ToString();  //referenciando o campo, transformando em string e armazenando
                    string nome = rd["nome"].ToString();
                    Estado estado = new Estado(estadosigla, nome); //obj do tipo estado para armezar lá na lista de cima do tipo Estado (List<Estado>)
                    lista.Add(estado); //obj do tipo lista utilizando um metodo Add com paremetro de estado
                }
                rd.Close(); //fechando a conexão do DataReader para não dar problema depois.
            }
            catch (NpgsqlException error)
            {

                MessageBox.Show("Erro de SQL: " + error.Message);
            }

            return lista;
        }

        public static bool SetIncluiEstado(NpgsqlConnection conexao, Estado estado)
        {
            bool realizou = false;
            try
            {
                string sql = "insert into estado(estadosigla,nome) values(@estadosigla, @nome)";
                NpgsqlCommand cmd = new NpgsqlCommand( sql, conexao);
                cmd.Parameters.Add("@estadosigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.estadoSigla; //alterando valor do parametro estadosigla para varchar
                                                                                                                 //e que o valor do @estadosigla esta em estado.estadoSigla 
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;
                int valor = cmd.ExecuteNonQuery();
                if(valor == 1) //Validação de inserção
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
        public static bool SetAlteraEstado(NpgsqlConnection conexao, Estado estado)
        {
            bool realizou = false;
            try
            {
                string sql = "update estado set nome = @nome where estadosigla = @estadosigla";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;
                cmd.Parameters.Add("@estadosigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.estadoSigla;
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
