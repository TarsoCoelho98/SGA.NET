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
using SGA.DAL.Enums;
using System.Globalization;

namespace SGA.DAL.Facade
{
    public class QuartoFacade
    {
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString; } }


        #region Changes 

        public static void Insert(string aluguel, string calcao, string casa, string status, string observacao)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (string.IsNullOrEmpty(calcao))
                    calcao = "null";
                              
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("INSERT INTO [DBSGA01].[dbo].[Quarto](vlAluguel, vlCalcao, FkCasa, [Status], Observacao) VALUES");
                cmd.AppendLine($" ({aluguel}, {calcao}, {casa}, '{status}', '{observacao}')");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static void Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Quarto] WHERE IdQuarto = {id}");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static void Update(int idReferencia, string vlAluguel, string vlCalcao, string novoFkCasa, string novoStatus, string novoObservacao)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string separator = string.Empty;

                StringBuilder cmd = new StringBuilder();
                cmd.Append("UPDATE [DBSGA01].[dbo].[Quarto] SET");

                if (!string.IsNullOrEmpty(vlAluguel))
                {
                    decimal aluguel = Convert.ToDecimal(vlAluguel, CultureInfo.InvariantCulture);
                    string aluguelFilter = $" VlAluguel = {aluguel}".Replace(",", ".");
                    cmd.AppendLine(aluguelFilter);
                    separator = ",";
                }
                if (!string.IsNullOrEmpty(vlCalcao))
                {
                    decimal calcao = Convert.ToDecimal(vlCalcao, CultureInfo.InvariantCulture);
                    string calcaoFilter = $"{separator}" + $" VlCalcao = {calcao}".Replace(",", ".");
                    cmd.AppendLine(calcaoFilter);
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(novoFkCasa))
                {
                    int casa = Convert.ToInt32(novoFkCasa);
                    cmd.AppendLine($"{separator} FkCasa = {casa}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(novoStatus))
                {
                    cmd.AppendLine($"{separator} [Status] = '{novoStatus}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoObservacao))
                    cmd.AppendLine($"{separator} Observacao = '{novoObservacao}'");

                cmd.AppendLine($" WHERE IdQuarto = {idReferencia}");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        #endregion

        #region Queries 

        public static List<Quarto> QueryAll(string idQuarto, string vlAluguel, string vlCalcao, string fkCasa, string status)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT [IdQuarto], [VlAluguel], [VlCalcao],");
                cmd.AppendLine(" [FkCasa], [Status], [Observacao]");
                cmd.AppendLine(" FROM [DBSGA01].[dbo].[Quarto] WHERE 1 = 1");

                if (!string.IsNullOrEmpty(idQuarto))
                {
                    int quarto = Convert.ToInt32(idQuarto);
                    cmd.AppendLine($" AND IdQuarto = {quarto}");
                }
                if (!string.IsNullOrEmpty(vlAluguel))
                {
                    decimal aluguel = Convert.ToDecimal(vlAluguel, CultureInfo.InvariantCulture);
                    string aluguelFilter = $" AND VlAluguel = {aluguel}".Replace(",", ".");
                    cmd.Append(aluguelFilter);
                }      
                if (!string.IsNullOrEmpty(vlCalcao))
                {
                    decimal? calcao = Convert.ToDecimal(vlCalcao, CultureInfo.InvariantCulture);
                    string calcaoFilter = $" AND VlCalcao = {vlCalcao}".Replace(",", ".");
                    cmd.AppendLine(calcaoFilter);
                }
                if (!string.IsNullOrEmpty(fkCasa))
                {
                    int casa = Convert.ToInt32(fkCasa);
                    cmd.AppendLine($" AND FkCasa = {casa}");
                }
                if (!string.IsNullOrEmpty(status))
                    cmd.AppendLine($" AND Status = '{status}'");

                connection.Open();
                var lst = connection.Query<Quarto>(cmd.ToString()).ToList();
                connection.Close();

                return lst;
            }
        }
   
        #endregion  
    }
}
