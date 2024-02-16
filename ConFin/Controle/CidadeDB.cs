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
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(error.Message);
            }
            return lista;
        }
    }
}
