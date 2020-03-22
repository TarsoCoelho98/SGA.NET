using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGA.DAL;
using SGA.DAL.Entity;
using SGA.DAL.Facade;

namespace SGA.BLL
{
    public class LocatarioBusiness
    {
        #region CRUD

        public static void Insert(string nome, string vlAluguel, string vlCalcao, string statusCalcao, string diaPagamento,
                                  string email, string celular, string fkCasa, string fkQuarto, string debito, string credito, string dtNascimento,
                                  string sexo, string observacao, string statusPagamento, string cpf, string rg, string mae, string pai)
        {

            LocatarioFacade.Insert(nome, vlAluguel, vlCalcao, statusCalcao, diaPagamento,
                      email, celular, fkCasa, fkQuarto, debito, credito, dtNascimento,
                      sexo, observacao, statusPagamento, cpf, rg, mae, pai);
        }

        public static void Delete(int idReferencia)
        {
            LocatarioFacade.Delete(idReferencia);
        }

        public static void Update(string idReferencia, string nome, string novoAluguel, string novoCalcao, string novoStatusCalcao,
                                  string novoDtPagamento, string novoEmail, string novoCelular, string fkCasa, string fkQuarto,
                                  string debito, string credito, string dtNascimento, string sexo, string statusPagamento,
                                  string novoObservacao, string cpf, string rg, string pai, string mae)
        {
            LocatarioFacade.Update(idReferencia, nome, novoAluguel, novoCalcao, novoStatusCalcao,
                                   novoDtPagamento, novoEmail, novoCelular, fkCasa, fkQuarto,
                                   debito, credito, dtNascimento, sexo, statusPagamento,
                                   novoObservacao, cpf, rg, mae, pai);
        }

        public static List<Locatario> QueryAll(string id, string nome, string vlAluguel, string vlCalcao, string statusCalcao, string diaPagamento,
                                               string fkCasa, string fkQuarto, string sexo, string statusPagamento)
        {
            return LocatarioFacade.QueryAll(id, nome, vlAluguel, vlCalcao, statusCalcao, diaPagamento, fkCasa, fkQuarto, sexo, statusPagamento);
        }

        #endregion
    }
}
