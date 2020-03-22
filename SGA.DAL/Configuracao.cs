using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

namespace SGA.DAL
{
    public class Configuracao
    {
        public static string SqlInstance { get; set; }
        public string DiretorioBaseAplicacao { get; set; }
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString; } }

        public Configuracao(string instanciaSql, string diretorioBaseAplicacao)
        {
            SqlInstance = instanciaSql;
            DiretorioBaseAplicacao = diretorioBaseAplicacao;
        }

        public static bool IsSystemReady()
        {
            string local = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;

            if (string.IsNullOrEmpty(local))
                return false;
            else
                return true;
        }

        public static string ReturnDocDirectory()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine($"SELECT TOP 1 DiretorioBaseAplicacao FROM [DBSGA01].[dbo].[Configuracao]");

                connection.Open();
                string destinoContrato = connection.ExecuteScalar<string>(cmd.ToString());
                connection.Close();

                return destinoContrato;
            }
        }


        public void ConfigureFilePaths()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine($"INSERT INTO [DBSGA01].[dbo].[Configuracao] VALUES('{DiretorioBaseAplicacao}')");

                conn.Open();
                conn.Execute(str.ToString());
                conn.Close();
            }
        }

        public void ConfigureConnectionString()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            connectionStringsSection.ConnectionStrings["LocalConnection"].ConnectionString = $"Data Source={SqlInstance}; Initial Catalog=DBSGA01;Integrated Security=true";

            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static KeyValuePair<string, string> ReturnDeveloperCredentials()
        {
            AppSettingsReader appSettings = new AppSettingsReader();

            string developer = appSettings.GetValue("Developer", typeof(String)).ToString();
            string password = appSettings.GetValue("Password", typeof(string)).ToString();

            KeyValuePair<string, string> user = new KeyValuePair<string, string>(developer, password);

            return user;
        }

        public bool ConnectionTest()
        {
            string conTest = $"Data Source={SqlInstance}; Initial Catalog=DBSGA01;Integrated Security=true";

            using (var connection = new SqlConnection(conTest))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
