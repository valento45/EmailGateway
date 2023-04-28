using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

using System.Net.Mail;
using System.Net.Mime;

namespace EmailGateway

{
    public class EmailBE
    {
        public string Email { get; set; }

        public string Senha { get; set; }
        public string Host { get; set; } = "smtp.gmail.com";
        public int Port { get; set; } = 587;

        public EmailBE(bool useConfiguration = false)
        {
            if (useConfiguration)
            {
                var cred = getCredenciais();
                Email = cred[0];
                Senha = cred[1];
                Host = cred[2];
                Port = cred[3] != string.Empty ? int.Parse(cred[3]) : 587;
            }
            else
            {
                Email = "";
                Senha = "";
                Host = "";
                Port = 587;
                 
            }


        }
        public static string[] getCredenciais()
        {
            string caminho = AppDomain.CurrentDomain.BaseDirectory;


            string Arquivo = "config.txt";
            string[] cred = File.ReadAllText(Path.Combine(caminho, Arquivo)).Split(',');
            return cred;
        }
        public string EnviaEmail(string destinario, string assuntos, string mensagem)
        {
            try
            {
                
                SmtpClient EmailObj = new SmtpClient();
                EmailObj.Credentials = new NetworkCredential(Email, Senha);
                EmailObj.Host = Host;
                EmailObj.Port = Port;
                EmailObj.EnableSsl = true;
                EmailObj.UseDefaultCredentials = true;
                EmailObj.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage msg = new MailMessage(Email, destinario, assuntos, mensagem);
                EmailObj.Send(msg);
                return "mensagem enviada com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message + "\r\n" + (ex.InnerException != null ? ex.InnerException.Message : "");
            }


        }

        public string EnviaEmailcComAnexo(string destinario, string assuntos, string mensagem, string[] anexos)
        {
            try
            {
               
                SmtpClient EmailObj = new SmtpClient();
                EmailObj.Credentials = new NetworkCredential(Email, Senha);
                EmailObj.Host = Host ;
                EmailObj.Port = Port;
                EmailObj.EnableSsl = true;
                EmailObj.UseDefaultCredentials = true;
                EmailObj.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage msg = new MailMessage(Email, destinario, assuntos, mensagem);
                if (anexos.Length > 0)
                {
                    for (int i = 0; i < anexos.Length; i++)
                    {

                        Attachment anexo = new Attachment(anexos[i], MediaTypeNames.Application.Octet);
                        msg.Attachments.Add(anexo);
                    }
                }
                EmailObj.Send(msg);
                return "mensagem enviada com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message + "\r\n" + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
        }

        public static string EnviaEmailStatic(string destinario, string assuntos, string mensagem)
        {
            try
            {
                string[] credenciais = getCredenciais();
                SmtpClient EmailObj = new SmtpClient();
                EmailObj.Credentials = new NetworkCredential(credenciais[0], credenciais[1]);
                EmailObj.Host = credenciais[2];
                EmailObj.Port = int.Parse(credenciais[3]);
                EmailObj.EnableSsl = true;
                EmailObj.UseDefaultCredentials = true;
                EmailObj.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage msg = new MailMessage(credenciais[0], destinario, assuntos, mensagem);
                EmailObj.Send(msg);
                return "mensagem enviada com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message + "\r\n" + (ex.InnerException != null ? ex.InnerException.Message : "");
            }
        }

        public static string EnviaEmailComAnexoStatic(string destinario, string assuntos, string mensagem, List<string> anexos)
        {
            try
            {
                string[] credenciais = getCredenciais();
                MailMessage msg = new MailMessage(credenciais[0], destinario, assuntos, mensagem);

                if (anexos.Count > 0)
                {
                    for (int i = 0; i < anexos.Count; i++)
                    {

                        Attachment anexo = new Attachment(anexos[i], MediaTypeNames.Application.Octet);
                        msg.Attachments.Add(anexo);
                    }
                }
                SmtpClient EmailObj = new SmtpClient();
                EmailObj.Host = credenciais[2];
                EmailObj.Port = int.Parse(credenciais[3]);
                EmailObj.EnableSsl = true;
                EmailObj.DeliveryMethod = SmtpDeliveryMethod.Network;
                EmailObj.UseDefaultCredentials = true;

                EmailObj.Credentials = new NetworkCredential(credenciais[0], credenciais[1]);
                EmailObj.Send(msg);
                return "Mensagem enviada com sucesso.";
            }
            catch (Exception ex)
            {
                return ex.Message + "\r\n" + (ex.InnerException != null ? ex.InnerException.Message : "");
            }


        }
    }
}
