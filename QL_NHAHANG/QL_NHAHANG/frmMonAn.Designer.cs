namespace QL_NHAHANG
{
    partial class frmMonAn
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
            this.cboLoaiTD = new System.Windows.Forms.ComboBox();
            this.txt_dongiaton = new System.Windows.Forms.TextBox();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_tenthucdon = new System.Windows.Forms.TextBox();
            this.txt_mathucdon = new System.Windows.Forms.TextBox();
            this.lsb_trangthai = new System.Windows.Forms.ListBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.gb_qlthucdon = new System.Windows.Forms.GroupBox();
            this.lbl_dongiaton = new System.Windows.Forms.Label();
            this.lbl_donvitinh = new System.Windows.Forms.Label();
            this.lbl_tenmonan = new System.Windows.Forms.Label();
            this.lbl_tennhommonan = new System.Windows.Forms.Label();
            this.lblMaMonAn = new System.Windows.Forms.Label();
            this.grb_DSMonAn = new System.Windows.Forms.GroupBox();
            this.gvv_DSThucDon = new System.Windows.Forms.DataGridView();
            this.MAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDSMonAn = new System.Windows.Forms.Label();
            this.lblQLMonAn = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_qlthucdon.SuspendLayout();
            this.grb_DSMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiTD
            // 
            this.cboLoaiTD.FormattingEnabled = true;
            this.cboLoaiTD.Location = new System.Drawing.Point(140, 56);
            this.cboLoaiTD.Name = "cboLoaiTD";
            this.cboLoaiTD.Size = new System.Drawing.Size(151, 24);
            this.cboLoaiTD.TabIndex = 1;
            // 
            // txt_dongiaton
            // 
            this.txt_dongiaton.Location = new System.Drawing.Point(140, 165);
            this.txt_dongiaton.Name = "txt_dongiaton";
            this.txt_dongiaton.Size = new System.Drawing.Size(151, 22);
            this.txt_dongiaton.TabIndex = 4;
            this.txt_dongiaton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dongiaton_KeyPress);
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(140, 130);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(151, 22);
            this.txt_dvt.TabIndex = 3;
            // 
            // txt_tenthucdon
            // 
            this.txt_tenthucdon.Location = new System.Drawing.Point(140, 93);
            this.txt_tenthucdon.Name = "txt_tenthucdon";
            this.txt_tenthucdon.Size = new System.Drawing.Size(151, 22);
            this.txt_tenthucdon.TabIndex = 2;
            // 
            // txt_mathucdon
            // 
            this.txt_mathucdon.Location = new System.Drawing.Point(140, 19);
            this.txt_mathucdon.Name = "txt_mathucdon";
            this.txt_mathucdon.Size = new System.Drawing.Size(151, 22);
            this.txt_mathucdon.TabIndex = 0;
            this.txt_mathucdon.Leave += new System.EventHandler(this.txt_mathucdon_Leave);
            // 
            // lsb_trangthai
            // 
            this.lsb_trangthai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_trangthai.FormattingEnabled = true;
            this.lsb_trangthai.ItemHeight = 18;
            this.lsb_trangthai.Items.AddRange(new object[] {
            "Còn hàng",
            "Tạm hết"});
            this.lsb_trangthai.Location = new System.Drawing.Point(140, 202);
            this.lsb_trangthai.Name = "lsb_trangthai";
            this.lsb_trangthai.Size = new System.Drawing.Size(151, 22);
            this.lsb_trangthai.TabIndex = 5;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Location = new System.Drawing.Point(21, 204);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(67, 16);
            this.lbl_trangthai.TabIndex = 4;
            this.lbl_trangthai.Text = "Trạng thái";
            // 
            // gb_qlthucdon
            // 
            this.gb_qlthucdon.Controls.Add(this.cboLoaiTD);
            this.gb_qlthucdon.Controls.Add(this.txt_dongiaton);
            this.gb_qlthucdon.Controls.Add(this.txt_dvt);
            this.gb_qlthucdon.Controls.Add(this.txt_tenthucdon);
            this.gb_qlthucdon.Controls.Add(this.txt_mathucdon);
            this.gb_qlthucdon.Controls.Add(this.lsb_trangthai);
            this.gb_qlthucdon.Controls.Add(this.lbl_trangthai);
            this.gb_qlthucdon.Controls.Add(this.lbl_dongiaton);
            this.gb_qlthucdon.Controls.Add(this.lbl_donvitinh);
            this.gb_qlthucdon.Controls.Add(this.lbl_tenmonan);
            this.gb_qlthucdon.Controls.Add(this.lbl_tennhommonan);
            this.gb_qlthucdon.Controls.Add(this.lblMaMonAn);
            this.gb_qlthucdon.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_qlthucdon.Location = new System.Drawing.Point(6, 1);
            this.gb_qlthucdon.Name = "gb_qlthucdon";
            this.gb_qlthucdon.Size = new System.Drawing.Size(318, 251);
            this.gb_qlthucdon.TabIndex = 0;
            this.gb_qlthucdon.TabStop = false;
            this.gb_qlthucdon.Enter += new System.EventHandler(this.gb_qlthucdon_Enter);
            // 
            // lbl_dongiaton
            // 
            this.lbl_dongiaton.AutoSize = true;
            this.lbl_dongiaton.Location = new System.Drawing.Point(22, 168);
            this.lbl_dongiaton.Name = "lbl_dongiaton";
            this.lbl_dongiaton.Size = new System.Drawing.Size(77, 16);
            this.lbl_dongiaton.TabIndex = 8;
            this.lbl_dongiaton.Text = "Đơn giá tính";
            // 
            // lbl_donvitinh
            // 
            this.lbl_donvitinh.AutoSize = true;
            this.lbl_donvitinh.Location = new System.Drawing.Point(22, 134);
            this.lbl_donvitinh.Name = "lbl_donvitinh";
            this.lbl_donvitinh.Size = new System.Drawing.Size(69, 16);
            this.lbl_donvitinh.TabIndex = 6;
            this.lbl_donvitinh.Text = "Đơn vị tính";
            // 
            // lbl_tenmonan
            // 
            this.lbl_tenmonan.AutoSize = true;
            this.lbl_tenmonan.Location = new System.Drawing.Point(20, 97);
            this.lbl_tenmonan.Name = "lbl_tenmonan";
            this.lbl_tenmonan.Size = new System.Drawing.Size(75, 16);
            this.lbl_tenmonan.TabIndex = 5;
            this.lbl_tenmonan.Text = "Tên Món ăn";
            // 
            // lbl_tennhommonan
            // 
            this.lbl_tennhommonan.AutoSize = true;
            this.lbl_tennhommonan.Location = new System.Drawing.Point(22, 59);
            this.lbl_tennhommonan.Name = "lbl_tennhommonan";
            this.lbl_tennhommonan.Size = new System.Drawing.Size(109, 16);
            this.lbl_tennhommonan.TabIndex = 4;
            this.lbl_tennhommonan.Text = "Tên Nhóm món ăn";
            // 
            // lblMaMonAn
            // 
            this.lblMaMonAn.AutoSize = true;
            this.lblMaMonAn.Location = new System.Drawing.Point(20, 26);
            this.lblMaMonAn.Name = "lblMaMonAn";
            this.lblMaMonAn.Size = new System.Drawing.Size(73, 16);
            this.lblMaMonAn.TabIndex = 3;
            this.lblMaMonAn.Text = "Mã Món ăn";
            // 
            // grb_DSMonAn
            // 
            this.grb_DSMonAn.Controls.Add(this.gvv_DSThucDon);
            this.grb_DSMonAn.Location = new System.Drawing.Point(316, 1);
            this.grb_DSMonAn.Name = "grb_DSMonAn";
            this.grb_DSMonAn.Size = new System.Drawing.Size(547, 251);
            this.grb_DSMonAn.TabIndex = 34;
            this.grb_DSMonAn.TabStop = false;
            this.grb_DSMonAn.Enter += new System.EventHandler(this.grb_DSMonAn_Enter);
            // 
            // gvv_DSThucDon
            // 
            this.gvv_DSThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMA,
            this.MANMA,
            this.TENMA,
            this.DONGIA,
            this.DONVITINH});
            this.gvv_DSThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSThucDon.Location = new System.Drawing.Point(3, 16);
            this.gvv_DSThucDon.Name = "gvv_DSThucDon";
            this.gvv_DSThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSThucDon.Size = new System.Drawing.Size(541, 232);
            this.gvv_DSThucDon.TabIndex = 23;
            this.gvv_DSThucDon.SelectionChanged += new System.EventHandler(this.gvv_DSThucDon_SelectionChanged);
            // 
            // MAMA
            // 
            this.MAMA.DataPropertyName = "MAMA";
            this.MAMA.HeaderText = "Mã Món Ăn";
            this.MAMA.Name = "MAMA";
            // 
            // MANMA
            // 
            this.MANMA.DataPropertyName = "MANMA";
            this.MANMA.HeaderText = "Mã Nhóm Món Ăn";
            this.MANMA.Name = "MANMA";
            // 
            // TENMA
            // 
            this.TENMA.DataPropertyName = "TENMA";
            this.TENMA.HeaderText = "Tên Món Ăn";
            this.TENMA.Name = "TENMA";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // DONVITINH
            // 
            this.DONVITINH.DataPropertyName = "DONVITINH";
            this.DONVITINH.HeaderText = "Đơn Vị Tính";
            this.DONVITINH.Name = "DONVITINH";
            // 
            // lblDSMonAn
            // 
            this.lblDSMonAn.AutoSize = true;
            this.lblDSMonAn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSMonAn.Location = new System.Drawing.Point(500, -24);
            this.lblDSMonAn.Name = "lblDSMonAn";
            this.lblDSMonAn.Size = new System.Drawing.Size(170, 22);
            this.lblDSMonAn.TabIndex = 35;
            this.lblDSMonAn.Text = "Danh Sách Món Ăn";
            // 
            // lblQLMonAn
            // 
            this.lblQLMonAn.AutoSize = true;
            this.lblQLMonAn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLMonAn.Location = new System.Drawing.Point(67, -24);
            this.lblQLMonAn.Name = "lblQLMonAn";
            this.lblQLMonAn.Size = new System.Drawing.Size(152, 22);
            this.lblQLMonAn.TabIndex = 32;
            this.lblQLMonAn.Text = "Quản Lý Món Ăn";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_xoa.BackgroundImage = global::QL_NHAHANG.Properties.Resources.close;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(201, 270);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 33);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_sua.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Actions_edit_redo_icon;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(110, 270);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 33);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_them.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Button_Add_icon;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(22, 270);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 33);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef022;
            this.ClientSize = new System.Drawing.Size(932, 332);
            this.Controls.Add(this.gb_qlthucdon);
            this.Controls.Add(this.grb_DSMonAn);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lblDSMonAn);
            this.Controls.Add(this.lblQLMonAn);
            this.Name = "frmMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Món ăn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMonAn_FormClosing);
            this.Load += new System.EventHandler(this.frmMonAn_Load);
            this.gb_qlthucdon.ResumeLayout(false);
            this.gb_qlthucdon.PerformLayout();
            this.grb_DSMonAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboLoaiTD;
        private System.Windows.Forms.TextBox txt_dongiaton;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.TextBox txt_tenthucdon;
        private System.Windows.Forms.TextBox txt_mathucdon;
        private System.Windows.Forms.ListBox lsb_trangthai;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.GroupBox gb_qlthucdon;
        private System.Windows.Forms.Label lbl_dongiaton;
        private System.Windows.Forms.Label lbl_donvitinh;
        private System.Windows.Forms.Label lbl_tenmonan;
        private System.Windows.Forms.Label lbl_tennhommonan;
        private System.Windows.Forms.Label lblMaMonAn;
        private System.Windows.Forms.GroupBox grb_DSMonAn;
        private System.Windows.Forms.DataGridView gvv_DSThucDon;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lblDSMonAn;
        private System.Windows.Forms.Label lblQLMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}