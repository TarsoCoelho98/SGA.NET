using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SGA.DAL.Entity;
using SGA.DAL.Facade;

namespace SGA.BLL
{
    public class CasaBusiness
    {
        #region CRUD

        public static void Insert(Casa casa)
        {
            CasaFacade.Insert(casa.Rua, casa.Bairro, casa.Numero, casa.CEP, casa.Observacao);
        }

        public static void Delete(Casa casa)
        {
            CasaFacade.Delete(casa.IdCasa);
        }

        public static void Update(Casa casaNovo)
        {
            CasaFacade.Update(casaNovo.IdCasa, casaNovo.Rua, casaNovo.Bairro, casaNovo.Numero, casaNovo.CEP, casaNovo.Observacao);
        }

        public static List<Casa> QueryAll(int id, string rua, string bairro, int cep)
        {
            return CasaFacade.QueryAll(id, rua, bairro, cep);
        }

        #endregion       
    }
}
