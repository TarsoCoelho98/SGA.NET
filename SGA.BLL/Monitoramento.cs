using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGA.DAL;
using SGA.DAL.Facade;

namespace SGA.BLL
{
    public class Monitoramento
    {
        public static void InserirEnvioEmailAniversario()
        {
            MonitoramentoFacade.InserirEnvioEmailAniversario();
        }

        public static bool EmailAniversarioEnviadoDataAtual()
        {
            return MonitoramentoFacade.EmailAniversarioEnviadoDataAtual();
        }        
    }
}
