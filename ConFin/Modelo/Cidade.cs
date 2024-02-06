using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Modelo
{
    public class Cidade
    {
        public int cidadeId { get; set; }
        public string nome { get; set; }
        public string estadoSigla { get; set; }

        public Cidade(int cidadeId, string nome, string estadoSigla)
        {
            this.cidadeId = cidadeId;
            this.nome = nome;
            this.estadoSigla = estadoSigla;
        }
    }
}
