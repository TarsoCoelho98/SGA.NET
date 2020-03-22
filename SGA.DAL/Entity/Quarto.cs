using SGA.DAL.Enums;

namespace SGA.DAL.Entity
{
    public class Quarto
    {
        public int IdQuarto { get; set; }
        public decimal VlAluguel { get; set; }
        public decimal? VlCalcao { get; set; }
        public int FkCasa { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
    }
}
