using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enginesoft.SendEmailSample
{
    public partial class MainForm : Form
    {
        private BackgroundWorker workerSend;
        
        public MainForm()
        {
            InitializeComponent();

            lblStatus.Text = string.Empty;

            workerSend = new BackgroundWorker();
            workerSend.DoWork += worker_DoWork;
            workerSend.RunWorkerCompleted += worker_RunWorkerCompleted;
        }
        
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var config = (Models.MailConfig)e.Argument;
            MailHelper.Send(config, txtSubject.Text, txtMessage.Text, radContentHtml.Checked);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = string.Empty;
            EnableForm(true);

            if (e.Error != null)
            {
                if (e.Error.Message.Contains("SMTP server requires a secure connection") && txtFrom.Text.Contains("@gmail.com"))
                {
                    //Gmail bloqueou o acesso utilizando login/senha, veja: https://support.google.com/accounts/answer/6010255
                    MessageBox.Show(this, string.Format("Não foi possivel realizar o envio\r\n\r\n{0}\r\n\r\nVerifique as configurações de segurança informadas: servidor, porta, Ssl, usuário e senha\r\n\r\nNota: O gmail desabilitou o envio de e-mail utilizando usuário/senha por outros aplicativos que não sejam do Google. Para obter detalhes de como habilitar novamente esse tipo de envio consulte a seguinte página: https://support.google.com/accounts/answer/6010255", e.Error.Message), "SendEmailSample", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(this, string.Format("Não foi possivel realizar o envio\r\n\r\n{0}\r\n\r\nVerifique as configurações de segurança informadas: servidor, porta, Ssl, usuário e senha\r\n\r\nNota: O seu servidor pode ter bloqueado o envio via Smtp, o Google por exemplo desativou por padrão o login de aplicativos externos, mais detalhes: https://support.google.com/accounts/answer/6010255", e.Error.Message), "SendEmailSample", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return;
            }

            MessageBox.Show(this, "E-mail enviado", "SendEmailSample", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ValidateForm()
        {
            var listErrors = new List<string>();
            
            if (string.IsNullOrEmpty(txtFrom.Text))
                listErrors.Add("- Remetente é requerido");
            else if (!ValidateEmail(txtFrom.Text))
                listErrors.Add(string.Format("- Remetente ({0}) não é um e-mail válido", txtFrom.Text));

            if (string.IsNullOrEmpty(txtTo.Text))
                listErrors.Add("- Destinatário é requerido");
            else if (!ValidateEmail(txtTo.Text))
                listErrors.Add(string.Format("- Destinatário ({0}) não é um e-mail válido", txtTo.Text));

            if (listErrors.Count > 0)
                MessageBox.Show(this, string.Format("Por favor, corrija os seguintes erros:\r\n\r\n{0}", string.Join("\r\n", listErrors)), "SendEmailSample", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            return (listErrors.Count == 0);
        }

        private bool ValidateEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void EnableForm(bool enabled)
        {
            groupAddress.Enabled = enabled;
            groupSmtp.Enabled = enabled;
            groupMessage.Enabled = enabled;
            groupButtons.Enabled = enabled;
        }

        #region Events

        private void txtFrom_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSmtpUser.Text))
                txtSmtpUser.Text = txtFrom.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            var config = new Models.MailConfig();

            try
            {
                config.FromAddress = new System.Net.Mail.MailAddress(txtFrom.Text);
                config.ToAddressList.Add(new System.Net.Mail.MailAddress(txtTo.Text));
                config.SMTPHost = txtSmtpHost.Text;
                config.SMTPPort = Convert.ToInt32(txtSmtpPort.Text);
                config.SMTPSSL = chkSmtpSsl.Checked;
                config.SMTPUser = txtSmtpUser.Text;
                config.SMTPPassword = txtSmtpPassword.Text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(this, string.Format("Erro na configuração dos dados para envio: {0}", ex.Message), "SendEmailSample", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EnableForm(false);
            lblStatus.Text = "Enviando...";

            workerSend.RunWorkerAsync(config);
        }

        #endregion
    }
}
