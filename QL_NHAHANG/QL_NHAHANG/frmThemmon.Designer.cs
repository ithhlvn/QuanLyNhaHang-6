namespace QL_NHAHANG
{
    partial class frmThemmon
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtMactHD = new System.Windows.Forms.TextBox();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.Cbbmon = new System.Windows.Forms.ComboBox();
            this.cbbthucdon = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Món ĂN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Loại Thực Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã Chi Tiet Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(166, 122);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(201, 20);
            this.txtSl.TabIndex = 4;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(166, 148);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(201, 20);
            this.txtManv.TabIndex = 5;
            // 
            // txtMactHD
            // 
            this.txtMactHD.Location = new System.Drawing.Point(166, 38);
            this.txtMactHD.Name = "txtMactHD";
            this.txtMactHD.Size = new System.Drawing.Size(201, 20);
            this.txtMactHD.TabIndex = 1;
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(166, 12);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.ReadOnly = true;
            this.txtMahd.Size = new System.Drawing.Size(201, 20);
            this.txtMahd.TabIndex = 0;
            // 
            // Cbbmon
            // 
            this.Cbbmon.FormattingEnabled = true;
            this.Cbbmon.Location = new System.Drawing.Point(166, 93);
            this.Cbbmon.Name = "Cbbmon";
            this.Cbbmon.Size = new System.Drawing.Size(201, 21);
            this.Cbbmon.TabIndex = 3;
            // 
            // cbbthucdon
            // 
            this.cbbthucdon.FormattingEnabled = true;
            this.cbbthucdon.Location = new System.Drawing.Point(166, 66);
            this.cbbthucdon.Name = "cbbthucdon";
            this.cbbthucdon.Size = new System.Drawing.Size(201, 21);
            this.cbbthucdon.TabIndex = 2;
            this.cbbthucdon.SelectedIndexChanged += new System.EventHandler(this.cbbthucdon_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::QL_NHAHANG.Properties.Resources.Button_Add_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(272, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm Món";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThemmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_NHAHANG.Properties.Resources.hinh_nen_mua_xuan_5547e8116ef0221;
            this.ClientSize = new System.Drawing.Size(384, 254);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.txtMactHD);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.Cbbmon);
            this.Controls.Add(this.cbbthucdon);
            this.Controls.Add(this.button1);
            this.Name = "frmThemmon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemmon_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtMactHD;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.ComboBox Cbbmon;
        private System.Windows.Forms.ComboBox cbbthucdon;
        private System.Windows.Forms.Button button1;
    }
}