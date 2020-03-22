using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SGA.DAL.Entity;

namespace SGA.DAL.Facade
{
    public class UsuarioFacade
    {
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString; } }

        public static bool UserExits(string racf, string password)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT TOP 1 IdUsuario FROM [DBSGA01].[dbo].[Usuario]");
                cmd.AppendLine($"WHERE Racf = '{racf}'");
                cmd.AppendLine($"AND Senha = '{password}'");

                connection.Open();
                int ret = connection.ExecuteScalar<int>(cmd.ToString());

                if (ret.Equals(null) || ret.Equals(0))
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;
                }
            }
        }

        public static Usuario UserData(string racf)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT TOP 1 * FROM [DBSGA01].[dbo].[Usuario]");
                cmd.AppendLine($" WHERE Racf = '{racf}'");

                connection.Open();
                var lst = connection.Query<Usuario>(cmd.ToString()).ToList();
                connection.Close();

                return lst.First();
            }
        }


        public static void Insert(string nome, string email, string racf, string senha, string rua, string bairro,
                                  string numero, string cpf, string rg, string senhaEmail)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("INSERT INTO [DBSGA01].[dbo].[Usuario](Racf, Email, Senha, Nome, Bairro, Rua, CasaNumero, Cpf, Rg, SenhaEmail) VALUES");
                cmd.AppendLine($" ('{racf}', '{email}', '{senha}', '{nome}', '{bairro}', '{rua}', {numero}, '{cpf}', '{rg}', '{senhaEmail}')");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }

        public static void Update(string racfReferencia, string email, string nome, string senha, string rua, string bairro, string numero, string cpf, string rg, string emailSenha)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                string separator = string.Empty;

                StringBuilder cmd = new StringBuilder();
                cmd.Append("UPDATE [DBSGA01].[dbo].[Usuario] SET");

                if (!string.IsNullOrEmpty(nome))
                {
                    cmd.AppendLine($" Nome = '{nome}'");
                    separator = ",";
                }
                if (!string.IsNullOrEmpty(email))
                {
                    cmd.AppendLine($"{separator} Email = '{email}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(senha))
                {
                    cmd.AppendLine($"{separator} Senha = '{senha}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(rua))
                {
                    cmd.AppendLine($"{separator} Rua = '{rua}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(bairro))
                {
                    cmd.AppendLine($"{separator} Bairro = '{bairro}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(numero))
                {
                    cmd.AppendLine($"{separator} CasaNumero = {numero}");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(cpf))
                {
                    cmd.AppendLine($"{separator} Cpf = '{cpf}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(emailSenha))
                {
                    cmd.AppendLine($"{separator} SenhaEmail = '{emailSenha}'");
                    if (string.IsNullOrEmpty(separator))
                        separator = ",";
                }
                if (!string.IsNullOrEmpty(rg))
                    cmd.AppendLine($"{separator} Rg = '{rg}'");

                cmd.AppendLine($" WHERE Racf = '{racfReferencia}'");

                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();
            }
        }


        public static bool IsDeveloperAcess(string racf, string password)
        {
            KeyValuePair<string, string> credentials = Configuracao.ReturnDeveloperCredentials();

            if (credentials.Key.Equals(racf) && credentials.Value.Equals(password))
                return true;
            else
                return false;
        }


        public static bool UserAlreadyExists(string racf)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT TOP 1 IdUsuario FROM [DBSGA01].[dbo].[Usuario]");
                cmd.AppendLine($"WHERE Racf = '{racf}'");

                connection.Open();
                int ret = connection.ExecuteScalar<int>(cmd.ToString());
                connection.Close();

                if (ret.Equals(null) || ret.Equals(0))
                    return false;
                else
                    return true;
            }
        }

        public static KeyValuePair<string, string> UserEmailCredentials(string racf)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT TOP 1 * FROM [DBSGA01].[dbo].[Usuario]");
                cmd.AppendLine($"WHERE Racf = '{racf}'");

                connection.Open();
                Usuario ret = connection.ExecuteScalar<Usuario>(cmd.ToString());
                connection.Close();

                return new KeyValuePair<string, string>(ret.Email, ret.SenhaEmail);
            }

        }

    }
}
