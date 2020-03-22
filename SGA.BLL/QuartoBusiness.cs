using System;
using System.Collections.Generic;
using System.Linq;
using SGA.DAL.Entity;
using SGA.DAL.Enums;
using SGA.DAL.Facade;
using SGA.DAL;
using System.Globalization;

namespace SGA.BLL
{
    public class QuartoBusiness
    {
        #region CRUD

        public static void Insert(string vlAluguel, string vlCalcao, string fkCasa, string status, string observacao)
        {
            QuartoFacade.Insert(vlAluguel, vlCalcao, fkCasa, status, observacao);
        }

        public static void Delete(int idReferencia)
        {
            QuartoFacade.Delete(idReferencia);
        }

        public static void Update(int idReferencia, string vlAluguel, string vlCalcao, string novoFkCasa, string novoStatus, string novoObservacao)
        {
            QuartoFacade.Update(idReferencia, vlAluguel, vlCalcao, novoFkCasa, novoStatus, novoObservacao);
        }

        public static List<Quarto> QueryAll(string idQuarto, string vlAluguel, string vlCalcao, string fkCasa, string status)
        {
            return QuartoFacade.QueryAll(idQuarto, vlAluguel, vlCalcao, fkCasa, status);
        }

        #endregion        
    }
}
