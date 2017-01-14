using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Schools.Web.Utils
{
    public class EmailService
    {
        public static void SendEmailConfirmationCode(string emailConfirmationCode, string email, string baseUrl)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");

            mail.From = new MailAddress("mdomagal@hotmail.com");
            mail.To.Add(email);
            mail.Subject = "Test Mail";
            mail.Body = baseUrl + "#!/account/confirm:" + emailConfirmationCode;

            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("mdomagal@hotmail.com", "Bobrovian0s9116");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}