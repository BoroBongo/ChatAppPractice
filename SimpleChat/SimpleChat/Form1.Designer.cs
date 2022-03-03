using System;
using System.Windows.Forms;

namespace SimpleChat
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HostButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ChatTextBox = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.IP_Server = new System.Windows.Forms.MaskedTextBox();
            this.IP_Client = new System.Windows.Forms.MaskedTextBox();
            this.PORT_Client = new System.Windows.Forms.MaskedTextBox();
            this.PORT_Server = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP CLIENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PORT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PORT";
            // 
            // HostButton
            // 
            this.HostButton.Location = new System.Drawing.Point(473, 46);
            this.HostButton.Name = "HostButton";
            this.HostButton.Size = new System.Drawing.Size(116, 23);
            this.HostButton.TabIndex = 8;
            this.HostButton.Text = "HOST";
            this.HostButton.UseVisualStyleBackColor = true;
            this.HostButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(473, 117);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(116, 23);
            this.ConnectButton.TabIndex = 9;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(22, 155);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.Size = new System.Drawing.Size(567, 196);
            this.ChatTextBox.TabIndex = 11;
            this.ChatTextBox.Text = "";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(452, 369);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(137, 53);
            this.SendButton.TabIndex = 12;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(22, 369);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(401, 51);
            this.InputTextBox.TabIndex = 13;
            this.InputTextBox.Text = "";
            // 
            // IP_Server
            // 
            this.IP_Server.Location = new System.Drawing.Point(22, 47);
            this.IP_Server.Name = "IP_Server";
            this.IP_Server.Size = new System.Drawing.Size(165, 20);
            this.IP_Server.TabIndex = 14;
            this.IP_Server.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.IP_Server_MaskInputRejected);
            // 
            // IP_Client
            // 
            this.IP_Client.Location = new System.Drawing.Point(25, 117);
            this.IP_Client.Name = "IP_Client";
            this.IP_Client.Size = new System.Drawing.Size(165, 20);
            this.IP_Client.TabIndex = 15;
            this.IP_Client.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.IP_Client_MaskInputRejected);
            // 
            // PORT_Client
            // 
            this.PORT_Client.Location = new System.Drawing.Point(237, 120);
            this.PORT_Client.Name = "PORT_Client";
            this.PORT_Client.Size = new System.Drawing.Size(165, 20);
            this.PORT_Client.TabIndex = 17;
            // 
            // PORT_Server
            // 
            this.PORT_Server.Location = new System.Drawing.Point(237, 49);
            this.PORT_Server.Name = "PORT_Server";
            this.PORT_Server.Size = new System.Drawing.Size(165, 20);
            this.PORT_Server.TabIndex = 18;
            this.PORT_Server.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PORT_Server_MaskInputRejected);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "+1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(595, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Server";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(662, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(37, 25);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 447);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PORT_Server);
            this.Controls.Add(this.PORT_Client);
            this.Controls.Add(this.IP_Client);
            this.Controls.Add(this.IP_Server);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.HostButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PORT_Server_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void IP_Server_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HostButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.RichTextBox ChatTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.MaskedTextBox IP_Server;
        private System.Windows.Forms.MaskedTextBox IP_Client;
        private System.Windows.Forms.MaskedTextBox PORT_Client;
        private System.Windows.Forms.MaskedTextBox PORT_Server;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button1;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
    }
}

