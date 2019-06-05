namespace QL_NHAHANG
{
    partial class frmKhachHang
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
            this.gvv_DSKhachHang = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dskh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_QLKH = new System.Windows.Forms.GroupBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_qlkh = new System.Windows.Forms.Label();
            this.gb_dskh = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSKhachHang)).BeginInit();
            this.grb_QLKH.SuspendLayout();
            this.gb_dskh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvv_DSKhachHang
            // 
            this.gvv_DSKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvv_DSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.DIACHI});
            this.gvv_DSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSKhachHang.Location = new System.Drawing.Point(3, 18);
            this.gvv_DSKhachHang.Name = "gvv_DSKhachHang";
            this.gvv_DSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSKhachHang.Size = new System.Drawing.Size(511, 233);
            this.gvv_DSKhachHang.TabIndex = 23;
            this.gvv_DSKhachHang.SelectionChanged += new System.EventHandler(this.gvv_DSKhachHang_SelectionChanged);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.Name = "MAKH";
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên Khách Hàng";
            this.TENKH.Name = "TENKH";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên KH";
            // 
            // lbl_dskh
            // 
            this.lbl_dskh.AutoSize = true;
            this.lbl_dskh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dskh.Location = new System.Drawing.Point(558, 11);
            this.lbl_dskh.Name = "lbl_dskh";
            this.lbl_dskh.Size = new System.Drawing.Size(226, 24);
            this.lbl_dskh.TabIndex = 31;
            this.lbl_dskh.Text = "Danh Sách Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã KH";
            // 
            // grb_QLKH
            // 
            this.grb_QLKH.Controls.Add(this.txt_tenkh);
            this.grb_QLKH.Controls.Add(this.txt_diachi);
            this.grb_QLKH.Controls.Add(this.txt_makh);
            this.grb_QLKH.Controls.Add(this.label1);
            this.grb_QLKH.Controls.Add(this.label2);
            this.grb_QLKH.Controls.Add(this.label3);
            this.grb_QLKH.Location = new System.Drawing.Point(22, 55);
            this.grb_QLKH.Name = "grb_QLKH";
            this.grb_QLKH.Size = new System.Drawing.Size(386, 166);
            this.grb_QLKH.TabIndex = 0;
            this.grb_QLKH.TabStop = false;
            this.grb_QLKH.Enter += new System.EventHandler(this.grb_QLKH_Enter);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(55, 66);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(297, 22);
            this.txt_tenkh.TabIndex = 1;
            this.txt_tenkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(55, 119);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(297, 22);
            this.txt_diachi.TabIndex = 2;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(55, 16);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(297, 22);
            this.txt_makh.TabIndex = 0;
            this.txt_makh.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Địa chỉ";
            // 
            // lbl_qlkh
            // 
            this.lbl_qlkh.AutoSize = true;
            this.lbl_qlkh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlkh.Location = new System.Drawing.Point(93, 14);
            this.lbl_qlkh.Name = "lbl_qlkh";
            this.lbl_qlkh.Size = new System.Drawing.Size(188, 22);
            this.lbl_qlkh.TabIndex = 25;
            this.lbl_qlkh.Text = "Quản Lý Khách Hàng";
            // 
            // gb_dskh
            // 
            this.gb_dskh.Controls.Add(this.gvv_DSKhachHang);
            this.gb_dskh.Location = new System.Drawing.Point(428, 55);
            this.gb_dskh.Name = "gb_dskh";
            this.gb_dskh.Size = new System.Drawing.Size(517, 254);
            this.gb_dskh.TabIndex = 24;
            this.gb_dskh.TabStop = false;
            this.gb_dskh.Enter += new System.EventHandler(this.gb_dskh_Enter);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackgroundImage = global::QL_NHAHANG.Properties.Resources.close;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.Location = new System.Drawing.Point(232, 229);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(87, 42);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Actions_edit_redo_icon;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sua.Location = new System.Drawing.Point(138, 229);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(87, 42);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Button_Add_icon;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Location = new System.Drawing.Point(43, 229);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(87, 42);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef022;
            this.ClientSize = new System.Drawing.Size(968, 336);
            this.Controls.Add(this.lbl_dskh);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.grb_QLKH);
            this.Controls.Add(this.lbl_qlkh);
            this.Controls.Add(this.gb_dskh);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSKhachHang)).EndInit();
            this.grb_QLKH.ResumeLayout(false);
            this.grb_QLKH.PerformLayout();
            this.gb_dskh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvv_DSKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dskh;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grb_QLKH;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_qlkh;
        private System.Windows.Forms.GroupBox gb_dskh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}