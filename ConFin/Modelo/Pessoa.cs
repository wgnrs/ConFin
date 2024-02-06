using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Modelo
{
    public class Pessoa
    {
        public int pessoaId { get; set; }
        public string nome { get; set; }
        public string cpfcnpj {  get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set;}
        public string email {  get; set; }
        public int tipo { get; set; }
        public int cidadeId {  get; set; }


        public Pessoa(int pessoaId, string nome, string cpfcnpj, string endereco, string bairro, string telefone, string email, int tipo, int cidadeId)
        {
            this.pessoaId= pessoaId;
            this.nome=nome;
            this.cpfcnpj=cpfcnpj;
            this.endereco= endereco;
            this.bairro= bairro;
            this.telefone= telefone;
            this.email= email;
            this.tipo= tipo;
            this.cidadeId= cidadeId;
        }
    }
}
