using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace SGA.DAL
{
    public class GeneralMethods
    {
        public static string Data { get { return "DBSGA01"; } }
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString; } }

        public static bool StringVerify(string word)
        {
            char[] notAllowed = new char[] {'-', '/', ':', ';', '?', '^', '´', '`', '+', '-', '|', '|', '!',
                                            '@', '#', '$', '%', '¨', '&', '*', '(', ')', '=', '§', 'º', '"',
                                            '{', '[', 'ª', '}', ']', '°'};

            foreach (char element in notAllowed)
            {
                if (word.Contains(element))
                    return false;
            }
            return true;
        }

        public static List<string> EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T não é um tipo enumerado");

            List<string> lst = new List<string>();
            Type typ = typeof(T);

            if (typ != null)
            {
                Array enumValues = Enum.GetNames(typ);
                foreach (string name in enumValues)
                {
                    lst.Add(name);
                }
            }
            return lst;
        }

        public static void DeleteAllForeignKeyReferences(string table, int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                if (table.Equals("Casa"))
                {
                    StringBuilder cmd = new StringBuilder();
                    cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Locatario] WHERE FkCasa = {id}");
                    connection.Open();
                    connection.Execute(cmd.ToString());

                    cmd.Clear();
                    cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Quarto] WHERE FkCasa = {id}");
                    connection.Execute(cmd.ToString());
                    connection.Close();
                }
                else if (table.Equals("Quarto"))
                {
                    StringBuilder cmd = new StringBuilder();
                    cmd.AppendLine($"DELETE FROM [DBSGA01].[dbo].[Locatario] WHERE FkQuarto = {id}");
                    connection.Open();
                    connection.Execute(cmd.ToString());
                    connection.Close();
                }
            }
        }

        public static List<int> ForeignKeyValuesList(string table)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                List<int> values = new List<int>();
                StringBuilder cmd = new StringBuilder();

                if (table.Equals("Casa"))
                {
                    cmd.AppendLine("SELECT [IdCasa] FROM [DBSGA01].[dbo].[Casa]");

                    connection.Open();
                    var lst = connection.Query<int>(cmd.ToString()).ToList();
                    connection.Close();

                    return lst;
                }
                else if (table.Equals("Quarto"))
                {
                    cmd.AppendLine("SELECT [IdQuarto] FROM [DBSGA01].[dbo].[Quarto]");

                    connection.Open();
                    var lst = connection.Query<int>(cmd.ToString()).ToList();
                    connection.Close();

                    return lst;
                }
                else
                    throw new Exception($"Não há nenhuma tabela de nome {table} em {Data}");
            }
        }

        public static void ResetPaymentStatus()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine($"UPDATE [DBSGA01].[dbo].[Locatario] SET StatusPagamento = 'Receber' WHERE StatusPagamento = 'Pago'");
                connection.Open();
                connection.Execute(cmd.ToString());
                connection.Close();

            }
        }

        public static decimal MonthCashFlow()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT CONVERT(DECIMAL(18,2), SUM(VlAluguel)) FROM [DBSGA01].[dbo].[Locatario]");

                connection.Open();
                decimal ret = connection.ExecuteScalar<decimal>(cmd.ToString());
                connection.Close();

                return ret;
            }
        }


        public static decimal CashFlowPerDate(int begin, int finish)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine($"SELECT ISNULL(CONVERT(DECIMAL(18,2), SUM(VlAluguel)), 0) FROM[DBSGA01].[dbo].[Locatario] WHERE(DiaPagamento BETWEEN {begin} AND {finish})  " +
                                "AND(StatusPagamento = 'Devendo' OR StatusPagamento = 'Receber')");

                connection.Open();
                decimal ret = connection.ExecuteScalar<decimal>(cmd.ToString());
                connection.Close();

                return ret;
            }
        }

        public static decimal YearCashFlow()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendLine("SELECT CONVERT(DECIMAL(18,2), SUM(VlAluguel)) * 12 FROM [DBSGA01].[dbo].[Locatario]");

                connection.Open();
                decimal ret = connection.ExecuteScalar<decimal>(cmd.ToString());
                connection.Close();

                return ret;
            }
        }

        public static KeyValuePair<bool, string> ExtractToExcel(DataGridView grid)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();

            try
            {
                if (grid.Rows.Count > 0)
                {
                    xcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < grid.Columns.Count + 1; i++)
                    {
                        string header = grid.Columns[i - 1].HeaderText;

                        if (header.Equals("Editar") || header.Equals("Remover") || header.Equals("E-mail Cobrança"))
                            continue;

                        xcelApp.Cells[1, i] = header;
                    }

                    for (int i = 0; i <= grid.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < grid.Columns.Count; j++)
                        {
                            string formatDataHora = "d";

                            if (grid.Rows[i].Cells[j].Value == null)
                                continue;

                            if (grid.Rows[i].Cells[j].Value.Equals("Editar") || grid.Rows[i].Cells[j].Value.Equals("Remover"))
                                continue;

                            if (grid.Rows[i].Cells[j].OwningColumn.HeaderText == "E-mail Cobrança")
                                continue;

                            if (grid.Rows[i].Cells[j].OwningColumn.DefaultCellStyle.Format.Equals(formatDataHora)
                                || grid.Rows[i].Cells[j].OwningColumn.DefaultCellStyle.Format.Equals(formatDataHora.ToUpper()))
                            {
                                DateTime value = Convert.ToDateTime(grid.Rows[i].Cells[j].Value);
                                xcelApp.Cells[i + 2, j + 1] = value;
                            }
                            else
                            {
                                var value = grid.Rows[i].Cells[j].Value;
                                xcelApp.Cells[i + 2, j + 1] = value;
                            }
                        }
                    }

                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                }

                return new KeyValuePair<bool, string>(true, string.Empty);
            }
            catch (Exception e)
            {
                xcelApp.Quit();

                return new KeyValuePair<bool, string>(false, e.Message);
            }
        }


        public static string FindExtensiveNumber(int value, string separator)
        {
            if (value < 20)
            {
                return ReturnStringValue(value);
            }

            if (value > 19)
            {
                int len = value.ToString().Length;

                if (len == 2)
                {
                    int valorPrimario = int.Parse(value.ToString().Substring(0, 1));
                    int valorSecundario = int.Parse(value.ToString().Substring(1, 1));
                    valorPrimario = valorPrimario * 10;
                    return ReturnStringValue(valorPrimario) + (valorSecundario > 0 ? separator + ReturnStringValue(valorSecundario) : "");
                }
                else if (len == 3)
                {
                    int valorPrimario = int.Parse(value.ToString().Substring(0, 1));
                    int valorSecundario = int.Parse(value.ToString().Substring(1, 1));
                    int valorTerciario = int.Parse(value.ToString().Substring(2, 1));

                    valorPrimario = valorPrimario * 100;
                    valorSecundario = valorSecundario * 10;


                    return ReturnStringValue(valorPrimario)
                                      + (valorSecundario > 0 ? separator + ReturnStringValue(valorSecundario) : "")
                                      + (valorTerciario > 0 ? separator + ReturnStringValue(valorTerciario) : "");
                }
                else
                    return "Valor inválido";
            }
            else
                return "Valor inválido";

        }

        public static string ReturnStringValue(int identifier)
        {
            switch (identifier)
            {
                case 1: return "Um";
                case 2: return "Dois";
                case 3: return "Tres";
                case 4: return "Quatro";
                case 5: return "Cinco";
                case 6: return "Seis";
                case 7: return "Sete";
                case 8: return "Oito";
                case 9: return "Nove";

                case 10: return "Dez";
                case 11: return "Onze";
                case 12: return "Doze";
                case 13: return "Treze";
                case 14: return "Quatorze";
                case 15: return "Quinze";
                case 16: return "Dezesseis";
                case 17: return "Dezessete";
                case 18: return "Dezoito";
                case 19: return "Dezenove";

                case 20: return "Vinte";
                case 30: return "Trinta";
                case 40: return "Quarenta";
                case 50: return "Cinquenta";
                case 60: return "Sessenta";
                case 70: return "Setenta";
                case 80: return "Oitenta";
                case 90: return "Noventa";

                case 100: return "Cem";
                case 200: return "Duzentos";
                case 300: return "Trezentos";
                case 400: return "Quatrocentos";
                case 500: return "Quinhentos";
                case 600: return "Seicentos";
                case 700: return "Setecentos";
                case 800: return "Oitocentos";
                case 900: return "Novecentos";

                default: return "Valor inválido";
            }
        }
    }
}
