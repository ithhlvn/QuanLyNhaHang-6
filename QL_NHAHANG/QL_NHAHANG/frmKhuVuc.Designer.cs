namespace QL_NHAHANG
{
    partial class frmKhuVuc
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
            this.gvv_DSKhuVuc = new System.Windows.Forms.DataGridView();
            this.MAKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_makv = new System.Windows.Forms.Label();
            this.lbl_qlkv = new System.Windows.Forms.Label();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.lbl_dskv = new System.Windows.Forms.Label();
            this.gb_dsKhuvuc = new System.Windows.Forms.GroupBox();
            this.lsb_trangthai = new System.Windows.Forms.ListBox();
            this.lsb_tenkv = new System.Windows.Forms.ListBox();
            this.txt_makv = new System.Windows.Forms.TextBox();
            this.lbl_tenkv = new System.Windows.Forms.Label();
            this.gb_khuvuc = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSKhuVuc)).BeginInit();
            this.gb_dsKhuvuc.SuspendLayout();
            this.gb_khuvuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvv_DSKhuVuc
            // 
            this.gvv_DSKhuVuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvv_DSKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSKhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKV,
            this.TENKV,
            this.TRANGTHAI});
            this.gvv_DSKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSKhuVuc.Location = new System.Drawing.Point(3, 19);
            this.gvv_DSKhuVuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvv_DSKhuVuc.Name = "gvv_DSKhuVuc";
            this.gvv_DSKhuVuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSKhuVuc.Size = new System.Drawing.Size(469, 207);
            this.gvv_DSKhuVuc.TabIndex = 23;
            this.gvv_DSKhuVuc.SelectionChanged += new System.EventHandler(this.gvv_DSKhuVuc_SelectionChanged);
            // 
            // MAKV
            // 
            this.MAKV.DataPropertyName = "MAKV";
            this.MAKV.HeaderText = "Mã Khu Vực";
            this.MAKV.Name = "MAKV";
            // 
            // TENKV
            // 
            this.TENKV.DataPropertyName = "TENKV";
            this.TENKV.HeaderText = "Tên Khu Vực";
            this.TENKV.Name = "TENKV";
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            // 
            // lbl_makv
            // 
            this.lbl_makv.AutoSize = true;
            this.lbl_makv.Location = new System.Drawing.Point(38, 26);
            this.lbl_makv.Name = "lbl_makv";
            this.lbl_makv.Size = new System.Drawing.Size(48, 16);
            this.lbl_makv.TabIndex = 0;
            this.lbl_makv.Text = "Mã KV";
            // 
            // lbl_qlkv
            // 
            this.lbl_qlkv.AutoSize = true;
            this.lbl_qlkv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlkv.Location = new System.Drawing.Point(120, 11);
            this.lbl_qlkv.Name = "lbl_qlkv";
            this.lbl_qlkv.Size = new System.Drawing.Size(156, 24);
            this.lbl_qlkv.TabIndex = 20;
            this.lbl_qlkv.Text = "Quản lý khu vực";
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Location = new System.Drawing.Point(38, 109);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(67, 16);
            this.lbl_trangthai.TabIndex = 3;
            this.lbl_trangthai.Text = "Trạng thái";
            // 
            // lbl_dskv
            // 
            this.lbl_dskv.AutoSize = true;
            this.lbl_dskv.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dskv.Location = new System.Drawing.Point(591, 11);
            this.lbl_dskv.Name = "lbl_dskv";
            this.lbl_dskv.Size = new System.Drawing.Size(194, 24);
            this.lbl_dskv.TabIndex = 21;
            this.lbl_dskv.Text = "Danh Sách Khu Vực";
            // 
            // gb_dsKhuvuc
            // 
            this.gb_dsKhuvuc.Controls.Add(this.gvv_DSKhuVuc);
            this.gb_dsKhuvuc.Location = new System.Drawing.Point(436, 52);
            this.gb_dsKhuvuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_dsKhuvuc.Name = "gb_dsKhuvuc";
            this.gb_dsKhuvuc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_dsKhuvuc.Size = new System.Drawing.Size(475, 230);
            this.gb_dsKhuvuc.TabIndex = 19;
            this.gb_dsKhuvuc.TabStop = false;
            this.gb_dsKhuvuc.Enter += new System.EventHandler(this.gb_dsKhuvuc_Enter);
            // 
            // lsb_trangthai
            // 
            this.lsb_trangthai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_trangthai.FormattingEnabled = true;
            this.lsb_trangthai.ItemHeight = 18;
            this.lsb_trangthai.Items.AddRange(new object[] {
            "Hoạt động",
            "Tạm nghỉ"});
            this.lsb_trangthai.Location = new System.Drawing.Point(103, 109);
            this.lsb_trangthai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsb_trangthai.Name = "lsb_trangthai";
            this.lsb_trangthai.Size = new System.Drawing.Size(180, 22);
            this.lsb_trangthai.TabIndex = 2;
            // 
            // lsb_tenkv
            // 
            this.lsb_tenkv.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_tenkv.FormattingEnabled = true;
            this.lsb_tenkv.ItemHeight = 18;
            this.lsb_tenkv.Items.AddRange(new object[] {
            "Trong nhà",
            "Sân vườn",
            "Sân thượng",
            "Tầng 2",
            "Tầng 3"});
            this.lsb_tenkv.Location = new System.Drawing.Point(103, 66);
            this.lsb_tenkv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsb_tenkv.Name = "lsb_tenkv";
            this.lsb_tenkv.Size = new System.Drawing.Size(180, 22);
            this.lsb_tenkv.TabIndex = 1;
            // 
            // txt_makv
            // 
            this.txt_makv.Location = new System.Drawing.Point(103, 23);
            this.txt_makv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_makv.Name = "txt_makv";
            this.txt_makv.Size = new System.Drawing.Size(180, 22);
            this.txt_makv.TabIndex = 0;
            this.txt_makv.Leave += new System.EventHandler(this.txt_makv_Leave);
            // 
            // lbl_tenkv
            // 
            this.lbl_tenkv.AutoSize = true;
            this.lbl_tenkv.Location = new System.Drawing.Point(38, 67);
            this.lbl_tenkv.Name = "lbl_tenkv";
            this.lbl_tenkv.Size = new System.Drawing.Size(50, 16);
            this.lbl_tenkv.TabIndex = 2;
            this.lbl_tenkv.Text = "Tên KV";
            // 
            // gb_khuvuc
            // 
            this.gb_khuvuc.Controls.Add(this.lsb_trangthai);
            this.gb_khuvuc.Controls.Add(this.lsb_tenkv);
            this.gb_khuvuc.Controls.Add(this.txt_makv);
            this.gb_khuvuc.Controls.Add(this.lbl_trangthai);
            this.gb_khuvuc.Controls.Add(this.lbl_tenkv);
            this.gb_khuvuc.Controls.Add(this.lbl_makv);
            this.gb_khuvuc.Location = new System.Drawing.Point(34, 52);
            this.gb_khuvuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_khuvuc.Name = "gb_khuvuc";
            this.gb_khuvuc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_khuvuc.Size = new System.Drawing.Size(339, 160);
            this.gb_khuvuc.TabIndex = 0;
            this.gb_khuvuc.TabStop = false;
            this.gb_khuvuc.Enter += new System.EventHandler(this.gb_khuvuc_Enter);
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Actions_edit_redo_icon;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sua.Location = new System.Drawing.Point(227, 236);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(90, 33);
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
            this.btn_them.Location = new System.Drawing.Point(103, 236);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 33);
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
            // frmKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef0221;
            this.ClientSize = new System.Drawing.Size(985, 315);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lbl_qlkv);
            this.Controls.Add(this.lbl_dskv);
            this.Controls.Add(this.gb_dsKhuvuc);
            this.Controls.Add(this.gb_khuvuc);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khu vực";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhuVuc_FormClosing);
            this.Load += new System.EventHandler(this.frmKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSKhuVuc)).EndInit();
            this.gb_dsKhuvuc.ResumeLayout(false);
            this.gb_khuvuc.ResumeLayout(false);
            this.gb_khuvuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridView gvv_DSKhuVuc;
        private System.Windows.Forms.Label lbl_makv;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_qlkv;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label lbl_dskv;
        private System.Windows.Forms.GroupBox gb_dsKhuvuc;
        private System.Windows.Forms.ListBox lsb_trangthai;
        private System.Windows.Forms.ListBox lsb_tenkv;
        private System.Windows.Forms.TextBox txt_makv;
        private System.Windows.Forms.Label lbl_tenkv;
        private System.Windows.Forms.GroupBox gb_khuvuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}