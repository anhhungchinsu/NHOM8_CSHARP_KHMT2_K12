using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GUI.MonthyReportGUI
{
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
        }
        StaffBUS stb = new StaffBUS();
        private void button1_Click(object sender, EventArgs e)
        {
            MonthlyReportObject mrobj = new MonthlyReportObject();
            dgvdanhsach.Rows.Clear();
            ChartAmount.Series["Số lượng tồn"].Points.Clear();
            List<MonthlyReportObject> lstim = MonthlyReportBUS.getImamount(txtdate.Value);
            List<MonthlyReportObject> lstex = MonthlyReportBUS.getExamount(txtdate.Value);
            foreach (var im in lstim)
            {
                foreach (var ex in lstex)
                {
                    if (im.Product_id == ex.Product_id)
                    {
                        dgvdanhsach.Rows.Add(stt, im.Product_name, "Sản phẩm", im.Product_imamount - ex.Product_examount, "Hàng tồn");
                    }
                }
                dgvdanhsach.Rows.Add(stt, im.Product_name, "Sản phẩm", im.Product_imamount, "Hàng tồn");
            }
            for (int i = 1; i < dgvdanhsach.RowCount; i++)
            {
                if(dgvdanhsach.Rows[i-1].Cells[1].Value == dgvdanhsach.Rows[i].Cells[1].Value)
                {
                    dgvdanhsach.Rows.RemoveAt(i);
                }
            }
            int index = 1;
            foreach (DataGridViewRow row in dgvdanhsach.Rows)
            {
                row.Cells[0].Value = index;
                index++;
            }
            foreach (DataGridViewRow row in dgvdanhsach.Rows)
            {
                try
                {
                    ChartAmount.Series["Số lượng tồn"].Points.AddXY(row.Cells["product_name"].Value, row.Cells["product_amount"].Value);
                    ChartAmount.Series["Số lượng tồn"].Points[row.Index].Label = row.Cells["product_amount"].Value.ToString();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void cbbstaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            cbbstaff.DataSource = stb.ShowNhanVien();
            cbbstaff.ValueMember = "staff_id";
            cbbstaff.DisplayMember = "staff_name";
        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cbbmonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PdfPTable pdf = new PdfPTable(dgvdanhsach.Columns.Count);
            //basefont for utf-8
            string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //font-title
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 36);
            Paragraph titleName = new Paragraph(label1.Text, titleFont);
            titleName.Alignment = Element.ALIGN_CENTER;
            //content-font
            iTextSharp.text.Font contentFont = new iTextSharp.text.Font(bf, 12);
            //totalinformation
            Paragraph UnitText = new Paragraph("Tên đơn vị: Chinsu", contentFont);
            Paragraph DateText = new Paragraph("Ngày lập: " + txtdate.Value, contentFont);
            Paragraph StaffText = new Paragraph("Người lập: " + cbbstaff.GetItemText(this.cbbstaff.SelectedItem), contentFont);
            //table
            foreach (DataGridViewColumn col in dgvdanhsach.Columns)
            {
                pdf.AddCell(new Phrase(col.HeaderText, contentFont));
            }
            foreach (DataGridViewRow row in dgvdanhsach.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdf.AddCell(new Phrase(cell.Value.ToString(), contentFont));
                }
            }
            pdf.SpacingBefore = 10f;
            pdf.SpacingAfter = 10f;
            //chart
            MemoryStream memoryStream = new MemoryStream();
            ChartAmount.SaveImage(memoryStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
            img.ScalePercent(75f);
            img.Alignment = Element.ALIGN_CENTER;
            //create+add pdf
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(titleName);
                        doc.Add(UnitText);
                        doc.Add(DateText);
                        doc.Add(StaffText);
                        doc.Add(pdf);
                        doc.Add(img);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
