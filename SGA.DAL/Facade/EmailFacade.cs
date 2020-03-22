using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using SGA.DAL.Enums;
using HtmlAgilityPack;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace SGA.DAL.Facade
{
    public class EmailFacade
    {
        public static string BaseDirectory { get { return AppDomain.CurrentDomain.BaseDirectory.ToString(); } }
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString; } }
        public static string DiretorioImportacao { get { return Configuracao.ReturnDocDirectory() + @"\IMPORTACAO"; } }

        public static string DiretorioEmail(StatusEmail status)
        {
            string emailHtml;

            if ((int)status == 0)
                emailHtml = "EmailVerificacao.html";
            else if ((int)status == 1)
                emailHtml = "EmailBemVindo.html";
            else if ((int)status == 2)
                emailHtml = "EmailParabens.html";
            else 
                emailHtml = "EmailCobranca.html";

            return BaseDirectory.Replace("bin", "Email_HTML")
                                                        .Replace("Debug", emailHtml).Replace("html\\", "html");
        }

        public static string EmailHtml(StatusEmail status)
        {
            HtmlDocument doc = new HtmlDocument();

            doc.Load(DiretorioEmail(status));
            return doc.Text;
        }

        public static void EmailCharge(string locador, string locatario, string emailLocatario, string userEmail, string userSenha)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new MailAddress(userEmail);

            message.To.Add(emailLocatario);
            message.Subject = "E-mail Automático de Cobrança";
            message.IsBodyHtml = true;

            string body = EmailHtml(StatusEmail.Cobranca);
            body = body.Replace("#LOCATARIO#", locatario).Replace("#DATAATUAL#", DateTime.Now.Date.ToString("dd/MM/yyyy")).Replace("#LOCADOR#", locador);
            message.Body = body;

            SmtpClient client = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));
            client.UseDefaultCredentials = false;

            client.Credentials = new NetworkCredential(userEmail, userSenha);
            client.EnableSsl = true;

            client.Send(message);
        }

        public static void EmailBirthday(string locador, string locatario, string emailLocatario, string userEmail, string userSenha)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new MailAddress(userEmail);

            message.CC.Add(emailLocatario);
            message.Subject = "Parabéns";
            message.IsBodyHtml = true;

            string body = EmailHtml(StatusEmail.Parabens);
            body = body.Replace("#LOCATARIO#", locatario).Replace("#DATAATUAL#", DateTime.Now.Date.ToString("dd/MM/yyyy")).Replace("#LOCADOR#", locador);
            message.Body = body;

            SmtpClient client = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));
            client.UseDefaultCredentials = false;

            client.Credentials = new NetworkCredential(userEmail, userSenha);
            client.EnableSsl = true;

            client.Send(message);
        }


        public static bool EmailVerify(string email, string senha)
        {
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.From = new MailAddress(email);

                message.To.Add("tarsocoelho98@gmail.com");
                message.Subject = "Email de Verificação";
                message.IsBodyHtml = true;

                string body = EmailHtml(StatusEmail.Verificacao);
                body = body.Replace("#EMAILOCADOR#", email).Replace("#DATAATUAL#", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                message.Body = body;

                SmtpClient client = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential(email, senha);
                client.EnableSsl = true;

                client.Send(message);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static void WelcomeEmail(string userEmail, string locatarioEmail, string senha, string pathAnexo, string nomeLocador, string nomeLocatario)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new MailAddress(userEmail);

            message.To.Add(locatarioEmail);
            message.Subject = "Boas Vindas - Contrato";
            message.IsBodyHtml = true;
            message.Attachments.Add(new Attachment(pathAnexo));

            var diretorioImportacao = new DirectoryInfo(DiretorioImportacao);

            if (Directory.Exists(DiretorioImportacao))
            {
                foreach (var file in diretorioImportacao.GetFiles())
                {
                    message.Attachments.Add(new Attachment(file.FullName));
                }
            }

            string body = EmailHtml(StatusEmail.BemVindo);

            body = body.Replace("#LOCADOR#", nomeLocador).Replace("#DATAATUAL#", DateTime.Now.Date.ToString("dd/MM/yyyy")).Replace("#LOCATARIO#", nomeLocatario);
            message.Body = body;

            SmtpClient client = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));
            client.UseDefaultCredentials = false;

            client.Credentials = new NetworkCredential(userEmail, senha);
            client.EnableSsl = true;

            client.Send(message);
        }
    }
}
