using System.Net.Mail;

namespace Schools.Web.Utils
{
    public class EmailService
    {
        public static void SendEmailConfirmationCode(string emailConfirmationCode, string email, string baseUrl)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("kaszkietoo@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Test Mail";
            mail.Body = baseUrl + "#!/account/confirm:" + emailConfirmationCode;

            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("kaszkietoo@gmail.com", "***********");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}