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

namespace GUI.ProductGUI
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
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx"})
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
        }

        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = result[cbSheet.SelectedItem.ToString()];
            grdProduct.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ProductObject po = new ProductObject();
                po.Product_id = dt.Rows[i][0].ToString();
                po.Product_name = dt.Rows[i][1].ToString();
                po.Product_brand = dt.Rows[i][2].ToString();
                po.Product_image = dt.Rows[i][3].ToString();
                po.Product_specification = dt.Rows[i][4].ToString();
                po.Product_feature = dt.Rows[i][5].ToString();
                po.Product_exprice = double.Parse(dt.Rows[i][6].ToString());
                po.Product_imprice = double.Parse(dt.Rows[i][7].ToString());
                po.Product_amount = int.Parse(dt.Rows[i][8].ToString());
                po.Product_type_id = dt.Rows[i][9].ToString();
                if (ProductBUS.createProduct(po))
                {
                    flag++;
                }
            }
            MessageBox.Show("Có " + flag + "bản ghi bị lỗi");
        }

        private void grdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
