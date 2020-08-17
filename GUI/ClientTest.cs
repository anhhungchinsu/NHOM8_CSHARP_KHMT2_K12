using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClientTest : Form
    {
        public ClientTest()
        {
            InitializeComponent();
            
        }
        SimpleTcpClient client;

        private void ClientTest_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
            client.Connect("127.0.0.1", 9969);
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtHistory.Invoke((MethodInvoker)delegate ()
            {
                txtHistory.Text += e.MessageString;
                
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtSend.Text, TimeSpan.FromSeconds(3));
        }
    }
}
