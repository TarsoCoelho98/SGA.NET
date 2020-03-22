using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.DAL.Entity
{
    public class Contrato
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string CidadeOrigemLocatario { get; set; }
        public int CodigoBanco { get; set; }
        public string NomeBanco { get; set; }
        public long Agencia { get; set; }
        public long Conta { get; set; }
        public DateTime InicioContrato { get; set; }
        public DateTime TerminoContrato { get; set; }
        public int VigenciaMeses { get; set; }
        public string CidadeAtual { get; set; }
        public string TipoConta { get; set; }
        public int Digito { get; set; }

        public Contrato(string rua, string bairro, string uf, string cidadeOrigemLocatario, int codigoBanco, string nomeBanco, long agencia, long conta, DateTime inicioContrato, DateTime terminoContrato, int vigenciaMeses, string cidadeAtual, string tipoConta, int digito)
        {
            Rua = rua;
            Bairro = bairro;
            UF = uf;
            CidadeOrigemLocatario = cidadeOrigemLocatario;
            CodigoBanco = codigoBanco;
            NomeBanco = nomeBanco;
            Agencia = agencia;
            Conta = conta;
            InicioContrato = inicioContrato;
            TerminoContrato = terminoContrato;
            VigenciaMeses = vigenciaMeses;
            CidadeAtual = cidadeAtual;
            TipoConta = tipoConta;
            Digito = digito;
        }
    }
}
