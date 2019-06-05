namespace QL_NHAHANG
{
    partial class frmNhomNguyenLieu
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
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lblQLNhomNguyenLieu = new System.Windows.Forms.Label();
            this.lblDSNhomNguyenLieu = new System.Windows.Forms.Label();
            this.gvv_DSLoaiThucDon = new System.Windows.Forms.DataGridView();
            this.MANNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_maloaithucdon = new System.Windows.Forms.TextBox();
            this.grb_QLNhomNguyenLieu = new System.Windows.Forms.GroupBox();
            this.txt_tenloaithucdon = new System.Windows.Forms.TextBox();
            this.lblTenNNL = new System.Windows.Forms.Label();
            this.lbllblMaNNL = new System.Windows.Forms.Label();
            this.grb_dsloaithucdon = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSLoaiThucDon)).BeginInit();
            this.grb_QLNhomNguyenLieu.SuspendLayout();
            this.grb_dsloaithucdon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackgroundImage = global::QL_NHAHANG.Properties.Resources.close;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.Location = new System.Drawing.Point(963, 241);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(77, 39);
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
            this.btn_sua.Location = new System.Drawing.Point(863, 241);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 39);
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
            this.btn_them.Location = new System.Drawing.Point(746, 241);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 39);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lblQLNhomNguyenLieu
            // 
            this.lblQLNhomNguyenLieu.AutoSize = true;
            this.lblQLNhomNguyenLieu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLNhomNguyenLieu.Location = new System.Drawing.Point(696, 27);
            this.lblQLNhomNguyenLieu.Name = "lblQLNhomNguyenLieu";
            this.lblQLNhomNguyenLieu.Size = new System.Drawing.Size(265, 24);
            this.lblQLNhomNguyenLieu.TabIndex = 27;
            this.lblQLNhomNguyenLieu.Text = "Quản Lý Nhóm Nguyên Liệu";
            // 
            // lblDSNhomNguyenLieu
            // 
            this.lblDSNhomNguyenLieu.AutoSize = true;
            this.lblDSNhomNguyenLieu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSNhomNguyenLieu.Location = new System.Drawing.Point(128, 27);
            this.lblDSNhomNguyenLieu.Name = "lblDSNhomNguyenLieu";
            this.lblDSNhomNguyenLieu.Size = new System.Drawing.Size(284, 24);
            this.lblDSNhomNguyenLieu.TabIndex = 24;
            this.lblDSNhomNguyenLieu.Text = "Danh Sách Nhóm Nguyên Liệu";
            // 
            // gvv_DSLoaiThucDon
            // 
            this.gvv_DSLoaiThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvv_DSLoaiThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSLoaiThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANNL,
            this.TENNNL});
            this.gvv_DSLoaiThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSLoaiThucDon.Location = new System.Drawing.Point(3, 19);
            this.gvv_DSLoaiThucDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvv_DSLoaiThucDon.Name = "gvv_DSLoaiThucDon";
            this.gvv_DSLoaiThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSLoaiThucDon.Size = new System.Drawing.Size(522, 208);
            this.gvv_DSLoaiThucDon.TabIndex = 23;
            this.gvv_DSLoaiThucDon.SelectionChanged += new System.EventHandler(this.gvv_DSLoaiThucDon_SelectionChanged);
            // 
            // MANNL
            // 
            this.MANNL.DataPropertyName = "MANNL";
            this.MANNL.HeaderText = "Mã Nhóm Nguyên Liệu";
            this.MANNL.Name = "MANNL";
            // 
            // TENNNL
            // 
            this.TENNNL.DataPropertyName = "TENNNL";
            this.TENNNL.HeaderText = "Tên Nhóm Nguyên Liệu";
            this.TENNNL.Name = "TENNNL";
            // 
            // txt_maloaithucdon
            // 
            this.txt_maloaithucdon.Location = new System.Drawing.Point(177, 44);
            this.txt_maloaithucdon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maloaithucdon.Name = "txt_maloaithucdon";
            this.txt_maloaithucdon.Size = new System.Drawing.Size(293, 22);
            this.txt_maloaithucdon.TabIndex = 0;
            this.txt_maloaithucdon.Leave += new System.EventHandler(this.txt_maloaithucdon_Leave);
            // 
            // grb_QLNhomNguyenLieu
            // 
            this.grb_QLNhomNguyenLieu.Controls.Add(this.txt_tenloaithucdon);
            this.grb_QLNhomNguyenLieu.Controls.Add(this.txt_maloaithucdon);
            this.grb_QLNhomNguyenLieu.Controls.Add(this.lblTenNNL);
            this.grb_QLNhomNguyenLieu.Controls.Add(this.lbllblMaNNL);
            this.grb_QLNhomNguyenLieu.Location = new System.Drawing.Point(595, 79);
            this.grb_QLNhomNguyenLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_QLNhomNguyenLieu.Name = "grb_QLNhomNguyenLieu";
            this.grb_QLNhomNguyenLieu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_QLNhomNguyenLieu.Size = new System.Drawing.Size(500, 133);
            this.grb_QLNhomNguyenLieu.TabIndex = 0;
            this.grb_QLNhomNguyenLieu.TabStop = false;
            this.grb_QLNhomNguyenLieu.Enter += new System.EventHandler(this.grb_QLNhomNguyenLieu_Enter);
            // 
            // txt_tenloaithucdon
            // 
            this.txt_tenloaithucdon.Location = new System.Drawing.Point(177, 89);
            this.txt_tenloaithucdon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenloaithucdon.Name = "txt_tenloaithucdon";
            this.txt_tenloaithucdon.Size = new System.Drawing.Size(293, 22);
            this.txt_tenloaithucdon.TabIndex = 1;
            // 
            // lblTenNNL
            // 
            this.lblTenNNL.AutoSize = true;
            this.lblTenNNL.Location = new System.Drawing.Point(44, 92);
            this.lblTenNNL.Name = "lblTenNNL";
            this.lblTenNNL.Size = new System.Drawing.Size(132, 16);
            this.lblTenNNL.TabIndex = 4;
            this.lblTenNNL.Text = "Tên Nhóm nguyên liệu";
            // 
            // lbllblMaNNL
            // 
            this.lbllblMaNNL.AutoSize = true;
            this.lbllblMaNNL.Location = new System.Drawing.Point(44, 48);
            this.lbllblMaNNL.Name = "lbllblMaNNL";
            this.lbllblMaNNL.Size = new System.Drawing.Size(130, 16);
            this.lbllblMaNNL.TabIndex = 3;
            this.lbllblMaNNL.Text = "Mã Nhóm nguyên liệu";
            // 
            // grb_dsloaithucdon
            // 
            this.grb_dsloaithucdon.Controls.Add(this.gvv_DSLoaiThucDon);
            this.grb_dsloaithucdon.Location = new System.Drawing.Point(16, 79);
            this.grb_dsloaithucdon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_dsloaithucdon.Name = "grb_dsloaithucdon";
            this.grb_dsloaithucdon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_dsloaithucdon.Size = new System.Drawing.Size(528, 231);
            this.grb_dsloaithucdon.TabIndex = 25;
            this.grb_dsloaithucdon.TabStop = false;
            this.grb_dsloaithucdon.Enter += new System.EventHandler(this.grb_dsloaithucdon_Enter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNhomNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef022;
            this.ClientSize = new System.Drawing.Size(1116, 375);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lblQLNhomNguyenLieu);
            this.Controls.Add(this.lblDSNhomNguyenLieu);
            this.Controls.Add(this.grb_QLNhomNguyenLieu);
            this.Controls.Add(this.grb_dsloaithucdon);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhomNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm nguyên liệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhomNguyenLieu_FormClosing);
            this.Load += new System.EventHandler(this.frmNhomNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSLoaiThucDon)).EndInit();
            this.grb_QLNhomNguyenLieu.ResumeLayout(false);
            this.grb_QLNhomNguyenLieu.PerformLayout();
            this.grb_dsloaithucdon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lblQLNhomNguyenLieu;
        private System.Windows.Forms.Label lblDSNhomNguyenLieu;
        private System.Windows.Forms.DataGridView gvv_DSLoaiThucDon;
        private System.Windows.Forms.TextBox txt_maloaithucdon;
        private System.Windows.Forms.GroupBox grb_QLNhomNguyenLieu;
        private System.Windows.Forms.TextBox txt_tenloaithucdon;
        private System.Windows.Forms.Label lblTenNNL;
        private System.Windows.Forms.Label lbllblMaNNL;
        private System.Windows.Forms.GroupBox grb_dsloaithucdon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNNL;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}