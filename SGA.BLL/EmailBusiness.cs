using SGA.DAL.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGA.DAL.Entity;
using System.Globalization;
using System.IO;
using System.Windows;
using Microsoft.Office.Interop.Word;
using SGA.DAL;

namespace SGA.BLL
{
    public class EmailBusiness
    {

        public static string DiretorioBase { get { return Configuracao.ReturnDocDirectory(); } }
        public static string DiretorioContratoBase { get { return DiretorioBase + @"\CONTRATO_BASE\CONTRATO_LOCACAO.docx"; } }
        public static string DiretorioContratoFim { get { return DiretorioBase + @"\CONTRATOS"; } }


        public static bool EmailVerify(string email, string senha)
        {
            return EmailFacade.EmailVerify(email, senha);
        }

        public static void EmailCharge(string locador, string locatario, string emailLocatario, string userEmail, string userSenha)
        {
            EmailFacade.EmailCharge(locador, locatario, emailLocatario, userEmail, userSenha);
        }

        public static void EmailBirthday(string locador, string locatario, string emailLocatario, string userEmail, string userSenha)
        {
            EmailFacade.EmailBirthday(locador, locatario, emailLocatario, userEmail, userSenha);
        }

        public static string GenerateDocument(string racf, string nomeLocatarioBase, string locatarioCpf, Contrato contrato)
        {
            var repetitionKey = new List<string>() { "[NOMELOCADOR]", "[CPFLOCADOR]", "[RGLOCADOR]", "[NOMELOCATARIO]", "[CPFLOCATARIO]", "[RGLOCATARIO]" };
            var fieldList = new Dictionary<string, string>();
            
            Usuario user = UsuarioBusiness.UserData(racf);
            Locatario loc = LocatarioFacade.LocatarioData(nomeLocatarioBase, locatarioCpf);
            Casa casa = CasaFacade.CasaLocatario(loc.FkCasa);

            // Informações - Locador 

            fieldList.Add("[NOMELOCADOR]", user.Nome);
            fieldList.Add("[CPFLOCADOR]", user.Cpf);
            fieldList.Add("[RGLOCADOR]", user.Rg);
            fieldList.Add("[RUALOCADOR]", user.Rua);
            fieldList.Add("[CASALOCADOR]", user.CasaNumero.ToString());
            fieldList.Add("[BAIRROLOCADOR]", user.Bairro);

            // Informações - Locatário

            string diaPagamento = loc.DiaPagamento.Split('/')[0];
            string nomeLocatario = loc.Nome;
            fieldList.Add("[NOMELOCATARIO]", nomeLocatario);
            fieldList.Add("[CPFLOCATARIO]", loc.Cpf);
            fieldList.Add("[RGLOCATARIO]", loc.Rg);
            fieldList.Add("[ALUGUEL]", loc.VlAluguel.ToString("f2", CultureInfo.InvariantCulture));
            fieldList.Add("[ALUGUELEXTENSO]", CommonBusiness.EscreverExtenso(loc.VlAluguel));
            fieldList.Add("[DIAPAGAMENTO]", diaPagamento);
            fieldList.Add("[DIAPAGAMENTOEXTENSOORDINAL]", CommonBusiness.RetornarDiaMesOrdinal(Convert.ToInt32(diaPagamento)));

            // Informações - Contrato 

            fieldList.Add("[RUALOCACAO]", casa.Rua);
            fieldList.Add("[NUMEROLOCACAO]", casa.Numero.ToString());
            fieldList.Add("[BAIRROLOCACAO]", casa.Bairro);
            fieldList.Add("[CIDADELOCACAO]", casa.Cidade);

            // Informações Locatario - Domicílio de Origem

            fieldList.Add("[RUALOCATARIO]", contrato.Rua);
            fieldList.Add("[BAIRROLOCATARIO]", contrato.Bairro);
            fieldList.Add("[UFLOCATARIO]", contrato.UF);
            fieldList.Add("[CIDADELOCATARIO]", contrato.CidadeOrigemLocatario);

            // Informações Dados Deposito

            string numeroConta = contrato.Conta.ToString();
            string digitoConta = contrato.Digito.ToString();

            if (!string.IsNullOrEmpty(digitoConta))
                numeroConta = numeroConta + "-" + digitoConta;

            fieldList.Add("[CODIGOBANCO]", contrato.CodigoBanco.ToString());
            fieldList.Add("[NOMEBANCO]", contrato.NomeBanco);
            fieldList.Add("[AGENCIA]", contrato.Agencia.ToString());
            fieldList.Add("[NUMEROCONTA]", numeroConta);
            fieldList.Add("[TIPOCONTA]", contrato.TipoConta);

            // (+) Informações Contrato 

            string mesExtenso = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month).ToLower();
            mesExtenso = char.ToUpper(mesExtenso[0]) + mesExtenso.Substring(1);

            fieldList.Add("[CIDADEATUAL]", contrato.CidadeAtual);
            fieldList.Add("[DIAATUAL]", DateTime.Now.Day.ToString());
            fieldList.Add("[MESATUAL]", mesExtenso);
            fieldList.Add("[ANOATUAL]", DateTime.Now.Year.ToString());

            int vigenciaMeses = contrato.VigenciaMeses;

            fieldList.Add("[DATAINICIOVIGENCIA]", contrato.InicioContrato.ToString("dd/MM/yyyy"));
            fieldList.Add("[DATAFIMVIGENCIA]", contrato.TerminoContrato.ToString("dd/MM/yyyy"));
            fieldList.Add("[VIGENCIAMESES]", vigenciaMeses.ToString());
            fieldList.Add("[VIGENCIAEXTENSOMESES]", GeneralMethods.FindExtensiveNumber(vigenciaMeses, "e"));


            if (!Directory.Exists(DiretorioContratoFim))
                throw new Exception($"O diretório destino dos contratos de locação foi apagado ou está inacessível. Diretório: {DiretorioBase}");

            object destinationPath = DiretorioContratoFim + $@"\Contrato_Locacao_{nomeLocatario}_" + DateTime.Now.Date.ToString("dd-MM-yyyy") + ".docx";

            Application app = new Application();
            app.Visible = false;

            object missing = System.Reflection.Missing.Value;
            object findText = null;
            object replaceWith = null;
            object matchWholeWord = true;
            object forward = false;

            Document doc = app.Documents.Open(DiretorioContratoBase, ReadOnly: true);
            Range rng = doc.Range(ref missing, ref missing);

            // Replace dos Campos

            foreach (var item in fieldList)
            {
                rng = doc.Range(ref missing, ref missing);
                findText = item.Key;
                replaceWith = item.Value;

                rng.Find.Execute(ref findText, ref missing, ref matchWholeWord, ref missing, ref missing, ref missing, ref forward, ref missing, ref missing, ref replaceWith,
                                 ref missing, ref missing, ref missing, ref missing, ref missing);

                if (repetitionKey.Contains(findText))
                    rng.Find.Execute(ref findText, ref missing, ref matchWholeWord, ref missing, ref missing, ref missing, ref forward, ref missing, ref missing, ref replaceWith,
                                 ref missing, ref missing, ref missing, ref missing, ref missing);
            }

            // Salvar Arquivo

            doc.SaveAs2(destinationPath);
            doc.Close();


            app.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            app.Quit();

            return destinationPath.ToString();
        }
        
        public static void WelcomeEmail(string anexo, string racf, string nomeLocatario, string locatarioCpf)
        {
            Usuario user = UsuarioBusiness.UserData(racf);
            Locatario loc = LocatarioFacade.LocatarioData(nomeLocatario, locatarioCpf);

            EmailFacade.WelcomeEmail(user.Email, loc.Email, user.SenhaEmail, anexo, user.Nome, loc.Nome);
        }
    }
}
