using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enginesoft.SendEmailSample.Models
{
    public class MailConfig
    {
        public string SMTPHost { get; set; }
        public int SMTPPort { get; set; }
        public bool SMTPSSL { get; set; }
        public string SMTPUser { get; set; }
        public string SMTPPassword { get; set; }
        
        public System.Net.Mail.MailAddress FromAddress { get; set;}
                                
        public List<System.Net.Mail.MailAddress> ToAddressList { get; set; }
                
        public List<System.Net.Mail.MailAddress> CCAddressList { get; set; }
        
        public List<System.Net.Mail.MailAddress> BCCAddressList { get; set; }
        
        public MailConfig()
        {
            this.ToAddressList = new List<System.Net.Mail.MailAddress>();
            this.CCAddressList = new List<System.Net.Mail.MailAddress>();
            this.BCCAddressList = new List<System.Net.Mail.MailAddress>();
        }
    }
}
