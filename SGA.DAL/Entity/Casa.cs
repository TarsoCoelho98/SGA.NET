using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.DAL.Entity
{
    public class Casa
    {
        public int IdCasa { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string Observacao { get; set; }
    }
}
