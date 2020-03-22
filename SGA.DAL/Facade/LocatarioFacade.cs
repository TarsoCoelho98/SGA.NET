using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SGA.DAL.Entity;
using System.Configuration;
using Dapper;
using System.Globalization;
using System.Net.Mail;
using System.Net;

namespace SGA.DAL.Facade
{
    public class LocatarioFacade
    {
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString; } }
        

        #region Changes 

        public static void Insert(string nome, string vlAluguel, string vlCalcao, string statusCalcao, string diaPagamento,
                                  string email, string celular, string fkCasa, string fkQuarto, string debito, string credito, string dtNascimento,
                                  string sexo, string observacao, string statusPagamento, string cpf, string rg, string mae, string pai)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (string.IsNullOrEmpty(vlCalcao))
                    vlCalcao = "null";
                if (string.IsNullOrEmpty(debito))
                    debito = "null";
                if (string.IsNullOrEmpty(credito))
                    credito = "null";
                if (string.IsNullOrEmpty(celular))
                    celular = "null";
                if (string.IsNullOrWhiteSpace(dtNascimento.Replace('/', ' ')))
                    dtNascimento = string.Empty;

                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("INSERT INTO [DBSGA01].[dbo].[Locatario](Nome, VlAluguel, VlCalcao, StatusCalcao,");
                cmd.AppendLine(" DiaPagamento, Email, Celular, FkCasa, FkQuarto, Debito, Credito, DtNascimento, Sexo, Observacao," +
                               " StatusPagamento, Cpf, Rg, NomeMae, NomePai) VALUES");
                cmd.AppendLine($" ('{nome}', {vlAluguel}, {vlCalcao}, '{statusCalcao}', {diaPagamento}, '{email}', {celular},");
                cmd.AppendLine($" {fkCasa}, {fkQuarto}, {debito}, {credito}, '{dtNascimento}', '{sexo}', '{observacao}', " +
                               $"'{statusPagamento}', '{cpf}', '{rg}', '{mae}', '{pai}')");

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
                cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Locatario] WHERE IdLocatario = {id}");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static void Update(string idReferencia, string nome, string novoAluguel, string novoCalcao, string novoStatusCalcao,
                                  string novoDtPagamento, string novoEmail, string novoCelular, string fkCasa, string fkQuarto,
                                  string debito, string credito, string dtNascimento, string sexo, string statusPagamento, 
                                  string novoObservacao, string cpf, string rg, string pai, string mae)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string separator = string.Empty;

                StringBuilder cmd = new StringBuilder();
                cmd.Append("UPDATE [DBSGA01].[dbo].[Locatario] SET");

                if (!string.IsNullOrEmpty(nome))
                {
                    cmd.AppendLine($" Nome = '{nome}'");
                    separator = ",";
                }

                if (!string.IsNullOrEmpty(novoAluguel))
                {
                    decimal aluguel = Convert.ToDecimal(novoAluguel, CultureInfo.InvariantCulture);
                    string aluguelFilter = $"{separator}" + $" VlAluguel = {aluguel}".Replace(",", ".");
                    cmd.AppendLine(aluguelFilter);
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoCalcao))
                {
                    decimal calcao = Convert.ToDecimal(novoCalcao, CultureInfo.InvariantCulture);
                    string calcaoFilter = $"{separator}" + $" VlCalcao = {calcao}".Replace(",", ".");
                    cmd.AppendLine(calcaoFilter);
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoStatusCalcao))
                {
                    cmd.AppendLine($"{separator} StatusCalcao = '{novoStatusCalcao}'");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(cpf))
                {
                    cmd.AppendLine($"{separator} Cpf = '{cpf}'");

                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(rg))
                {
                    cmd.AppendLine($"{separator} Rg = '{rg}'");

                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(mae))
                {
                    cmd.AppendLine($"{separator} NomeMae = '{mae}'");

                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(pai))
                {
                    cmd.AppendLine($"{separator} NomePai = '{pai}'");

                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoDtPagamento))
                {
                    cmd.AppendLine($"{separator} DiaPagamento = {novoDtPagamento}");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoEmail))
                {
                    cmd.AppendLine($"{separator} Email = '{novoEmail}'");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoCelular))
                {
                    cmd.AppendLine($"{separator} Celular = {novoCelular}");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(fkCasa))
                {
                    int casa = Convert.ToInt32(fkCasa);
                    cmd.AppendLine($"{separator} FkCasa = {casa}");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(fkQuarto))
                {
                    int quarto = Convert.ToInt32(fkQuarto);
                    cmd.AppendLine($"{separator} FkQuarto = {fkQuarto}");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(credito))
                {
                    decimal vlCredito = Convert.ToDecimal(credito, CultureInfo.InvariantCulture);
                    string creditoFilter = $"{separator}" + $" Credito = {vlCredito}".Replace(",", ".");
                    cmd.AppendLine(creditoFilter);
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(debito))
                {
                    decimal vlDebito = Convert.ToDecimal(debito, CultureInfo.InvariantCulture);
                    string debitoFilter = $"{separator}" + $" Debito = {vlDebito}".Replace(",", ".");
                    cmd.AppendLine(debitoFilter);
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrWhiteSpace(dtNascimento.Replace('/', ' ')))
                {
                    cmd.AppendLine($"{separator} DtNascimento = '{dtNascimento}'");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(sexo))
                {
                    cmd.AppendLine($"{separator} Sexo = '{sexo}'");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(statusPagamento))
                {
                    cmd.AppendLine($"{separator} StatusPagamento = '{statusPagamento}'");
                    
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoObservacao))
                    cmd.AppendLine($"{separator} Observacao = '{novoObservacao}'");

                cmd.AppendLine($" WHERE IdLocatario = {idReferencia}");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        #endregion

        #region Queries 

        public static List<Locatario> QueryAll(string id, string nome, string vlAluguel, string vlCalcao, string statusCalcao, string diaPagamento,
                                               string fkCasa, string fkQuarto, string sexo, string statusPagamento)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = SqlLocatarioQuery();
                cmd.AppendLine(" FROM [DBSGA01].[dbo].[Locatario] WHERE 1 = 1");

                if (!string.IsNullOrEmpty(id))
                {
                    int loc = Convert.ToInt32(id);
                    cmd.AppendLine($" AND IdLocatario = {loc}");
                }
                if (!string.IsNullOrEmpty(nome))
                    cmd.AppendLine($" AND Nome LIKE ('%{nome}%')");
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
                if (!string.IsNullOrEmpty(statusCalcao))
                    cmd.AppendLine($" AND StatusCalcao = '{statusCalcao}'");
                if (!string.IsNullOrEmpty(diaPagamento))
                {
                    int dia = Convert.ToInt32(diaPagamento);
                    cmd.AppendLine($" AND DiaPagamento = {dia}");
                }
                if (!string.IsNullOrEmpty(fkCasa))
                {
                    int casa = Convert.ToInt32(fkCasa);
                    cmd.AppendLine($" AND FkCasa = {casa}");
                }
                if (!string.IsNullOrEmpty(fkQuarto))
                {
                    int quarto = Convert.ToInt32(fkQuarto);
                    cmd.AppendLine($" AND FkQuarto = {quarto}");
                }
                if (!string.IsNullOrEmpty(sexo))
                {
                    cmd.AppendLine($" AND Sexo = '{sexo}'");
                }
                if (!string.IsNullOrEmpty(statusPagamento))
                {
                    cmd.AppendLine($" AND StatusPagamento = '{statusPagamento}'");
                }
                connection.Open();
                var lst = connection.Query<Locatario>(cmd.ToString()).ToList();
                connection.Close();

                return lst;
            }
        }

        #endregion

        public static StringBuilder SqlLocatarioQuery()
        {
            StringBuilder cmd = new StringBuilder();
            cmd.AppendLine("SELECT [IdLocatario], [Nome], [VlAluguel], [VlCalcao], [StatusCalcao],");
            cmd.AppendLine(" CONCAT(CAST([DiaPagamento] AS VARCHAR(2)), '/', CAST(DATEPART(MONTH, GETDATE()) AS VARCHAR), '/', CAST(DATEPART(YEAR, GETDATE()) AS VARCHAR)) AS [DiaPagamento], [Email],");
            cmd.AppendLine(" IIF(Celular is not null, CONCAT('(', SUBSTRING(CONVERT(VARCHAR, Celular), 1, 2), ') ', SUBSTRING(CONVERT(VARCHAR, Celular), 3, 5), '-',");
            cmd.AppendLine(" SUBSTRING(CONVERT(VARCHAR, Celular), 6, 4)), null) AS [Celular],");
            cmd.AppendLine(" [FkCasa], [FkQuarto],");
            cmd.AppendLine(" [Debito], [Credito],");
            cmd.AppendLine(" [DtNascimento], [Sexo], [Observacao], [StatusPagamento],");
            cmd.AppendLine(" [NomeMae], [NomePai],");
            cmd.AppendLine(" CONCAT(SUBSTRING(Cpf, 1, 3), '.', SUBSTRING(Cpf, 4, 3), '.', SUBSTRING(Cpf, 7, 3), '-', SUBSTRING(Cpf, 10, 2)) AS [Cpf], [Rg]");

            return cmd;
        }

        public static Locatario LocatarioData(string nome, string cpf)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = SqlLocatarioQuery();            
                cmd.AppendLine($" FROM [DBSGA01].[dbo].[Locatario] WHERE Nome = '{nome}' AND Cpf = '{cpf}'");

                connection.Open();
                var lst = connection.Query<Locatario>(cmd.ToString()).ToList();                
                connection.Close();

                return lst.First();
            }
        }
    }
}
