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
                    Estado estado = new Estado(estadosigla, nome); //obg do tipo estado para armezar lá na lista de cima do tipo Estado (List<Estado>)
                    lista.Add(estado); //obj do tipo lista utilizando um metodo Add com paremetro de estado
                }
                rd.Close();
            }
            catch (NpgsqlException error)
            {

                MessageBox.Show("Erro de SQL: " + error.Message);
            }

            return lista;
        }
    }
}
