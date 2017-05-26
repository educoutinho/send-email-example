using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Enginesoft.SendEmailSample
{
    public class MailHelper
    {
        public static void Send(Models.MailConfig config, string subject, string message, bool isHTML = false, List<Attachment> attachments = null)
        {
            System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();

            if (config.FromAddress == null)
                throw new System.ArgumentNullException("config.FromAddress");

            mailMessage.From = config.FromAddress;
            
            foreach (var to in config.ToAddressList)
            {
                mailMessage.To.Add(to);
            }

            if (config.CCAddressList != null)
            {
                foreach (var cc in config.CCAddressList)
                    mailMessage.CC.Add(cc);
            }

            if (config.BCCAddressList != null)
            {
                foreach (var bcc in config.BCCAddressList)
                    mailMessage.Bcc.Add(bcc);
            }
            
            mailMessage.Subject = subject;
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = isHTML;

            using (var smtp = new System.Net.Mail.SmtpClient())
            {
                if (!string.IsNullOrEmpty(config.SMTPHost))
                {
                    smtp.Host = config.SMTPHost;
                    smtp.Port = (config.SMTPPort > 0 ? config.SMTPPort : 25);
                    smtp.EnableSsl = config.SMTPSSL;
                }
                else
                {
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.PickupDirectoryFromIis;
                }

                if (!string.IsNullOrEmpty(config.SMTPUser))
                    smtp.Credentials = new System.Net.NetworkCredential(config.SMTPUser, config.SMTPPassword);

                if (attachments != null)
                {
                    foreach (var item in attachments)
                        mailMessage.Attachments.Add(item);
                }

                smtp.Send(mailMessage);
            }
        }
    }
}
