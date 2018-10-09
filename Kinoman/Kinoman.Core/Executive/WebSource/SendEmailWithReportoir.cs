using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Kinoman.Core.Executive.WebSource
{
    public class SendEmailWithReportoir
    {
        /// <summary>
        /// Email box need to be configured 
        /// </summary>
        /// <param name="mailRecipient">Recipient email adress e.g. test@test.com</param>
        /// <param name="bodyMessage">Result of ResultDisplay.GenerateResult() method should be provided</param>
        public string SendReportoire(string mailRecipient, string bodyMessage)
        {
            //MailMessage 
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("em@il.com");
            msg.To.Add(mailRecipient);
            msg.Subject = "Cinema Reportoir"; //Finaly date + cinema location
            msg.Body = bodyMessage;
            //SMTP settings

            string credentialPassword = "password";
            string credentialUser = "em@il.com";
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(credentialUser, credentialPassword);
            smtp.Host = "poczta.interia.pl";
            smtp.Port = 465;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Timeout = 240000;
                                     
            try
            {
                smtp.Send(msg);
                return "Wiadomość wysłana pomyślnie";
            }
            catch (Exception ex)
            {
                return "Wiadomość nie została wysłana BŁĄD:" + ex.Message;
            }
        }

    }
}
