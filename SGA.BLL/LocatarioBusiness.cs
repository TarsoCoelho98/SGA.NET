using System.Collections.Generic;
using SGA.DAL.Entity;
using SGA.DAL.Facade;

namespace SGA.BLL
{
    public class LocatarioBusiness
    {
        #region CRUD

        public static void Insert(Locatario loc)
        {
            LocatarioFacade.Insert(loc.Nome, loc.VlAluguel, loc.VlCalcao, loc.StatusCalcao, loc.DtPagamento, loc.Email,
                                   loc.Celular, loc.FkCasa, loc.FkQuarto, loc.Debito, loc.Credito, loc.DtNascimento,
                                   loc.Sexo, loc.Observacao);
        }

        public static void Delete(Locatario loc)
        {
            LocatarioFacade.Delete(loc.IdLocatario);
        }

        public static void Update(Locatario locNovo)
        {
            LocatarioFacade.Update(locNovo.IdLocatario, locNovo.Nome, locNovo.VlAluguel, locNovo.VlCalcao, 
                                   locNovo.StatusCalcao, locNovo.DtPagamento, locNovo.Email, locNovo.Celular, 
                                   locNovo.FkCasa, locNovo.FkQuarto, locNovo.Debito, locNovo.Credito, locNovo.Observacao);
        }

        public static List<Locatario> QueryAll(Locatario loc)
        {
            return LocatarioFacade.QueryAll(loc.Nome, loc.VlAluguel, loc.VlCalcao, loc.StatusCalcao, loc.DtPagamento, loc.FkCasa, loc.FkQuarto, loc.Sexo);
        }

        #endregion       
    }
}
