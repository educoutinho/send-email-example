namespace Enginesoft.SendEmailSample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupAddress = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.groupSmtp = new System.Windows.Forms.GroupBox();
            this.chkSmtpSsl = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSmtpHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSmtpPassword = new System.Windows.Forms.TextBox();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.txtSmtpUser = new System.Windows.Forms.TextBox();
            this.groupMessage = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radContentHtml = new System.Windows.Forms.RadioButton();
            this.radContentText = new System.Windows.Forms.RadioButton();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupAddress.SuspendLayout();
            this.groupSmtp.SuspendLayout();
            this.groupMessage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAddress
            // 
            this.groupAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAddress.Controls.Add(this.label2);
            this.groupAddress.Controls.Add(this.label1);
            this.groupAddress.Controls.Add(this.txtTo);
            this.groupAddress.Controls.Add(this.txtFrom);
            this.groupAddress.Location = new System.Drawing.Point(12, 12);
            this.groupAddress.Name = "groupAddress";
            this.groupAddress.Size = new System.Drawing.Size(387, 180);
            this.groupAddress.TabIndex = 0;
            this.groupAddress.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destinatário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remetente";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(85, 59);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(285, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(85, 33);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(285, 20);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // groupSmtp
            // 
            this.groupSmtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSmtp.Controls.Add(this.chkSmtpSsl);
            this.groupSmtp.Controls.Add(this.label5);
            this.groupSmtp.Controls.Add(this.label6);
            this.groupSmtp.Controls.Add(this.label4);
            this.groupSmtp.Controls.Add(this.txtSmtpHost);
            this.groupSmtp.Controls.Add(this.label3);
            this.groupSmtp.Controls.Add(this.txtSmtpPassword);
            this.groupSmtp.Controls.Add(this.txtSmtpPort);
            this.groupSmtp.Controls.Add(this.txtSmtpUser);
            this.groupSmtp.Location = new System.Drawing.Point(414, 12);
            this.groupSmtp.Name = "groupSmtp";
            this.groupSmtp.Size = new System.Drawing.Size(224, 180);
            this.groupSmtp.TabIndex = 1;
            this.groupSmtp.TabStop = false;
            this.groupSmtp.Text = "Servidor SMTP";
            // 
            // chkSmtpSsl
            // 
            this.chkSmtpSsl.AutoSize = true;
            this.chkSmtpSsl.Checked = true;
            this.chkSmtpSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSmtpSsl.Location = new System.Drawing.Point(76, 87);
            this.chkSmtpSsl.Name = "chkSmtpSsl";
            this.chkSmtpSsl.Size = new System.Drawing.Size(71, 17);
            this.chkSmtpSsl.TabIndex = 4;
            this.chkSmtpSsl.Text = "Usar SSL";
            this.chkSmtpSsl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Porta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuário";
            // 
            // txtSmtpHost
            // 
            this.txtSmtpHost.Location = new System.Drawing.Point(76, 29);
            this.txtSmtpHost.Name = "txtSmtpHost";
            this.txtSmtpHost.Size = new System.Drawing.Size(128, 20);
            this.txtSmtpHost.TabIndex = 1;
            this.txtSmtpHost.Text = "smtp.gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Servidor";
            // 
            // txtSmtpPassword
            // 
            this.txtSmtpPassword.Location = new System.Drawing.Point(76, 144);
            this.txtSmtpPassword.Name = "txtSmtpPassword";
            this.txtSmtpPassword.PasswordChar = '*';
            this.txtSmtpPassword.Size = new System.Drawing.Size(128, 20);
            this.txtSmtpPassword.TabIndex = 8;
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(76, 59);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(54, 20);
            this.txtSmtpPort.TabIndex = 3;
            this.txtSmtpPort.Text = "587";
            // 
            // txtSmtpUser
            // 
            this.txtSmtpUser.Location = new System.Drawing.Point(76, 118);
            this.txtSmtpUser.Name = "txtSmtpUser";
            this.txtSmtpUser.Size = new System.Drawing.Size(128, 20);
            this.txtSmtpUser.TabIndex = 6;
            // 
            // groupMessage
            // 
            this.groupMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMessage.Controls.Add(this.label7);
            this.groupMessage.Controls.Add(this.label8);
            this.groupMessage.Controls.Add(this.groupBox4);
            this.groupMessage.Controls.Add(this.txtSubject);
            this.groupMessage.Controls.Add(this.txtMessage);
            this.groupMessage.Location = new System.Drawing.Point(12, 198);
            this.groupMessage.Name = "groupMessage";
            this.groupMessage.Size = new System.Drawing.Size(626, 338);
            this.groupMessage.TabIndex = 2;
            this.groupMessage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mensagem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Assunto";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.radContentHtml);
            this.groupBox4.Controls.Add(this.radContentText);
            this.groupBox4.Location = new System.Drawing.Point(457, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 48);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Conteúdo";
            // 
            // radContentHtml
            // 
            this.radContentHtml.AutoSize = true;
            this.radContentHtml.Location = new System.Drawing.Point(71, 19);
            this.radContentHtml.Name = "radContentHtml";
            this.radContentHtml.Size = new System.Drawing.Size(55, 17);
            this.radContentHtml.TabIndex = 1;
            this.radContentHtml.TabStop = true;
            this.radContentHtml.Text = "HTML";
            this.radContentHtml.UseVisualStyleBackColor = true;
            // 
            // radContentText
            // 
            this.radContentText.AutoSize = true;
            this.radContentText.Checked = true;
            this.radContentText.Location = new System.Drawing.Point(19, 20);
            this.radContentText.Name = "radContentText";
            this.radContentText.Size = new System.Drawing.Size(52, 17);
            this.radContentText.TabIndex = 0;
            this.radContentText.TabStop = true;
            this.radContentText.Text = "Texto";
            this.radContentText.UseVisualStyleBackColor = true;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(60, 39);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(382, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(14, 97);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(592, 235);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.WordWrap = false;
            // 
            // groupButtons
            // 
            this.groupButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupButtons.Controls.Add(this.lblStatus);
            this.groupButtons.Controls.Add(this.btnSend);
            this.groupButtons.Location = new System.Drawing.Point(12, 543);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Size = new System.Drawing.Size(626, 54);
            this.groupButtons.TabIndex = 3;
            this.groupButtons.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(11, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(487, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "[status]";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(542, 17);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 28);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 603);
            this.Controls.Add(this.groupButtons);
            this.Controls.Add(this.groupMessage);
            this.Controls.Add(this.groupSmtp);
            this.Controls.Add(this.groupAddress);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendEmailSample v0.0.1";
            this.groupAddress.ResumeLayout(false);
            this.groupAddress.PerformLayout();
            this.groupSmtp.ResumeLayout(false);
            this.groupSmtp.PerformLayout();
            this.groupMessage.ResumeLayout(false);
            this.groupMessage.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.GroupBox groupSmtp;
        private System.Windows.Forms.CheckBox chkSmtpSsl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSmtpHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSmtpPassword;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.TextBox txtSmtpUser;
        private System.Windows.Forms.GroupBox groupMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radContentHtml;
        private System.Windows.Forms.RadioButton radContentText;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.GroupBox groupButtons;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblStatus;
    }
}

