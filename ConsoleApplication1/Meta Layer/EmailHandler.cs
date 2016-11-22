using System;
using System.Net;
using System.Net.Mail;
using ConsoleApplication1.Debug;

namespace ConsoleApplication1.Meta_Layer {
    public class EmailHandler {
        private NetworkCredential _networkCred;
        private Logger _logger = Logger.getInstance();

        public EmailHandler(string email, string password) {
            _networkCred = new NetworkCredential(email, password);
        }

        public void SendEmail(string to, string from, string subject, string body, string attachment, NetworkCredential auth) {
            MailMessage mail = new MailMessage(from, to, subject, body);
            SmtpClient smtpServer = new SmtpClient();

            smtpServer.Host = "smtp-mail.outlook.com";
            smtpServer.Credentials = _networkCred;
            smtpServer.EnableSsl = true;
            smtpServer.Port = 587;

            mail.Attachments.Add(new Attachment(attachment));

            try {
                _logger.WriteLine("start to send email directly ...");
                smtpServer.Send(mail);
                _logger.WriteLine("email was sent successfully!");
            } catch (Exception ep) {
                _logger.WriteLine("failed to send email with the following error: " + ep.Message);
            }
            Console.ReadKey(true);
        }
    }
}
