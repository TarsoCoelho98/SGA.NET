using System;

namespace SGA.DAL.Entity
{
    public class Locatario
    {
        public int IdLocatario { get; set; }
        public string Nome { get; set; }
        public double VlAluguel { get; set; }
        public double VlCalcao { get; set; }
        public string StatusCalcao { get; set; }
        public DateTime DtPagamento { get; set; }
        public string Email { get; set; }
        public long Celular { get; set; }
        public int FkCasa { get; set; }
        public int FkQuarto { get; set; }
        public double Debito { get; set; }
        public double Credito { get; set; }
        public DateTime DtNascimento { get; set; }
        public char Sexo { get; set; }
        public string Observacao { get; set; }
    }
}
