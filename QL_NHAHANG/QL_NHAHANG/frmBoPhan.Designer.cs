namespace QL_NHAHANG
{
    partial class frmBoPhan
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
            this.gvv_DSBoPhan = new System.Windows.Forms.DataGridView();
            this.MABP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_DSBoPhan = new System.Windows.Forms.GroupBox();
            this.txt_TenBoPhan = new System.Windows.Forms.TextBox();
            this.lbl_TenBoPhan = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.txtmabp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSBoPhan)).BeginInit();
            this.gpb_DSBoPhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvv_DSBoPhan
            // 
            this.gvv_DSBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvv_DSBoPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABP,
            this.TENBP});
            this.gvv_DSBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvv_DSBoPhan.Location = new System.Drawing.Point(3, 17);
            this.gvv_DSBoPhan.Name = "gvv_DSBoPhan";
            this.gvv_DSBoPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvv_DSBoPhan.Size = new System.Drawing.Size(345, 162);
            this.gvv_DSBoPhan.TabIndex = 0;
            this.gvv_DSBoPhan.SelectionChanged += new System.EventHandler(this.gvv_DSBoPhan_SelectionChanged);
            // 
            // MABP
            // 
            this.MABP.DataPropertyName = "MABP";
            this.MABP.HeaderText = "MÃ BỘ PHẬN";
            this.MABP.Name = "MABP";
            // 
            // TENBP
            // 
            this.TENBP.DataPropertyName = "TENBP";
            this.TENBP.HeaderText = "TÊN BỘ PHẬN";
            this.TENBP.Name = "TENBP";
            this.TENBP.Width = 200;
            // 
            // gpb_DSBoPhan
            // 
            this.gpb_DSBoPhan.Controls.Add(this.gvv_DSBoPhan);
            this.gpb_DSBoPhan.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_DSBoPhan.Location = new System.Drawing.Point(25, 89);
            this.gpb_DSBoPhan.Name = "gpb_DSBoPhan";
            this.gpb_DSBoPhan.Size = new System.Drawing.Size(351, 182);
            this.gpb_DSBoPhan.TabIndex = 3;
            this.gpb_DSBoPhan.TabStop = false;
            // 
            // txt_TenBoPhan
            // 
            this.txt_TenBoPhan.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenBoPhan.Location = new System.Drawing.Point(97, 63);
            this.txt_TenBoPhan.Name = "txt_TenBoPhan";
            this.txt_TenBoPhan.Size = new System.Drawing.Size(204, 21);
            this.txt_TenBoPhan.TabIndex = 1;
            this.txt_TenBoPhan.TextChanged += new System.EventHandler(this.txt_TenBoPhan_TextChanged);
            // 
            // lbl_TenBoPhan
            // 
            this.lbl_TenBoPhan.AutoSize = true;
            this.lbl_TenBoPhan.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBoPhan.Location = new System.Drawing.Point(22, 70);
            this.lbl_TenBoPhan.Name = "lbl_TenBoPhan";
            this.lbl_TenBoPhan.Size = new System.Drawing.Size(70, 15);
            this.lbl_TenBoPhan.TabIndex = 34;
            this.lbl_TenBoPhan.Text = "Tên bộ phận";
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Button_Add_icon;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Enabled = false;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(310, 51);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(66, 32);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txtmabp
            // 
            this.txtmabp.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabp.Location = new System.Drawing.Point(97, 37);
            this.txtmabp.Name = "txtmabp";
            this.txtmabp.Size = new System.Drawing.Size(204, 21);
            this.txtmabp.TabIndex = 0;
            this.txtmabp.TextChanged += new System.EventHandler(this.txtmabp_TextChanged);
            this.txtmabp.Leave += new System.EventHandler(this.txtmabp_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã bộ phận";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef022;
            this.ClientSize = new System.Drawing.Size(398, 281);
            this.Controls.Add(this.txtmabp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpb_DSBoPhan);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_TenBoPhan);
            this.Controls.Add(this.lbl_TenBoPhan);
            this.Name = "frmBoPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ phận";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBoPhan_FormClosing);
            this.Load += new System.EventHandler(this.frmBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvv_DSBoPhan)).EndInit();
            this.gpb_DSBoPhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvv_DSBoPhan;
        private System.Windows.Forms.GroupBox gpb_DSBoPhan;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_TenBoPhan;
        private System.Windows.Forms.Label lbl_TenBoPhan;
        private System.Windows.Forms.TextBox txtmabp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}