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
using System.Globalization;

namespace SGA.DAL.Facade
{
    public class CasaFacade
    {
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString; } }

        #region Changes 

        public static void Insert(string rua, string bairro, int numero, long cEP, string observacao, string cidade)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("INSERT INTO [DBSGA01].[dbo].[Casa](Rua, Bairro, Numero, CEP, Observacao, Cidade) VALUES");
                cmd.AppendLine($" ('{rua}', '{bairro}', {numero}, {cEP}, '{observacao}', '{cidade}')");

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
                cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Casa] WHERE IdCasa = {id}");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static void Update(int idReferencia, string novoRua, string novoBairro, string novoNumero, string novoCep, string novoObservacao, string cidade)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string separator = string.Empty; 

                StringBuilder cmd = new StringBuilder();
                cmd.Append("UPDATE [DBSGA01].[dbo].[Casa] SET");

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
                if (!string.IsNullOrEmpty(novoNumero))
                {
                    long numero = Convert.ToInt64(novoNumero);
                    cmd.AppendLine($"{separator} Numero = {numero}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(novoCep))
                {
                    long cep = Convert.ToInt64(novoCep);
                    cmd.AppendLine($"{separator} CEP = {cep}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(cidade))
                {
                    cmd.AppendLine($"{separator} Cidade = '{cidade}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }

                if (!string.IsNullOrEmpty(novoObservacao))
                    cmd.AppendLine($"{separator} Observacao = '{novoObservacao}'");

                cmd.AppendLine($" WHERE IdCasa = {idReferencia}");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        #endregion

        #region Queries 

        public static List<Casa> QueryAll(string idCasa, string cidade, string bairro, string cepString)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT [IdCasa], [Cidade], [Rua], [Bairro], [Numero],");
                cmd.AppendLine(" CONCAT(SUBSTRING(CONVERT(VARCHAR, CEP), 1, 5), '-', SUBSTRING(CONVERT(VARCHAR, CEP), 6, 3)) AS [CEP], [Observacao]");
                cmd.AppendLine(" FROM [DBSGA01].[dbo].[Casa] WHERE 1 = 1");

                if (!string.IsNullOrEmpty(idCasa))
                {
                    int casa = Convert.ToInt32(idCasa);
                    cmd.AppendLine($" AND IdCasa = {idCasa}");
                }
                if (!string.IsNullOrEmpty(cidade)) 
                    cmd.Append($" AND Cidade LIKE('%{cidade}%')");
                if (!string.IsNullOrEmpty(bairro)) 
                    cmd.AppendLine($" AND Bairro LIKE('%{bairro}%')");
                if (!string.IsNullOrEmpty(cepString))
                {
                    long cep = Convert.ToInt64(cepString);
                    cmd.AppendLine($" AND CEP = {cep}");
                }

                connection.Open();
                var lst = connection.Query<Casa>(cmd.ToString()).ToList();
                connection.Close();

                return lst;
            }
        }

        public static Casa CasaLocatario(int idCasa)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine($"SELECT TOP 1 * FROM Casa WHERE IdCasa = {idCasa}");

                connection.Open();
                var lst = connection.Query<Casa>(cmd.ToString()).ToList();
                connection.Close();

                return lst.First();
            }
        }

        #endregion
    }


}
