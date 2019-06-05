namespace QL_NHAHANG
{
    partial class frmNhaCungCap
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
            this.gvv_DSNhaCC = new System.Windows.Forms.DataGridView();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_DSNhaCC = new System.Windows.Forms.GroupBox();
            this.txt_MaNhaCungCap = new System.Windows.Forms.TextBox();
            this.lbl_MaNhaCungCap = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.btn__xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSNhaCC)).BeginInit();
            this.gpb_DSNhaCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // gvv_DSNhaCC
            // 
            this.gvv_DSNhaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvv_DSNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANCC,
            this.TENNCC,
            this.DIACHI});
            this.gvv_DSNhaCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSNhaCC.Location = new System.Drawing.Point(3, 19);
            this.gvv_DSNhaCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvv_DSNhaCC.Name = "gvv_DSNhaCC";
            this.gvv_DSNhaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSNhaCC.Size = new System.Drawing.Size(479, 195);
            this.gvv_DSNhaCC.TabIndex = 23;
            this.gvv_DSNhaCC.SelectionChanged += new System.EventHandler(this.gvv_DSNhaCC_SelectionChanged);
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MANCC.Name = "MANCC";
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TENNCC.Name = "TENNCC";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(182, 48);
            this.txt_tenncc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(237, 22);
            this.txt_tenncc.TabIndex = 1;
            this.txt_tenncc.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tên Nhà cung cấp";
            // 
            // gpb_DSNhaCC
            // 
            this.gpb_DSNhaCC.Controls.Add(this.gvv_DSNhaCC);
            this.gpb_DSNhaCC.Location = new System.Drawing.Point(52, 182);
            this.gpb_DSNhaCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_DSNhaCC.Name = "gpb_DSNhaCC";
            this.gpb_DSNhaCC.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_DSNhaCC.Size = new System.Drawing.Size(485, 218);
            this.gpb_DSNhaCC.TabIndex = 55;
            this.gpb_DSNhaCC.TabStop = false;
            this.gpb_DSNhaCC.Enter += new System.EventHandler(this.gpb_DSNhaCC_Enter);
            // 
            // txt_MaNhaCungCap
            // 
            this.txt_MaNhaCungCap.Location = new System.Drawing.Point(182, 16);
            this.txt_MaNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNhaCungCap.Name = "txt_MaNhaCungCap";
            this.txt_MaNhaCungCap.Size = new System.Drawing.Size(237, 22);
            this.txt_MaNhaCungCap.TabIndex = 0;
            this.txt_MaNhaCungCap.Leave += new System.EventHandler(this.txt_MaNhaCungCap_Leave);
            // 
            // lbl_MaNhaCungCap
            // 
            this.lbl_MaNhaCungCap.AutoSize = true;
            this.lbl_MaNhaCungCap.Location = new System.Drawing.Point(52, 20);
            this.lbl_MaNhaCungCap.Name = "lbl_MaNhaCungCap";
            this.lbl_MaNhaCungCap.Size = new System.Drawing.Size(106, 16);
            this.lbl_MaNhaCungCap.TabIndex = 56;
            this.lbl_MaNhaCungCap.Text = "Mã Nhà cung cấp";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(182, 81);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(237, 22);
            this.txt_DiaChi.TabIndex = 2;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(52, 85);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(48, 16);
            this.lbl_DiaChi.TabIndex = 48;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // btn__xoa
            // 
            this.btn__xoa.BackgroundImage = global::QL_NHAHANG.Properties.Resources.close;
            this.btn__xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn__xoa.Location = new System.Drawing.Point(343, 139);
            this.btn__xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn__xoa.Name = "btn__xoa";
            this.btn__xoa.Size = new System.Drawing.Size(77, 41);
            this.btn__xoa.TabIndex = 5;
            this.btn__xoa.Text = "Xóa";
            this.btn__xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn__xoa.UseVisualStyleBackColor = true;
            this.btn__xoa.Click += new System.EventHandler(this.btn__xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Actions_edit_redo_icon;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sua.Location = new System.Drawing.Point(262, 139);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(73, 41);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Button_Add_icon;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Location = new System.Drawing.Point(178, 139);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(77, 41);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef0221;
            this.ClientSize = new System.Drawing.Size(593, 417);
            this.Controls.Add(this.txt_tenncc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpb_DSNhaCC);
            this.Controls.Add(this.txt_MaNhaCungCap);
            this.Controls.Add(this.lbl_MaNhaCungCap);
            this.Controls.Add(this.btn__xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.lbl_DiaChi);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhaCungCap_FormClosing);
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSNhaCC)).EndInit();
            this.gpb_DSNhaCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvv_DSNhaCC;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_DSNhaCC;
        private System.Windows.Forms.TextBox txt_MaNhaCungCap;
        private System.Windows.Forms.Label lbl_MaNhaCungCap;
        private System.Windows.Forms.Button btn__xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}