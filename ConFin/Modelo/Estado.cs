using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Modelo
{
    public class Estado
    {
        public string estadoSigla { get; set; }
        public string nome { get; set; }


        public Estado(string estadoSigla, string nome)
        {
            this.estadoSigla = estadoSigla;
            this.nome = nome;
        }
    }
}
