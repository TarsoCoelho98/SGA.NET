using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGA.DAL;

namespace SGA.BLL
{
    public class ConfiguracaoBusiness
    {
        public Configuracao Config { get; set; }

        public ConfiguracaoBusiness(string instanciaSql, string diretorioBaseAplicacao)
        {
            Config = new Configuracao(instanciaSql, diretorioBaseAplicacao);
        }

        public static bool IsSystemReady()
        {
            return Configuracao.IsSystemReady();
        }

        public void ConfigureFilePaths()
        {
            Config.ConfigureFilePaths();
        }

        public void ConfigureConnectionString()
        {
            Config.ConfigureConnectionString();
        }

        public bool ConnectionTest()
        {
            return Config.ConnectionTest();
        }
    }
}
