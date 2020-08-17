namespace GUI.ExportGUI
{
    partial class ExportMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbIdCustomer = new System.Windows.Forms.ComboBox();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIdStaff = new System.Windows.Forms.ComboBox();
            this.txtDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdExport = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.am = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_exprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1315, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 763);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbIdCustomer);
            this.groupBox3.Controls.Add(this.txtNameCustomer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 336);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KHÁCH HÀNG";
            // 
            // cbIdCustomer
            // 
            this.cbIdCustomer.FormattingEnabled = true;
            this.cbIdCustomer.Location = new System.Drawing.Point(114, 52);
            this.cbIdCustomer.Name = "cbIdCustomer";
            this.cbIdCustomer.Size = new System.Drawing.Size(229, 24);
            this.cbIdCustomer.TabIndex = 6;
            this.cbIdCustomer.SelectedIndexChanged += new System.EventHandler(this.cbIdCustomer_SelectedIndexChanged);
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(114, 163);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(223, 22);
            this.txtNameCustomer.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbIdStaff);
            this.groupBox2.Controls.Add(this.txtDateTime);
            this.groupBox2.Controls.Add(this.txtNameStaff);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 331);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhần viên";
            // 
            // cbIdStaff
            // 
            this.cbIdStaff.FormattingEnabled = true;
            this.cbIdStaff.Location = new System.Drawing.Point(102, 152);
            this.cbIdStaff.Name = "cbIdStaff";
            this.cbIdStaff.Size = new System.Drawing.Size(251, 24);
            this.cbIdStaff.TabIndex = 7;
            this.cbIdStaff.SelectedIndexChanged += new System.EventHandler(this.cbIdStaff_SelectedIndexChanged);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Enabled = false;
            this.txtDateTime.Location = new System.Drawing.Point(101, 55);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(245, 22);
            this.txtDateTime.TabIndex = 6;
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Location = new System.Drawing.Point(102, 247);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(251, 22);
            this.txtNameStaff.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày lập";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(116, 30);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(220, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền hàng";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(148, 439);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // grdExport
            // 
            this.grdExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.exprice,
            this.amount,
            this.totalPrice,
            this.btnDelete,
            this.am,
            this.discount});
            this.grdExport.Location = new System.Drawing.Point(6, 21);
            this.grdExport.Name = "grdExport";
            this.grdExport.RowTemplate.Height = 24;
            this.grdExport.Size = new System.Drawing.Size(1294, 390);
            this.grdExport.TabIndex = 5;
            this.grdExport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExport_CellClick);
            this.grdExport.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExport_CellValueChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Mã sản phẩm";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Tên sản phẩm";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // exprice
            // 
            this.exprice.HeaderText = "Đơn giá";
            this.exprice.Name = "exprice";
            this.exprice.ReadOnly = true;
            this.exprice.Width = 200;
            // 
            // amount
            // 
            this.amount.HeaderText = "SL";
            this.amount.Name = "amount";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Thành tiền";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 200;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 30F;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "X";
            this.btnDelete.Width = 30;
            // 
            // am
            // 
            this.am.HeaderText = "Column1";
            this.am.Name = "am";
            this.am.Visible = false;
            // 
            // discount
            // 
            this.discount.HeaderText = "Chiết khấu";
            this.discount.Name = "discount";
            // 
            // grdProduct
            // 
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.product_amount,
            this.product_exprice,
            this.product_brand,
            this.product_image});
            this.grdProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProduct.Location = new System.Drawing.Point(6, 21);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowTemplate.Height = 24;
            this.grdProduct.Size = new System.Drawing.Size(1300, 384);
            this.grdProduct.TabIndex = 6;
            this.grdProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellClick);
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Mã sản phẩm";
            this.product_id.Name = "product_id";
            this.product_id.Width = 150;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Tên sản phẩm";
            this.product_name.Name = "product_name";
            this.product_name.Width = 300;
            // 
            // product_amount
            // 
            this.product_amount.DataPropertyName = "product_amount";
            this.product_amount.HeaderText = "Số lượng có";
            this.product_amount.Name = "product_amount";
            // 
            // product_exprice
            // 
            this.product_exprice.DataPropertyName = "product_exprice";
            this.product_exprice.HeaderText = "Đơn giá";
            this.product_exprice.Name = "product_exprice";
            // 
            // product_brand
            // 
            this.product_brand.DataPropertyName = "product_brand";
            this.product_brand.HeaderText = "Nhãn hiệu";
            this.product_brand.Name = "product_brand";
            // 
            // product_image
            // 
            this.product_image.DataPropertyName = "product_image";
            this.product_image.HeaderText = "Ảnh";
            this.product_image.Name = "product_image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tìm kiếm sản phẩm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1327, 781);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1327, 837);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xem hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdExport);
            this.groupBox4.Location = new System.Drawing.Point(3, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1306, 421);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GIỎ HÀNG";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grdProduct);
            this.groupBox5.Location = new System.Drawing.Point(3, 467);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1306, 411);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SẢN PHẨM HIỆN CÓ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1420, 781);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 50);
            this.button3.TabIndex = 12;
            this.button3.Text = "In hóa đơn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 890);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportMain";
            this.Text = "ExportMain";
            this.Load += new System.EventHandler(this.ExportMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDateTime;
        private System.Windows.Forms.ComboBox cbIdCustomer;
        private System.Windows.Forms.ComboBox cbIdStaff;
        private System.Windows.Forms.DataGridView grdExport;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_exprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_brand;
        private System.Windows.Forms.DataGridViewImageColumn product_image;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn exprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn am;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
    }
}