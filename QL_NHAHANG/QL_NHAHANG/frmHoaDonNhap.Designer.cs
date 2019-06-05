namespace QL_NHAHANG
{
    partial class frmHoaDonNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonNhap));
            this.btn_Ghi = new System.Windows.Forms.Button();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.cbo_nguyenlieu = new System.Windows.Forms.ComboBox();
            this.lbl_NguyenLieu = new System.Windows.Forms.Label();
            this.gpb_ChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_macthd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gvv_DSHoaDon = new System.Windows.Forms.DataGridView();
            this.MAHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACTHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.gpb_HoaDonNhap = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahoadonnhap = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbo_NhaCC = new System.Windows.Forms.ComboBox();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            this.lbl_NhaCC = new System.Windows.Forms.Label();
            this.btn_LuuHD = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.gpb_HoaDon = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpb_ChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSHoaDon)).BeginInit();
            this.gpb_HoaDonNhap.SuspendLayout();
            this.gpb_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ghi
            // 
            this.btn_Ghi.Location = new System.Drawing.Point(593, 28);
            this.btn_Ghi.Name = "btn_Ghi";
            this.btn_Ghi.Size = new System.Drawing.Size(48, 26);
            this.btn_Ghi.TabIndex = 4;
            this.btn_Ghi.Text = "Ghi";
            this.btn_Ghi.UseVisualStyleBackColor = true;
            this.btn_Ghi.Click += new System.EventHandler(this.btn_Ghi_Click);
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.ForeColor = System.Drawing.Color.Black;
            this.lbl_SoLuong.Location = new System.Drawing.Point(462, 16);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(49, 13);
            this.lbl_SoLuong.TabIndex = 8;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // cbo_nguyenlieu
            // 
            this.cbo_nguyenlieu.FormattingEnabled = true;
            this.cbo_nguyenlieu.Location = new System.Drawing.Point(332, 32);
            this.cbo_nguyenlieu.Name = "cbo_nguyenlieu";
            this.cbo_nguyenlieu.Size = new System.Drawing.Size(79, 21);
            this.cbo_nguyenlieu.TabIndex = 2;
            // 
            // lbl_NguyenLieu
            // 
            this.lbl_NguyenLieu.AutoSize = true;
            this.lbl_NguyenLieu.ForeColor = System.Drawing.Color.Black;
            this.lbl_NguyenLieu.Location = new System.Drawing.Point(329, 16);
            this.lbl_NguyenLieu.Name = "lbl_NguyenLieu";
            this.lbl_NguyenLieu.Size = new System.Drawing.Size(63, 13);
            this.lbl_NguyenLieu.TabIndex = 6;
            this.lbl_NguyenLieu.Text = "Nguyên liệu";
            // 
            // gpb_ChiTietHoaDon
            // 
            this.gpb_ChiTietHoaDon.Controls.Add(this.txt_soluong);
            this.gpb_ChiTietHoaDon.Controls.Add(this.txt_macthd);
            this.gpb_ChiTietHoaDon.Controls.Add(this.label3);
            this.gpb_ChiTietHoaDon.Controls.Add(this.textBox3);
            this.gpb_ChiTietHoaDon.Controls.Add(this.label2);
            this.gpb_ChiTietHoaDon.Controls.Add(this.btn_Ghi);
            this.gpb_ChiTietHoaDon.Controls.Add(this.lbl_SoLuong);
            this.gpb_ChiTietHoaDon.Controls.Add(this.cbo_nguyenlieu);
            this.gpb_ChiTietHoaDon.Controls.Add(this.lbl_NguyenLieu);
            this.gpb_ChiTietHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpb_ChiTietHoaDon.Location = new System.Drawing.Point(16, 91);
            this.gpb_ChiTietHoaDon.Name = "gpb_ChiTietHoaDon";
            this.gpb_ChiTietHoaDon.Size = new System.Drawing.Size(649, 64);
            this.gpb_ChiTietHoaDon.TabIndex = 1;
            this.gpb_ChiTietHoaDon.TabStop = false;
            this.gpb_ChiTietHoaDon.Text = "Chi tiết hóa đơn";
            this.gpb_ChiTietHoaDon.Enter += new System.EventHandler(this.gpb_ChiTietHoaDon_Enter);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(465, 32);
            this.txt_soluong.Multiline = true;
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_soluong.Size = new System.Drawing.Size(100, 23);
            this.txt_soluong.TabIndex = 3;
            // 
            // txt_macthd
            // 
            this.txt_macthd.Location = new System.Drawing.Point(9, 33);
            this.txt_macthd.Name = "txt_macthd";
            this.txt_macthd.Size = new System.Drawing.Size(110, 20);
            this.txt_macthd.TabIndex = 0;
            this.txt_macthd.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã chi tiết hóa đơn";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(177, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã hóa đơn";
            // 
            // gvv_DSHoaDon
            // 
            this.gvv_DSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvv_DSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHDN,
            this.MACTHDN,
            this.MANL,
            this.SOLUONG,
            this.DONGIA});
            this.gvv_DSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSHoaDon.Location = new System.Drawing.Point(3, 16);
            this.gvv_DSHoaDon.Name = "gvv_DSHoaDon";
            this.gvv_DSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSHoaDon.Size = new System.Drawing.Size(643, 179);
            this.gvv_DSHoaDon.TabIndex = 0;
            this.gvv_DSHoaDon.SelectionChanged += new System.EventHandler(this.gvv_DSHoaDon_SelectionChanged);
            // 
            // MAHDN
            // 
            this.MAHDN.DataPropertyName = "MAHDN";
            this.MAHDN.HeaderText = "Mã hóa đơn nhập";
            this.MAHDN.Name = "MAHDN";
            // 
            // MACTHDN
            // 
            this.MACTHDN.DataPropertyName = "MACTHDN";
            this.MACTHDN.HeaderText = "Mã chi tiết hóa đơn nhập";
            this.MACTHDN.Name = "MACTHDN";
            // 
            // MANL
            // 
            this.MANL.DataPropertyName = "MANL";
            this.MANL.HeaderText = "Mã nguyên liệu";
            this.MANL.Name = "MANL";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(546, 30);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(95, 20);
            this.txt_manv.TabIndex = 3;
            // 
            // gpb_HoaDonNhap
            // 
            this.gpb_HoaDonNhap.Controls.Add(this.label1);
            this.gpb_HoaDonNhap.Controls.Add(this.txt_mahoadonnhap);
            this.gpb_HoaDonNhap.Controls.Add(this.txt_manv);
            this.gpb_HoaDonNhap.Controls.Add(this.dateTimePicker1);
            this.gpb_HoaDonNhap.Controls.Add(this.cbo_NhaCC);
            this.gpb_HoaDonNhap.Controls.Add(this.btn_TaoHoaDon);
            this.gpb_HoaDonNhap.Controls.Add(this.lbl_NhanVien);
            this.gpb_HoaDonNhap.Controls.Add(this.lbl_ThoiGian);
            this.gpb_HoaDonNhap.Controls.Add(this.lbl_NhaCC);
            this.gpb_HoaDonNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpb_HoaDonNhap.Location = new System.Drawing.Point(16, 13);
            this.gpb_HoaDonNhap.Name = "gpb_HoaDonNhap";
            this.gpb_HoaDonNhap.Size = new System.Drawing.Size(649, 59);
            this.gpb_HoaDonNhap.TabIndex = 0;
            this.gpb_HoaDonNhap.TabStop = false;
            this.gpb_HoaDonNhap.Text = "Hóa đơn nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã hóa đơn nhập";
            // 
            // txt_mahoadonnhap
            // 
            this.txt_mahoadonnhap.Location = new System.Drawing.Point(192, 31);
            this.txt_mahoadonnhap.Name = "txt_mahoadonnhap";
            this.txt_mahoadonnhap.Size = new System.Drawing.Size(100, 20);
            this.txt_mahoadonnhap.TabIndex = 0;
            this.txt_mahoadonnhap.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // cbo_NhaCC
            // 
            this.cbo_NhaCC.FormattingEnabled = true;
            this.cbo_NhaCC.Location = new System.Drawing.Point(314, 30);
            this.cbo_NhaCC.Name = "cbo_NhaCC";
            this.cbo_NhaCC.Size = new System.Drawing.Size(118, 21);
            this.cbo_NhaCC.TabIndex = 1;
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(6, 24);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(113, 31);
            this.btn_TaoHoaDon.TabIndex = 4;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbl_NhanVien.Location = new System.Drawing.Point(543, 14);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(74, 13);
            this.lbl_NhanVien.TabIndex = 3;
            this.lbl_NhanVien.Text = "Mã Nhân viên";
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.ForeColor = System.Drawing.Color.Black;
            this.lbl_ThoiGian.Location = new System.Drawing.Point(435, 14);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(51, 13);
            this.lbl_ThoiGian.TabIndex = 2;
            this.lbl_ThoiGian.Text = "Thời gian";
            this.lbl_ThoiGian.Click += new System.EventHandler(this.lbl_ThoiGian_Click);
            // 
            // lbl_NhaCC
            // 
            this.lbl_NhaCC.AutoSize = true;
            this.lbl_NhaCC.ForeColor = System.Drawing.Color.Black;
            this.lbl_NhaCC.Location = new System.Drawing.Point(311, 14);
            this.lbl_NhaCC.Name = "lbl_NhaCC";
            this.lbl_NhaCC.Size = new System.Drawing.Size(75, 13);
            this.lbl_NhaCC.TabIndex = 1;
            this.lbl_NhaCC.Text = "Nhà cung cấp";
            // 
            // btn_LuuHD
            // 
            this.btn_LuuHD.Location = new System.Drawing.Point(576, 503);
            this.btn_LuuHD.Name = "btn_LuuHD";
            this.btn_LuuHD.Size = new System.Drawing.Size(89, 32);
            this.btn_LuuHD.TabIndex = 48;
            this.btn_LuuHD.Text = "Lưu hóa đơn";
            this.btn_LuuHD.UseVisualStyleBackColor = true;
            // 
            // btn_InHD
            // 
            this.btn_InHD.Location = new System.Drawing.Point(472, 503);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(89, 32);
            this.btn_InHD.TabIndex = 47;
            this.btn_InHD.Text = "In hóa đơn";
            this.btn_InHD.UseVisualStyleBackColor = true;
            // 
            // gpb_HoaDon
            // 
            this.gpb_HoaDon.Controls.Add(this.gvv_DSHoaDon);
            this.gpb_HoaDon.Location = new System.Drawing.Point(16, 182);
            this.gpb_HoaDon.Name = "gpb_HoaDon";
            this.gpb_HoaDon.Size = new System.Drawing.Size(649, 198);
            this.gpb_HoaDon.TabIndex = 3;
            this.gpb_HoaDon.TabStop = false;
            this.gpb_HoaDon.Enter += new System.EventHandler(this.gpb_HoaDon_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(481, 383);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 32);
            this.textBox5.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tổng tiền";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xuất hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef0221;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.gpb_ChiTietHoaDon);
            this.Controls.Add(this.gpb_HoaDonNhap);
            this.Controls.Add(this.btn_LuuHD);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.gpb_HoaDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHoaDonNhap";
            this.Text = "Hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDonNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.gpb_ChiTietHoaDon.ResumeLayout(false);
            this.gpb_ChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSHoaDon)).EndInit();
            this.gpb_HoaDonNhap.ResumeLayout(false);
            this.gpb_HoaDonNhap.PerformLayout();
            this.gpb_HoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ghi;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.ComboBox cbo_nguyenlieu;
        private System.Windows.Forms.Label lbl_NguyenLieu;
        private System.Windows.Forms.GroupBox gpb_ChiTietHoaDon;
        private System.Windows.Forms.DataGridView gvv_DSHoaDon;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.GroupBox gpb_HoaDonNhap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbo_NhaCC;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.Label lbl_ThoiGian;
        private System.Windows.Forms.Label lbl_NhaCC;
        private System.Windows.Forms.Button btn_LuuHD;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.GroupBox gpb_HoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mahoadonnhap;
        private System.Windows.Forms.TextBox txt_macthd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACTHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}