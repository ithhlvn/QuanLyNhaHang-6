namespace QL_NHAHANG
{
    partial class frmNguyenLieu
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
            this.gb_qlnguyenlieu = new System.Windows.Forms.GroupBox();
            this.cboLoainl = new System.Windows.Forms.ComboBox();
            this.txt_dongiaton = new System.Windows.Forms.TextBox();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_tenbl = new System.Windows.Forms.TextBox();
            this.txt_nl = new System.Windows.Forms.TextBox();
            this.lbl_dongiaton = new System.Windows.Forms.Label();
            this.lbl_donvitinh = new System.Windows.Forms.Label();
            this.lbl_tennguyenlieu = new System.Windows.Forms.Label();
            this.lbl_tennhomnguyenlieu = new System.Windows.Forms.Label();
            this.lbl_manguyenlieu = new System.Windows.Forms.Label();
            this.gvv_DSThucDon = new System.Windows.Forms.DataGridView();
            this.MANL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_DSNguyenLieu = new System.Windows.Forms.GroupBox();
            this.lbl_dsthucdon = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lblQLNguyenLieu = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_qlnguyenlieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSThucDon)).BeginInit();
            this.grb_DSNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_qlnguyenlieu
            // 
            this.gb_qlnguyenlieu.Controls.Add(this.cboLoainl);
            this.gb_qlnguyenlieu.Controls.Add(this.txt_dongiaton);
            this.gb_qlnguyenlieu.Controls.Add(this.txt_dvt);
            this.gb_qlnguyenlieu.Controls.Add(this.txt_tenbl);
            this.gb_qlnguyenlieu.Controls.Add(this.txt_nl);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_dongiaton);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_donvitinh);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_tennguyenlieu);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_tennhomnguyenlieu);
            this.gb_qlnguyenlieu.Controls.Add(this.lbl_manguyenlieu);
            this.gb_qlnguyenlieu.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_qlnguyenlieu.Location = new System.Drawing.Point(12, 34);
            this.gb_qlnguyenlieu.Name = "gb_qlnguyenlieu";
            this.gb_qlnguyenlieu.Size = new System.Drawing.Size(337, 251);
            this.gb_qlnguyenlieu.TabIndex = 1;
            this.gb_qlnguyenlieu.TabStop = false;
            this.gb_qlnguyenlieu.Enter += new System.EventHandler(this.gb_qlnguyenlieu_Enter);
            // 
            // cboLoainl
            // 
            this.cboLoainl.FormattingEnabled = true;
            this.cboLoainl.Location = new System.Drawing.Point(164, 58);
            this.cboLoainl.Name = "cboLoainl";
            this.cboLoainl.Size = new System.Drawing.Size(151, 24);
            this.cboLoainl.TabIndex = 1;
            // 
            // txt_dongiaton
            // 
            this.txt_dongiaton.Location = new System.Drawing.Point(164, 167);
            this.txt_dongiaton.Name = "txt_dongiaton";
            this.txt_dongiaton.Size = new System.Drawing.Size(151, 22);
            this.txt_dongiaton.TabIndex = 4;
            this.txt_dongiaton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dongiaton_KeyPress);
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(164, 132);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(151, 22);
            this.txt_dvt.TabIndex = 3;
            // 
            // txt_tenbl
            // 
            this.txt_tenbl.Location = new System.Drawing.Point(164, 95);
            this.txt_tenbl.Name = "txt_tenbl";
            this.txt_tenbl.Size = new System.Drawing.Size(151, 22);
            this.txt_tenbl.TabIndex = 2;
            // 
            // txt_nl
            // 
            this.txt_nl.Location = new System.Drawing.Point(164, 21);
            this.txt_nl.Name = "txt_nl";
            this.txt_nl.Size = new System.Drawing.Size(151, 22);
            this.txt_nl.TabIndex = 0;
            this.txt_nl.Leave += new System.EventHandler(this.txt_nl_Leave);
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
            // lbl_tennguyenlieu
            // 
            this.lbl_tennguyenlieu.AutoSize = true;
            this.lbl_tennguyenlieu.Location = new System.Drawing.Point(20, 97);
            this.lbl_tennguyenlieu.Name = "lbl_tennguyenlieu";
            this.lbl_tennguyenlieu.Size = new System.Drawing.Size(98, 16);
            this.lbl_tennguyenlieu.TabIndex = 5;
            this.lbl_tennguyenlieu.Text = "Tên Nguyên liệu";
            // 
            // lbl_tennhomnguyenlieu
            // 
            this.lbl_tennhomnguyenlieu.AutoSize = true;
            this.lbl_tennhomnguyenlieu.Location = new System.Drawing.Point(20, 61);
            this.lbl_tennhomnguyenlieu.Name = "lbl_tennhomnguyenlieu";
            this.lbl_tennhomnguyenlieu.Size = new System.Drawing.Size(132, 16);
            this.lbl_tennhomnguyenlieu.TabIndex = 4;
            this.lbl_tennhomnguyenlieu.Text = "Tên Nhóm nguyên liệu";
            // 
            // lbl_manguyenlieu
            // 
            this.lbl_manguyenlieu.AutoSize = true;
            this.lbl_manguyenlieu.Location = new System.Drawing.Point(20, 26);
            this.lbl_manguyenlieu.Name = "lbl_manguyenlieu";
            this.lbl_manguyenlieu.Size = new System.Drawing.Size(96, 16);
            this.lbl_manguyenlieu.TabIndex = 3;
            this.lbl_manguyenlieu.Text = "Mã Nguyên liệu";
            // 
            // gvv_DSThucDon
            // 
            this.gvv_DSThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANL,
            this.MANNL,
            this.TENNL,
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
            // MANL
            // 
            this.MANL.DataPropertyName = "MANL";
            this.MANL.HeaderText = "Mã Nguyên Liệu";
            this.MANL.Name = "MANL";
            // 
            // MANNL
            // 
            this.MANNL.DataPropertyName = "MANNL";
            this.MANNL.HeaderText = "Mã Nhóm Nguyên Liệu";
            this.MANNL.Name = "MANNL";
            // 
            // TENNL
            // 
            this.TENNL.DataPropertyName = "TENNL";
            this.TENNL.HeaderText = "Tên Nguyên Liệu";
            this.TENNL.Name = "TENNL";
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
            // grb_DSNguyenLieu
            // 
            this.grb_DSNguyenLieu.Controls.Add(this.gvv_DSThucDon);
            this.grb_DSNguyenLieu.Location = new System.Drawing.Point(355, 34);
            this.grb_DSNguyenLieu.Name = "grb_DSNguyenLieu";
            this.grb_DSNguyenLieu.Size = new System.Drawing.Size(547, 251);
            this.grb_DSNguyenLieu.TabIndex = 43;
            this.grb_DSNguyenLieu.TabStop = false;
            this.grb_DSNguyenLieu.Enter += new System.EventHandler(this.grb_DSNguyenLieu_Enter);
            // 
            // lbl_dsthucdon
            // 
            this.lbl_dsthucdon.AutoSize = true;
            this.lbl_dsthucdon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsthucdon.Location = new System.Drawing.Point(539, 9);
            this.lbl_dsthucdon.Name = "lbl_dsthucdon";
            this.lbl_dsthucdon.Size = new System.Drawing.Size(207, 22);
            this.lbl_dsthucdon.TabIndex = 44;
            this.lbl_dsthucdon.Text = "Danh Sách Nguyên Liệu";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_xoa.BackgroundImage = global::QL_NHAHANG.Properties.Resources.close;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(240, 291);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 34);
            this.btn_xoa.TabIndex = 4;
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
            this.btn_sua.Location = new System.Drawing.Point(149, 291);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 34);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_them.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Add_Folder_icon;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(61, 291);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 34);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lblQLNguyenLieu
            // 
            this.lblQLNguyenLieu.AutoSize = true;
            this.lblQLNguyenLieu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLNguyenLieu.Location = new System.Drawing.Point(106, 9);
            this.lblQLNguyenLieu.Name = "lblQLNguyenLieu";
            this.lblQLNguyenLieu.Size = new System.Drawing.Size(189, 22);
            this.lblQLNguyenLieu.TabIndex = 41;
            this.lblQLNguyenLieu.Text = "Quản Lý Nguyên Liệu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef022;
            this.ClientSize = new System.Drawing.Size(941, 357);
            this.Controls.Add(this.gb_qlnguyenlieu);
            this.Controls.Add(this.grb_DSNguyenLieu);
            this.Controls.Add(this.lbl_dsthucdon);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lblQLNguyenLieu);
            this.Name = "frmNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguyên liệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNguyenLieu_FormClosing);
            this.Load += new System.EventHandler(this.frmNguyenLieu_Load);
            this.gb_qlnguyenlieu.ResumeLayout(false);
            this.gb_qlnguyenlieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSThucDon)).EndInit();
            this.grb_DSNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_qlnguyenlieu;
        private System.Windows.Forms.ComboBox cboLoainl;
        private System.Windows.Forms.TextBox txt_dongiaton;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.TextBox txt_tenbl;
        private System.Windows.Forms.TextBox txt_nl;
        private System.Windows.Forms.Label lbl_dongiaton;
        private System.Windows.Forms.Label lbl_donvitinh;
        private System.Windows.Forms.Label lbl_tennguyenlieu;
        private System.Windows.Forms.Label lbl_tennhomnguyenlieu;
        private System.Windows.Forms.Label lbl_manguyenlieu;
        private System.Windows.Forms.DataGridView gvv_DSThucDon;
        private System.Windows.Forms.GroupBox grb_DSNguyenLieu;
        private System.Windows.Forms.Label lbl_dsthucdon;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lblQLNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}