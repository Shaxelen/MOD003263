using System;
using System.Net;
using System.Net.Mail;
using MOD003263_SoftwareEngineering.Debug;

namespace MOD003263_SoftwareEngineering.Meta {
    public class EmailHandler {
        private NetworkCredential _networkCred;
        private Logger _logger = Logger.Instance;

        public EmailHandler(NetworkCredential NetworkCredentials) {
            _networkCred = NetworkCredentials;
        }

        public bool SendEmail(string to, string subject, string body, string attachment) {
            try {
                MailMessage mail = new MailMessage(_networkCred.UserName, to, subject, body);
                SmtpClient smtpServer = new SmtpClient();

                smtpServer.Host = "smtp-mail.outlook.com";
                smtpServer.Credentials = _networkCred;
                smtpServer.EnableSsl = true;
                smtpServer.Port = 587;

                mail.Attachments.Add(new Attachment(attachment));

                _logger.WriteLine("start to send email directly ...");
                smtpServer.Send(mail);
                _logger.WriteLine("email was sent successfully!");
            } catch (Exception ep) {
                _logger.WriteLine("failed to send email with the following error: " + ep.Message);
                return false;
            }
            return true;
        }
    }
}