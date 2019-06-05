namespace QL_NHAHANG
{
    partial class frmDinhLuong
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
            this.grbDanhSachMonAn = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Chon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDinhLuongMonAn = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMonAn = new System.Windows.Forms.ComboBox();
            this.lblMonan = new System.Windows.Forms.Label();
            this.grbDanhSachMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbDinhLuongMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDanhSachMonAn
            // 
            this.grbDanhSachMonAn.Controls.Add(this.dataGridView1);
            this.grbDanhSachMonAn.ForeColor = System.Drawing.Color.Blue;
            this.grbDanhSachMonAn.Location = new System.Drawing.Point(7, 8);
            this.grbDanhSachMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.grbDanhSachMonAn.Name = "grbDanhSachMonAn";
            this.grbDanhSachMonAn.Padding = new System.Windows.Forms.Padding(2);
            this.grbDanhSachMonAn.Size = new System.Drawing.Size(299, 246);
            this.grbDanhSachMonAn.TabIndex = 0;
            this.grbDanhSachMonAn.TabStop = false;
            this.grbDanhSachMonAn.Text = "Danh sách nguyên liệu";
            this.grbDanhSachMonAn.Enter += new System.EventHandler(this.grbDanhSachMonAn_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.MaNguyenLieu,
            this.DoViTinh,
            this.TenNguyenLieu});
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(297, 217);
            this.dataGridView1.TabIndex = 2;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            // 
            // DoViTinh
            // 
            this.DoViTinh.HeaderText = "Đơn Vị Tính";
            this.DoViTinh.Name = "DoViTinh";
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.HeaderText = "Tên Nguyên Liệu";
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            // 
            // grbDinhLuongMonAn
            // 
            this.grbDinhLuongMonAn.Controls.Add(this.dataGridView2);
            this.grbDinhLuongMonAn.Controls.Add(this.cmbMonAn);
            this.grbDinhLuongMonAn.Controls.Add(this.lblMonan);
            this.grbDinhLuongMonAn.ForeColor = System.Drawing.Color.Blue;
            this.grbDinhLuongMonAn.Location = new System.Drawing.Point(309, 8);
            this.grbDinhLuongMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.grbDinhLuongMonAn.Name = "grbDinhLuongMonAn";
            this.grbDinhLuongMonAn.Padding = new System.Windows.Forms.Padding(2);
            this.grbDinhLuongMonAn.Size = new System.Drawing.Size(367, 246);
            this.grbDinhLuongMonAn.TabIndex = 1;
            this.grbDinhLuongMonAn.TabStop = false;
            this.grbDinhLuongMonAn.Text = "Định lượng món ăn";
            this.grbDinhLuongMonAn.Enter += new System.EventHandler(this.grbDinhLuongMonAn_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa});
            this.dataGridView2.Location = new System.Drawing.Point(14, 45);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(350, 197);
            this.dataGridView2.TabIndex = 2;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            // 
            // cmbMonAn
            // 
            this.cmbMonAn.FormattingEnabled = true;
            this.cmbMonAn.Items.AddRange(new object[] {
            "Cháo vịt",
            "Cơm gà",
            "Cua rang me",
            "Ốc móng tay xào rau muống",
            "Nghêu hấp xã"});
            this.cmbMonAn.Location = new System.Drawing.Point(88, 23);
            this.cmbMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonAn.Name = "cmbMonAn";
            this.cmbMonAn.Size = new System.Drawing.Size(277, 21);
            this.cmbMonAn.TabIndex = 2;
            // 
            // lblMonan
            // 
            this.lblMonan.AutoSize = true;
            this.lblMonan.ForeColor = System.Drawing.Color.Black;
            this.lblMonan.Location = new System.Drawing.Point(11, 25);
            this.lblMonan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonan.Name = "lblMonan";
            this.lblMonan.Size = new System.Drawing.Size(43, 13);
            this.lblMonan.TabIndex = 3;
            this.lblMonan.Text = "Món ăn";
            // 
            // frmDinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef0221;
            this.ClientSize = new System.Drawing.Size(679, 261);
            this.Controls.Add(this.grbDinhLuongMonAn);
            this.Controls.Add(this.grbDanhSachMonAn);
            this.Name = "frmDinhLuong";
            this.Text = "frmDinhLuong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDinhLuong_FormClosing);
            this.grbDanhSachMonAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbDinhLuongMonAn.ResumeLayout(false);
            this.grbDinhLuongMonAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachMonAn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenLieu;
        private System.Windows.Forms.GroupBox grbDinhLuongMonAn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xoa;
        private System.Windows.Forms.ComboBox cmbMonAn;
        private System.Windows.Forms.Label lblMonan;
    }
}