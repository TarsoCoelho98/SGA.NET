using System;

namespace SGA.DAL.Entity
{
    public class Locatario
    {
        public int IdLocatario { get; set; }
        public string Nome { get; set; }
        public decimal VlAluguel { get; set; }
        public decimal? VlCalcao { get; set; }
        public string StatusCalcao { get; set; }
        public string DiaPagamento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public int FkCasa { get; set; }
        public int FkQuarto { get; set; }
        public double? Debito { get; set; }
        public double? Credito { get; set; }
        public string DtNascimento { get; set; }
        public string Sexo { get; set; }
        public string Observacao { get; set; }
        public string StatusPagamento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
    }
}
