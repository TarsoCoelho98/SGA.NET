using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SGA.DAL.Entity;
using System.Configuration;
using Dapper;


namespace SGA.DAL.Facade
{
    public class LocatarioFacade
    {
        private static string srtConnection = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

        #region Changes 

        public static void Insert(string nome, double vlAluguel, double vlCalcao, string statusCalcao, DateTime dtPagamento, 
                                  string email, long celular, int fkCasa, int fkQuarto, double debito, double credito, DateTime dtNascimento, 
                                  char sexo, string observacao)
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("INSERT INTO [DBSGA01].[dbo].[Locatario](Nome, VlAluguel, VlCalcao, StatusCalcao,");
                cmd.AppendLine(" DtPagamento, Email, Celular, FkCasa, FkQuarto, Debito, Credito, DtNascimento, Sexo, Observacao) VALUES");
                cmd.AppendLine($" ('{nome}', {vlAluguel}, {vlCalcao}, '{statusCalcao}', {dtPagamento}, '{email}', {celular}");
                cmd.AppendLine($" {fkCasa}, {fkQuarto}, {debito}, {credito}, {dtNascimento}, '{sexo}', '{observacao}'");

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
                cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Locatario] WHERE IdLocatario = {id}");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static void Update(int idReferencia, string nome, double novoAluguel, double novoCalcao, string novoStatusCalcao, 
                                  DateTime novoDtPagamento, string novoEmail, long novoCelular, int fkCasa, int fkQuarto, 
                                  double debito, double credito, string novoObservacao )
        {
            using (var connection = new SqlConnection(srtConnection))
            {
                string separator = string.Empty;

                StringBuilder cmd = new StringBuilder();
                cmd.Append("UPDATE [DBSGA].[dbo].[Locatario] SET");

                if (!string.IsNullOrEmpty(nome))
                {
                    cmd.AppendLine($" Nome = '{nome}'");
                    separator = ",";
                }
                if (!novoAluguel.Equals(0))
                {
                    cmd.AppendLine($"{separator} VlAluguel = '{novoAluguel}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!novoCalcao.Equals(0))
                {
                    cmd.AppendLine($"{separator} VlCalcao = {novoCalcao},");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoStatusCalcao))
                {
                    cmd.AppendLine($"{separator} StatusCalcao = {novoStatusCalcao}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoDtPagamento.ToString()))
                {
                    cmd.AppendLine($"{separator} DtPagamento = {novoDtPagamento}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoEmail))
                {
                    cmd.AppendLine($"{separator} Email = {novoEmail}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!novoCelular.Equals(0))
                {
                    cmd.AppendLine($"{separator} Celular = {novoCelular}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!fkCasa.Equals(0))
                {
                    cmd.AppendLine($"{separator} FkCasa = {fkCasa}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!fkQuarto.Equals(0))
                {
                    cmd.AppendLine($"{separator} Quarto = {fkQuarto}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if(!debito.Equals(0))
                {
                    cmd.AppendLine($"{separator} Debito = {debito}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!credito.Equals(0))
                {
                    cmd.AppendLine($"{separator} Credito = {credito}");
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

        public static List<Locatario> QueryAll(string nome, double vlAluguel, double vlCalcao, string statusCalcao, DateTime dtPagamento,
                                               int fkCasa, int fkQuarto, char sexo)
        { 
            using (var connection = new SqlConnection(srtConnection))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT [Nome], [VlAluguel] AS Aluguel, [VlCalcao] AS Calcao, [StatusCalcao] AS [Status do Calção],");
                cmd.AppendLine(" FORMAT([dtPagamento], 'MM/yyyy', 'pt-BR') AS [Data de Pagamento], [Email], [Celular],");
                cmd.AppendLine("  CONCAT([FkCasa], ' - ', [FkQuarto]) AS [Localização (Casa - Quarto)],");
                cmd.AppendLine(" ROUND([Debito], 2) AS [Debito], ROUND([Credito], 2) AS [Credito],");
                cmd.AppendLine(" FORMAT([dtNascimento], 'MM/yyyy', 'pt-BR') AS [Data de Nascimento], [Sexo], [Observacao]");
                cmd.AppendLine(" FROM [DBSGA01].[dbo].[Locatario] WHERE 1 = 1");

                if (!string.IsNullOrEmpty(nome))
                    cmd.AppendLine($" AND Nome LIKE(%{nome}%)");
                if (!vlAluguel.Equals(0))
                    cmd.AppendLine($" AND VlAluguel = {vlAluguel}");
                if (!vlCalcao.Equals(0))
                    cmd.AppendLine($" AND VlCalcao = {vlCalcao}");
                if (string.IsNullOrEmpty(statusCalcao))
                    cmd.AppendLine($" AND StatusCalcao = '{statusCalcao}'");
                if (!string.IsNullOrEmpty(dtPagamento.ToString()))
                    cmd.AppendLine($" AND DtPagamento = dtPagamento");
                if (!fkCasa.Equals(0))
                    cmd.AppendLine($" AND FkCasa = {fkCasa}");

                connection.Open();
                var lst = connection.Query<Locatario>(cmd.ToString()).ToList();
                connection.Close();

                return lst;
            }
        }

        #endregion
    } 
}
