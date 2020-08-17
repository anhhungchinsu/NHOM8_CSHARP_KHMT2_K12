using GUI.ProductGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using GUI.TypeGUI;
using GUI.ExportGUI;
using GUI.UserGUI;
using GUI.DistributorGUI;
using GUI.DailyReportGUI;
using GUI.MonthyReportGUI;
using SimpleTCP;
using GUI.MainGUI;
using System.Threading;
using DTO;
using BUS;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        SimpleTcpServer server;
        SimpleTcpClient client = null;
        String userName;
        String per;
        HomeGUI f;
        public MainForm(String userName, String per)
        {
            InitializeComponent();
            this.userName = userName;
            this.per = per;
            txtUsername.Text = userName;
            if(per.Trim().Equals("0"))
            {
                txtPer.Text = "ADMIN";
            } else if(per.Trim().Equals("1"))
            {
                txtPer.Text = "WAREHOUSE STAFF";
                button2.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
            } else if(per.Trim().Equals("2"))
            {
                txtPer.Text = "SALESMAN";
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button11.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox3.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            jpnExport.Visible = true;
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            jpnExport.Visible = false;
            this.showForm(new DailyReport());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            jpnExport.Visible = false;
            this.showForm(new MonthlyReport());
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if(client != null)
            {
                String goodbye = this.userName + " đã đăng xuất lúc " + DateTime.Now.ToString();
                client.WriteLineAndGetReply(goodbye, TimeSpan.FromSeconds(1));
            }

            this.Hide();
            Form f = new LoginForm();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.showForm(new ProductMain());
        }

        private void showForm(object formObject)
        {
            if (this.pnRoot.Controls.Count > 0)
            {
                this.pnRoot.Controls.RemoveAt(0);
            }
                Form fr = formObject as Form;
                fr.TopLevel = false;
                fr.Dock = DockStyle.Fill;
                this.pnRoot.Controls.Add(fr);
                this.pnRoot.Tag = fr;
                fr.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (per.Trim().Equals("0"))
            { 
                this.showForm(f);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.showForm(new DegreeGUI());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.showForm(new StaffGUI());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.showForm(new TypeMain());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.showForm(new CustomerGUI());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (per.Trim().Equals("1"))
            {
                this.showForm(new ImportGUI(client));
            } else
            {
                this.showForm(new ImportGUI(null));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (per.Trim().Equals("2"))
            {
                this.showForm(new ExportMain(client));
            } else
            {
                this.showForm(new ExportMain(null));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.showForm(new UserMain());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.showForm(new DistributorMain());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (per.Trim().Equals("0"))
            { try
                {
                    server = new SimpleTcpServer();
                    server.Delimiter = 0x13;
                    server.StringEncoder = Encoding.UTF8;
                    //server.DataReceived += Server_DataReceived;
                    System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
                    server.Start(ip, 9969);
                    f = new HomeGUI(server);
                    button1_Click(sender, e);
                } catch(Exception ex)
                {
                    MessageBox.Show("Tài khoản đã được đăng nhập");
                    server.Stop();
                    this.Hide();
                    Form f = new LoginForm();
                    f.ShowDialog();
                    this.Close();
                }
            } else if (per.Trim().Equals("1"))
            {
                client = new SimpleTcpClient();
                client.StringEncoder = Encoding.UTF8;
                client.Connect("127.0.0.1", 9969);
                String hello = this.userName + " đã đăng nhập lúc " + DateTime.Now.ToString();
                client.WriteLineAndGetReply(hello, TimeSpan.FromSeconds(1));
                updateChart();
            }
            else if (per.Trim().Equals("2"))
            {
                client = new SimpleTcpClient();
                client.StringEncoder = Encoding.UTF8;
                client.Connect("127.0.0.1", 9969);
                String hello = this.userName + " đã đăng nhập lúc " + DateTime.Now.ToString();
                client.WriteLineAndGetReply(hello, TimeSpan.FromSeconds(1));
                updateChart();
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(client != null)
            {
                String goodbye = this.userName + " đã đăng xuất lúc " + DateTime.Now.ToString();
                client.WriteLineAndGetReply(goodbye, TimeSpan.FromSeconds(1));
            }
        }

        public void updateChart()
        {
                DateTime dt = DateTime.Now;
                String date = dt.Year + "/" + dt.Month + "/" + dt.Day;
                DataTable lst = StaffReport.getRevenue(date);
                for (int i = 0; i < lst.Rows.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(lst.Rows[i][0], lst.Rows[i][1]);
                }
        }
    }
}
