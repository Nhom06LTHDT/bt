namespace BT10
{
    partial class HoatDongBanHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.ltvDonHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flipBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbFoodbyCategory = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ltvChiPhi = new System.Windows.Forms.ListView();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNoteCP = new System.Windows.Forms.TextBox();
            this.btnChiPhi = new System.Windows.Forms.Button();
            this.nmMoneyCP = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoneyCP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txbTotalPrice);
            this.tabPage1.Controls.Add(this.ltvDonHang);
            this.tabPage1.Controls.Add(this.flipBan);
            this.tabPage1.Controls.Add(this.btnThanhToan);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tạo Đơn Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tổng Tiền:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(587, 358);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(114, 20);
            this.txbTotalPrice.TabIndex = 9;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTotalPrice.TextChanged += new System.EventHandler(this.txbTotalPrice_TextChanged);
            // 
            // ltvDonHang
            // 
            this.ltvDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvDonHang.GridLines = true;
            this.ltvDonHang.Location = new System.Drawing.Point(452, 64);
            this.ltvDonHang.Name = "ltvDonHang";
            this.ltvDonHang.Size = new System.Drawing.Size(392, 284);
            this.ltvDonHang.TabIndex = 8;
            this.ltvDonHang.UseCompatibleStateImageBehavior = false;
            this.ltvDonHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tiền";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 112;
            // 
            // flipBan
            // 
            this.flipBan.Location = new System.Drawing.Point(7, 11);
            this.flipBan.Name = "flipBan";
            this.flipBan.Size = new System.Drawing.Size(424, 364);
            this.flipBan.TabIndex = 7;
            this.flipBan.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(713, 354);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(120, 28);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmFoodCount);
            this.panel1.Controls.Add(this.cbFoodbyCategory);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.btnThemMon);
            this.panel1.Location = new System.Drawing.Point(452, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 51);
            this.panel1.TabIndex = 1;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.AllowDrop = true;
            this.nmFoodCount.Location = new System.Drawing.Point(222, 3);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(66, 20);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFoodCount.ValueChanged += new System.EventHandler(this.nmFoodCount_ValueChanged);
            // 
            // cbFoodbyCategory
            // 
            this.cbFoodbyCategory.FormattingEnabled = true;
            this.cbFoodbyCategory.Location = new System.Drawing.Point(3, 27);
            this.cbFoodbyCategory.Name = "cbFoodbyCategory";
            this.cbFoodbyCategory.Size = new System.Drawing.Size(203, 21);
            this.cbFoodbyCategory.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 0);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(203, 21);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(222, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Mang Về";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(306, 3);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 43);
            this.btnThemMon.TabIndex = 0;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.nmMoneyCP);
            this.tabPage2.Controls.Add(this.btnChiPhi);
            this.tabPage2.Controls.Add(this.txbNoteCP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbMode);
            this.tabPage2.Controls.Add(this.ltvChiPhi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Phí Phát Sinh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Phí Phát Sinh";
            // 
            // ltvChiPhi
            // 
            this.ltvChiPhi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader6});
            this.ltvChiPhi.Location = new System.Drawing.Point(6, 80);
            this.ltvChiPhi.Name = "ltvChiPhi";
            this.ltvChiPhi.Size = new System.Drawing.Size(406, 310);
            this.ltvChiPhi.TabIndex = 1;
            this.ltvChiPhi.UseCompatibleStateImageBehavior = false;
            this.ltvChiPhi.View = System.Windows.Forms.View.Details;
            this.ltvChiPhi.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cbMode
            // 
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Ngay",
            "Thang"});
            this.cbMode.Location = new System.Drawing.Point(415, 163);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(121, 21);
            this.cbMode.TabIndex = 2;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghi Chú:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbNoteCP
            // 
            this.txbNoteCP.Location = new System.Drawing.Point(539, 129);
            this.txbNoteCP.Multiline = true;
            this.txbNoteCP.Name = "txbNoteCP";
            this.txbNoteCP.Size = new System.Drawing.Size(305, 218);
            this.txbNoteCP.TabIndex = 6;
            // 
            // btnChiPhi
            // 
            this.btnChiPhi.Location = new System.Drawing.Point(729, 353);
            this.btnChiPhi.Name = "btnChiPhi";
            this.btnChiPhi.Size = new System.Drawing.Size(115, 34);
            this.btnChiPhi.TabIndex = 7;
            this.btnChiPhi.Text = "Nhập";
            this.btnChiPhi.UseVisualStyleBackColor = true;
            this.btnChiPhi.Click += new System.EventHandler(this.btnChiPhi_Click);
            // 
            // nmMoneyCP
            // 
            this.nmMoneyCP.Location = new System.Drawing.Point(538, 91);
            this.nmMoneyCP.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nmMoneyCP.Name = "nmMoneyCP";
            this.nmMoneyCP.Size = new System.Drawing.Size(149, 20);
            this.nmMoneyCP.TabIndex = 8;
            this.nmMoneyCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmMoneyCP.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "VND";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số Tiền";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi Chú";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày Tháng";
            this.columnHeader7.Width = 80;
            // 
            // HoatDongBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "HoatDongBanHang";
            this.Text = "HoatDongBanHang";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoneyCP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flipBan;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbFoodbyCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListView ltvDonHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.ListView ltvChiPhi;
        private System.Windows.Forms.Button btnChiPhi;
        private System.Windows.Forms.TextBox txbNoteCP;
        private System.Windows.Forms.NumericUpDown nmMoneyCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}