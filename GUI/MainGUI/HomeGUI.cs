using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MainGUI
{
    public partial class HomeGUI : Form
    {
        SimpleTcpServer server;
        public HomeGUI(SimpleTcpServer server)
        {
            InitializeComponent();
            this.server = server;
            generateLog();
        }

        private void HomeGUI_Load(object sender, EventArgs e)
        {
            server.DataReceived += Server_DataReceived;
        }

        public void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtLog.Invoke((MethodInvoker)delegate ()
            {
                txtLog.Text += e.MessageString;
                txtLog.AppendText(Environment.NewLine);
            });
        }

        public void generateLog()
        {
            Thread theadLog = new Thread(
                delegate ()
                {
                    while (true)
                    {
                        if (DateTime.Now.ToString("h:mm:ss tt").Equals("5:06:00 PM"))
                        {
                            Console.WriteLine("here");
                            String filepath = "D:\\log.txt";
                            FileStream fs = new FileStream(filepath, FileMode.Create);
                            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                            sWriter.Write(txtLog.Text);
                            sWriter.Flush();
                            fs.Close();
                        }
                    }
                }
            );
            theadLog.Start();
        }
    }
}
