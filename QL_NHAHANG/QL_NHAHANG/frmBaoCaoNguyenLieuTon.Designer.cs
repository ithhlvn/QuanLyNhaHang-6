namespace QL_NHAHANG
{
    partial class frmBaoCaoNguyenLieuTon
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNGUYENLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNguyenlieuton = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNhomNguyenLieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TENNGUYENLIEU,
            this.DONVITINH,
            this.SOLUONG,
            this.TONGTIEN});
            this.dataGridView1.Location = new System.Drawing.Point(34, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 177);
            this.dataGridView1.TabIndex = 11;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // TENNGUYENLIEU
            // 
            this.TENNGUYENLIEU.HeaderText = "TÊN NGUYÊN LIỆU";
            this.TENNGUYENLIEU.Name = "TENNGUYENLIEU";
            this.TENNGUYENLIEU.Width = 150;
            // 
            // DONVITINH
            // 
            this.DONVITINH.HeaderText = "ĐƠN VỊ TÍNH";
            this.DONVITINH.Name = "DONVITINH";
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.HeaderText = "TỔNG TIỀN";
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // lblNguyenlieuton
            // 
            this.lblNguyenlieuton.AutoSize = true;
            this.lblNguyenlieuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguyenlieuton.Location = new System.Drawing.Point(140, 8);
            this.lblNguyenlieuton.Name = "lblNguyenlieuton";
            this.lblNguyenlieuton.Size = new System.Drawing.Size(319, 16);
            this.lblNguyenlieuton.TabIndex = 13;
            this.lblNguyenlieuton.Text = "BÁO CÁO NGUYÊN LIỆU TỒN TRONG NGÀY";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // lblNhomNguyenLieu
            // 
            this.lblNhomNguyenLieu.AutoSize = true;
            this.lblNhomNguyenLieu.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomNguyenLieu.Location = new System.Drawing.Point(32, 52);
            this.lblNhomNguyenLieu.Name = "lblNhomNguyenLieu";
            this.lblNhomNguyenLieu.Size = new System.Drawing.Size(108, 16);
            this.lblNhomNguyenLieu.TabIndex = 9;
            this.lblNhomNguyenLieu.Text = "Nhóm nguyên liệu";
            // 
            // frmBaoCaoNguyenLieuTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 299);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNguyenlieuton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNhomNguyenLieu);
            this.Name = "frmBaoCaoNguyenLieuTon";
            this.Text = "frmBaoCaoNguyenLieuTon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaoCaoNguyenLieuTon_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNGUYENLIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.Label lblNguyenlieuton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNhomNguyenLieu;
    }
}