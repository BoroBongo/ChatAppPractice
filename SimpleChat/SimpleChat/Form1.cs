using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleChat
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive="";
        public string TextToSend;
        public int ChangeNumber = 0;
        public bool hostOrClient;
        private BinaryFormatter _bFormatter;

        public Form1()
        {
            InitializeComponent();

            this._bFormatter = new BinaryFormatter();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach(IPAddress ip in localIP)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP_Server.Text = ip.ToString();
                }
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            hostOrClient = true;
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(PORT_Server.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
            checkBox1.Checked = true;
        }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            hostOrClient = false;
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(IP_Client.Text), int.Parse(PORT_Client.Text));
            client.Connect(IpEnd);
            try
            {
                _bFormatter.Serialize(this.client.GetStream(), ChangeNumber);
                ChatTextBox.AppendText($"Connect to Server \n");
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.ChatTextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatTextBox.AppendText($"You: {receive} \n");
                    }));
                    receive = "";
                    this.richTextBox1.Invoke(new MethodInvoker(delegate ()
                    {
                        richTextBox1.Text = this.ChangeNumber.ToString();
                    }));
                    //----------
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
               // this.richTextBox1.Text = (this.ChangeNumber.ToString());
                STW.WriteLine(TextToSend);
                this.ChatTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatTextBox.AppendText($"Me: {TextToSend} \n");
                }));
                this.richTextBox1.Invoke(new MethodInvoker(delegate ()
                {
                    richTextBox1.Text = this.ChangeNumber.ToString();
                }));
            }
            else
            {
                MessageBox.Show("Sending Failed");
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(InputTextBox.Text != "")
            {
                TextToSend = InputTextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            InputTextBox.Text = "";
        }

        private void IP_Client_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeNumber++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
