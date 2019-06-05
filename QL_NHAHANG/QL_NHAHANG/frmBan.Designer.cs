namespace QL_NHAHANG
{
    partial class frmBan
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
            this.txt_tenban = new System.Windows.Forms.TextBox();
            this.txt_maban = new System.Windows.Forms.TextBox();
            this.lsb_tenkv = new System.Windows.Forms.ListBox();
            this.lsb_trangthai = new System.Windows.Forms.ListBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.lbl_tenban = new System.Windows.Forms.Label();
            this.lbl_tenkv = new System.Windows.Forms.Label();
            this.lbl_maban = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_dsBan = new System.Windows.Forms.Label();
            this.grb_ban = new System.Windows.Forms.GroupBox();
            this.lbl_qlban = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tenban
            // 
            this.txt_tenban.Location = new System.Drawing.Point(127, 106);
            this.txt_tenban.Name = "txt_tenban";
            this.txt_tenban.Size = new System.Drawing.Size(188, 20);
            this.txt_tenban.TabIndex = 2;
            this.txt_tenban.TextChanged += new System.EventHandler(this.txt_tenban_TextChanged);
            // 
            // txt_maban
            // 
            this.txt_maban.Location = new System.Drawing.Point(127, 30);
            this.txt_maban.Name = "txt_maban";
            this.txt_maban.Size = new System.Drawing.Size(188, 20);
            this.txt_maban.TabIndex = 0;
            this.txt_maban.TextChanged += new System.EventHandler(this.txt_maban_TextChanged);
            this.txt_maban.Leave += new System.EventHandler(this.txt_maban_Leave);
            // 
            // lsb_tenkv
            // 
            this.lsb_tenkv.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_tenkv.FormattingEnabled = true;
            this.lsb_tenkv.ItemHeight = 18;
            this.lsb_tenkv.Items.AddRange(new object[] {
            "Trong nhà",
            "Sân thượng",
            "Sân vườn",
            "Tầng 3",
            "Tầng 2"});
            this.lsb_tenkv.Location = new System.Drawing.Point(127, 71);
            this.lsb_tenkv.Name = "lsb_tenkv";
            this.lsb_tenkv.Size = new System.Drawing.Size(188, 22);
            this.lsb_tenkv.TabIndex = 1;
            // 
            // lsb_trangthai
            // 
            this.lsb_trangthai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_trangthai.FormattingEnabled = true;
            this.lsb_trangthai.ItemHeight = 18;
            this.lsb_trangthai.Items.AddRange(new object[] {
            "Còn trống",
            "Đã có khách"});
            this.lsb_trangthai.Location = new System.Drawing.Point(127, 145);
            this.lsb_trangthai.Name = "lsb_trangthai";
            this.lsb_trangthai.Size = new System.Drawing.Size(188, 22);
            this.lsb_trangthai.TabIndex = 3;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangthai.Location = new System.Drawing.Point(23, 149);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(67, 16);
            this.lbl_trangthai.TabIndex = 7;
            this.lbl_trangthai.Text = "Trạng thái";
            // 
            // lbl_tenban
            // 
            this.lbl_tenban.AutoSize = true;
            this.lbl_tenban.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenban.Location = new System.Drawing.Point(23, 113);
            this.lbl_tenban.Name = "lbl_tenban";
            this.lbl_tenban.Size = new System.Drawing.Size(53, 16);
            this.lbl_tenban.TabIndex = 5;
            this.lbl_tenban.Text = "Tên bàn";
            // 
            // lbl_tenkv
            // 
            this.lbl_tenkv.AutoSize = true;
            this.lbl_tenkv.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenkv.Location = new System.Drawing.Point(23, 71);
            this.lbl_tenkv.Name = "lbl_tenkv";
            this.lbl_tenkv.Size = new System.Drawing.Size(76, 16);
            this.lbl_tenkv.TabIndex = 4;
            this.lbl_tenkv.Text = "Tên khu vực";
            // 
            // lbl_maban
            // 
            this.lbl_maban.AutoSize = true;
            this.lbl_maban.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maban.Location = new System.Drawing.Point(23, 37);
            this.lbl_maban.Name = "lbl_maban";
            this.lbl_maban.Size = new System.Drawing.Size(51, 16);
            this.lbl_maban.TabIndex = 3;
            this.lbl_maban.Text = "Mã bàn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABAN,
            this.TENBAN,
            this.MAKV,
            this.TRANGTHAI});
            this.dataGridView1.Location = new System.Drawing.Point(7, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 230);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MABAN
            // 
            this.MABAN.DataPropertyName = "MABAN";
            this.MABAN.HeaderText = "Mã Bàn";
            this.MABAN.Name = "MABAN";
            // 
            // TENBAN
            // 
            this.TENBAN.DataPropertyName = "TENBAN";
            this.TENBAN.HeaderText = "Tên Bàn";
            this.TENBAN.Name = "TENBAN";
            // 
            // MAKV
            // 
            this.MAKV.DataPropertyName = "MAKV";
            this.MAKV.HeaderText = "Mã Khu Vực";
            this.MAKV.Name = "MAKV";
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            // 
            // lbl_dsBan
            // 
            this.lbl_dsBan.AutoSize = true;
            this.lbl_dsBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsBan.Location = new System.Drawing.Point(127, 17);
            this.lbl_dsBan.Name = "lbl_dsBan";
            this.lbl_dsBan.Size = new System.Drawing.Size(149, 24);
            this.lbl_dsBan.TabIndex = 20;
            this.lbl_dsBan.Text = "Danh Sách Bàn";
            // 
            // grb_ban
            // 
            this.grb_ban.Controls.Add(this.txt_tenban);
            this.grb_ban.Controls.Add(this.txt_maban);
            this.grb_ban.Controls.Add(this.lsb_tenkv);
            this.grb_ban.Controls.Add(this.lsb_trangthai);
            this.grb_ban.Controls.Add(this.lbl_trangthai);
            this.grb_ban.Controls.Add(this.lbl_tenban);
            this.grb_ban.Controls.Add(this.lbl_tenkv);
            this.grb_ban.Controls.Add(this.lbl_maban);
            this.grb_ban.Location = new System.Drawing.Point(486, 57);
            this.grb_ban.Name = "grb_ban";
            this.grb_ban.Size = new System.Drawing.Size(333, 186);
            this.grb_ban.TabIndex = 1;
            this.grb_ban.TabStop = false;
            this.grb_ban.Enter += new System.EventHandler(this.grb_ban_Enter);
            // 
            // lbl_qlban
            // 
            this.lbl_qlban.AutoSize = true;
            this.lbl_qlban.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlban.Location = new System.Drawing.Point(593, 21);
            this.lbl_qlban.Name = "lbl_qlban";
            this.lbl_qlban.Size = new System.Drawing.Size(130, 24);
            this.lbl_qlban.TabIndex = 18;
            this.lbl_qlban.Text = "Quản Lý Bàn";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackgroundImage = global::QL_NHAHANG.Properties.Resources.close;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(732, 264);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(69, 36);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Actions_edit_redo_icon;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sua.Enabled = false;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(639, 264);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(67, 36);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Button_Add_icon;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Enabled = false;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(541, 264);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(74, 36);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef022;
            this.ClientSize = new System.Drawing.Size(826, 323);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.lbl_dsBan);
            this.Controls.Add(this.grb_ban);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.lbl_qlban);
            this.Name = "frmBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bàn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBan_FormClosing);
            this.Load += new System.EventHandler(this.frmBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_ban.ResumeLayout(false);
            this.grb_ban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tenban;
        private System.Windows.Forms.TextBox txt_maban;
        private System.Windows.Forms.ListBox lsb_tenkv;
        private System.Windows.Forms.ListBox lsb_trangthai;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label lbl_tenban;
        private System.Windows.Forms.Label lbl_tenkv;
        private System.Windows.Forms.Label lbl_maban;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_dsBan;
        private System.Windows.Forms.GroupBox grb_ban;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_qlban;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}