using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFin.Modelo
{
    public class Conta
    {
        public int contaId {  get; set; }
        public string descricao { get; set; }
        public double valor {  get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime dataPagamento { get; set; }
        public int situacao { get; set; }
        public int tipo { get; set; }
        public int pessoaId { get; set; }


        public Conta()
        {
                
        }

        public Conta(int contaId, string descricao, double valor, DateTime dataVencimento, DateTime dataPagamento, int situacao, int tipo, int pessoaId)
        {
            this.contaId = contaId;
            this.descricao = descricao;
            this.valor = valor;
            this.dataVencimento = dataVencimento;
            this.dataPagamento = dataPagamento;
            this.situacao = situacao;
            this.tipo = tipo;
            this.pessoaId = pessoaId;
        }

        public Conta(string descricao, double valor, DateTime dataVencimento, DateTime dataPagamento, int situacao, int tipo, int pessoaId)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.dataVencimento = dataVencimento;
            this.dataPagamento = dataPagamento;
            this.situacao = situacao;
            this.tipo = tipo;
            this.pessoaId = pessoaId;
        }

    }
}
