using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;
using System.Net.Mime;

namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {
            smtp = new SmtpClient();
        }

        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("fdavidochoa@unicesar.edu.co","1003316542");
        }
        private void ConfigurarEmail(string documento)
        {
            email = new MailMessage();
            email.To.Add("anyambolano@unicesar.edu.co");
            email.From = new MailAddress("fdavidochoa@unicesar.edu.co");
            email.Subject = "Prueba correo desde proyecto." + DateTime.Now.ToString("dd/MM/yyyy/ hh:mm:ss");
            email.Body = $"<b> Coordial saludo. </b> <br " +
                $" > Envio de correo exitoso + adjunto de documento.";
            Attachment adjunto = new Attachment(documento, MediaTypeNames.Application.Octet);
            email.Attachments.Add(adjunto);
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

        }
        public string EnviarEmail(string documento)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(documento);
                smtp.Send(email);
                return ("Correo enviado correctamente.");
            }
            catch (Exception e)
            {
                return ("Error en el envio del correo.");
            }
            finally
            {
                email.Dispose();
            }
        }

    }
}
