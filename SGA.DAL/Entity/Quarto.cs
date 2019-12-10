namespace SGA.DAL.Entity
{
    public class Quarto
    {
        public int IdQuarto { get; set; }
        public double VlAluguel { get; set; }
        public double VlCalcao { get; set; }
        public int FkCasa { get; set; }
        public string Observacao { get; set; }
        public string Status { get; set; }
    }
}
