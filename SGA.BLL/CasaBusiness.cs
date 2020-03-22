using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SGA.DAL.Entity;
using SGA.DAL.Facade;
using SGA.DAL;

namespace SGA.BLL
{
    public class CasaBusiness
    {
        #region CRUD

        public static void Insert(string rua, string bairro, int numero, long cep, string observacao, string cidade)
        {
            CasaFacade.Insert(rua, bairro, numero, cep, observacao, cidade);
        }

        public static void Delete(int idReferencia)
        {
            CasaFacade.Delete(idReferencia);
        }

        public static void Update(int idReferencia, string novoRua, string novoBairro, string novoNumero, string novoCep, string novoObservacao, string cidade)
        {
            CasaFacade.Update(idReferencia, novoRua, novoBairro, novoNumero, novoCep, novoObservacao, cidade);
        }

        public static List<Casa> QueryAll(string id, string cidade, string bairro, string cep)
        {
            return CasaFacade.QueryAll(id, cidade, bairro, cep);
        }

        #endregion        
    }
}
