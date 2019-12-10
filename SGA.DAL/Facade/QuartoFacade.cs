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
    public class QuartoFacade
    {
        private static string srtConnection = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

        #region Changes 

        public static void Insert(double vlAluguel, double vlCalcao, int fkCasa, string status, string observacao)
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("INSERT INTO [DBSGA01].[dbo].[Quarto](vlAluguel, vlCalcao, FkCasa, Status, Observacao) VALUES");
                cmd.AppendLine($" ({vlAluguel}, {vlCalcao}, {fkCasa}, {status}, '{observacao}'");

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
                cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Quarto] WHERE IdCasa = {id}");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static void Update(int idReferencia, double vlAluguel, double vlCalcao, int novoFKCasa, string novoStatus, string novoObservacao)
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                string separator = string.Empty;

                StringBuilder cmd = new StringBuilder();
                cmd.Append("UPDATE [DBSGA].[dbo].[Quarto] SET");

                if (!vlAluguel.Equals(0))
                {
                    cmd.AppendLine($" VlAluguel = '{vlAluguel}'");
                    separator = ",";
                }
                if (!vlCalcao.Equals(0))
                {
                    cmd.AppendLine($"{separator} VlCalcao = '{vlCalcao}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!novoFKCasa.Equals(0))
                {
                    cmd.AppendLine($"{separator} FkCasa = {novoFKCasa},");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (string.IsNullOrEmpty(novoStatus))
                {
                    cmd.AppendLine($"{separator} Status = {novoStatus}");
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

        public static List<Quarto> QueryAll(int idQuarto, double vlAluguel, double vlCalcao, int fkCasa, string status)
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT [IdQuarto] AS [Código], [VlAluguel] AS [Aluguel], [vlCalcao] AS [Calcao],");
                cmd.AppendLine(" [FkCasa] AS [Casa], [FkStatus] AS [Status]");
                cmd.AppendLine(" FROM [DBSGA01].[dbo].[Quarto] WHERE 1 = 1");

                if (!idQuarto.Equals(0)) cmd.AppendLine($" AND IdQuarto = {idQuarto}");
                if (!vlAluguel.Equals(0)) cmd.Append($" AND VlAluguel = {vlAluguel}");
                if (!vlCalcao.Equals(0)) cmd.AppendLine($" AND VlCalcao = {vlCalcao}");
                if (!fkCasa.Equals(0)) cmd.AppendLine($" AND FkCasa = {fkCasa}");
                if (!string.IsNullOrEmpty(status)) cmd.AppendLine($" AND Status = {status}");

                connection.Open();
                var lst = connection.Query<Quarto>(cmd.ToString()).ToList();
                connection.Close();

                return lst;
            }
        }

        #endregion




    }
}
