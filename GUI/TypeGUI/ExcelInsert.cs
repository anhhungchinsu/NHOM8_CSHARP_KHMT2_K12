using BUS;
using BUS.Utilities;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.TypeGUI
{
    public partial class ExcelInsert : Form
    {
        public ExcelInsert()
        {
            InitializeComponent();
        }
        DataTableCollection result;
        DataTable dt;
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    result = Excel.readFile(ofd.FileName);
                    cbSheet.Items.Clear();
                    foreach (DataTable dt in result)
                    {
                        cbSheet.Items.Add(dt.TableName);
                    }
                }
            }
            button1.Enabled = true;
        }

        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = result[cbSheet.SelectedItem.ToString()];
            grdProduct.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int flag = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                TypeObject to = new TypeObject();
                to.Type_id = dt.Rows[i][0].ToString();
                to.Type_name = dt.Rows[i][1].ToString();
                if(!TypeBUS.createType(to))
                {
                    flag++;
                }
            }
            MessageBox.Show("Có " + flag + "bản ghi bị lỗi");
        }
    }
}
