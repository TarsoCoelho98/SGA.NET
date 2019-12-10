using System;
using System.Collections.Generic;
using System.Linq;
using SGA.DAL.Entity;
using SGA.DAL.Facade;

namespace SGA.BLL
{
    public class QuartoBusiness
    {
        #region CRUD

        public static void Insert(Quarto quarto)
        {
            QuartoFacade.Insert(quarto.VlAluguel, quarto.VlCalcao, quarto.FkCasa,
                                quarto.Status, quarto.Observacao);
        }

        public static void Delete(Quarto quarto)
        {
            QuartoFacade.Delete(quarto.IdQuarto);
        }

        public static void Update(Quarto quartoNovo)
        {
            QuartoFacade.Update(quartoNovo.IdQuarto, quartoNovo.VlAluguel, quartoNovo.VlCalcao,
                                quartoNovo.FkCasa, quartoNovo.Status, quartoNovo.Observacao);
        }

        public static List<Quarto> QueryAll(Quarto quarto)
        {
            return QuartoFacade.QueryAll(quarto.IdQuarto, quarto.VlAluguel, quarto.VlCalcao, quarto.FkCasa, quarto.Status);
        }
        #endregion        
    }
}
