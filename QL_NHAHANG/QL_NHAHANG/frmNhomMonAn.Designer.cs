namespace QL_NHAHANG
{
    partial class frmNhomMonAn
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
            this.txtTenNMA = new System.Windows.Forms.TextBox();
            this.txtMaNMA = new System.Windows.Forms.TextBox();
            this.lbl_TenNMA = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MANMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_MaNMA = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNMA
            // 
            this.txtTenNMA.Location = new System.Drawing.Point(149, 63);
            this.txtTenNMA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNMA.Name = "txtTenNMA";
            this.txtTenNMA.Size = new System.Drawing.Size(257, 22);
            this.txtTenNMA.TabIndex = 1;
            // 
            // txtMaNMA
            // 
            this.txtMaNMA.Location = new System.Drawing.Point(149, 18);
            this.txtMaNMA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNMA.Name = "txtMaNMA";
            this.txtMaNMA.Size = new System.Drawing.Size(257, 22);
            this.txtMaNMA.TabIndex = 0;
            this.txtMaNMA.Leave += new System.EventHandler(this.txtMaNMA_Leave);
            // 
            // lbl_TenNMA
            // 
            this.lbl_TenNMA.AutoSize = true;
            this.lbl_TenNMA.Location = new System.Drawing.Point(30, 66);
            this.lbl_TenNMA.Name = "lbl_TenNMA";
            this.lbl_TenNMA.Size = new System.Drawing.Size(88, 16);
            this.lbl_TenNMA.TabIndex = 37;
            this.lbl_TenNMA.Text = "Tên thực đơn :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANMA,
            this.TENNMA});
            this.dataGridView1.Location = new System.Drawing.Point(37, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(556, 241);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MANMA
            // 
            this.MANMA.DataPropertyName = "MANMA";
            this.MANMA.HeaderText = "Mã Thực Đơn";
            this.MANMA.Name = "MANMA";
            // 
            // TENNMA
            // 
            this.TENNMA.DataPropertyName = "TENNMA";
            this.TENNMA.HeaderText = "Tên Thực Đơn";
            this.TENNMA.Name = "TENNMA";
            // 
            // lbl_MaNMA
            // 
            this.lbl_MaNMA.AutoSize = true;
            this.lbl_MaNMA.Location = new System.Drawing.Point(34, 22);
            this.lbl_MaNMA.Name = "lbl_MaNMA";
            this.lbl_MaNMA.Size = new System.Drawing.Size(114, 16);
            this.lbl_MaNMA.TabIndex = 35;
            this.lbl_MaNMA.Text = "Mã Nhóm món ăn :";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackgroundImage = global::QL_NHAHANG.Properties.Resources.close;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Xoa.Location = new System.Drawing.Point(372, 110);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(105, 43);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Actions_edit_redo_icon;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sua.Location = new System.Drawing.Point(260, 110);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(105, 43);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Button_Add_icon;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Them.Location = new System.Drawing.Point(148, 110);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(105, 43);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNhomMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef022;
            this.ClientSize = new System.Drawing.Size(637, 430);
            this.Controls.Add(this.txtTenNMA);
            this.Controls.Add(this.txtMaNMA);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.lbl_TenNMA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_MaNMA);
            this.Controls.Add(this.btn_Them);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhomMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm món ăn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhomMonAn_FormClosing);
            this.Load += new System.EventHandler(this.frmNhomMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNMA;
        private System.Windows.Forms.TextBox txtMaNMA;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label lbl_TenNMA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_MaNMA;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNMA;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}