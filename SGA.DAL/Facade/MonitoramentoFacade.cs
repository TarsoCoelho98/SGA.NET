using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.DAL.Facade
{
    public class MonitoramentoFacade
    {
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString; } }

        public static void InserirEnvioEmailAniversario()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string currentDate = DateTime.Now.Date.ToString("yyyy-MM-dd");

                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine($"INSERT INTO [DBSGA01].[dbo].[MonitoriaEmailAniversario] VALUES ('{currentDate}')");
                
                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static bool EmailAniversarioEnviadoDataAtual()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string currentDate = DateTime.Now.Date.ToString("yyyy-MM-dd");

                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine($"SELECT TOP 1 IdEmailAniversario FROM [DBSGA01].[dbo].[MonitoriaEmailAniversario] WHERE DataEmailAniversario = '{currentDate}'");

                connection.Open();
                int? result = connection.ExecuteScalar<int>(cmd.ToString());
                connection.Close();

                if (result.Equals(null) || result.Equals(0))
                    return false;
                else
                    return true;
            }
        }     
    }
}
