using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SGA.DAL.Entity;
using System.Data;
using System.Configuration;
using Dapper;

namespace SGA.DAL.Facade
{
    public class CasaFacade
    {
        private static string srtConnection = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
      
        #region Changes 

        public static void Insert(string rua, string bairro, int numero, long cEP, string observacao)
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("INSERT INTO [DBSGA01].[dbo].[Casa](Rua, Bairro, Numero, CEP, Observacao) VALUES");
                cmd.AppendLine($" ('{rua}', '{bairro}', {numero}, {cEP}, '{observacao}");

                connection.Open();
                connection.Execute(cmd.ToString()); 
                connection.Close();
            }
        }

        public static void Delete(int id)
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Casa] WHERE IdCasa = {id}");
                
                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static void Update(int idReferencia, string novoRua, string novoBairro, int novoNumero, long novoCEP, string novoObservacao)
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                string separator = string.Empty; 

                StringBuilder cmd = new StringBuilder();
                cmd.Append("UPDATE [DBSGA].[dbo].[Casa] SET");

                if (!string.IsNullOrEmpty(novoRua))
                {
                    cmd.AppendLine($" Rua = '{novoRua}'");
                    separator = ",";
                }
                if (!string.IsNullOrEmpty(novoBairro))
                {
                    cmd.AppendLine($"{separator} Bairro = '{novoBairro}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }  
                if (!novoNumero.Equals(0))
                {
                    cmd.AppendLine($"{separator} Numero = {novoNumero},");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!novoCEP.Equals(0))
                {
                    cmd.AppendLine($"{separator} CEP = {novoNumero}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
            
                if (!string.IsNullOrEmpty(novoObservacao))
                    cmd.AppendLine($"{separator} Observacao = {novoObservacao}");

                cmd.AppendLine($" WHERE IdCasa = {idReferencia}");
                               
                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        #endregion

        #region Queries 

        public static List<Casa> QueryAll(int idCasa, string rua, string bairro, int cep)
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                StringBuilder cmd = new StringBuilder();
               
                cmd.AppendLine("SELECT [IdCasa] AS [Código], [Rua], [Bairro], [Numero] AS [Número],");
                cmd.AppendLine(" CONCAT(SUBSTRING(CONVERT(VARCHAR, CEP), 1, 5), '-', SUBSTRING(CONVERT(VARCHAR, CEP), 6, 3)) AS [CEP], [Observacao]");
                cmd.AppendLine(" FROM [DBSGA01].[dbo].[Casa] WHERE 1 = 1");

                if (!idCasa.Equals(0)) cmd.AppendLine($" AND IdCasa = {idCasa}");
                if (!string.IsNullOrEmpty(rua)) cmd.Append($" AND Rua LIKE('%{rua}%')");
                if (!string.IsNullOrEmpty(bairro)) cmd.AppendLine($" AND Bairro LIKE('%{bairro}%')");
                if (!cep.Equals(0)) cmd.AppendLine($" AND CEP = {cep}");

                connection.Open();
                var lst = connection.Query<Casa>(cmd.ToString()).ToList();
                connection.Close();

                return lst;
            }
        }

        #endregion
    }


}
