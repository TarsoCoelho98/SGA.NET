using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.DAL.Entity
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Racf { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaEmail { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int CasaNumero { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
