using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QL_NHAHANG
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
            loadcbb();
            loadcbbnl();
            loadgridview();
        }

        private void frmHoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void loadcbb()
        {
            List<ncc_DTO> list = nhaCC_DAO.Instance.getlist();
            cbo_NhaCC.DataSource = list;
            cbo_NhaCC.DisplayMember = "tenncc";

        }
        private void lbl_ThoiGian_Click(object sender, EventArgs e)
        {
            this.gpb_HoaDonNhap.BackColor = Color.Transparent;
        }

        private void gpb_ChiTietHoaDon_Enter(object sender, EventArgs e)
        {
            this.gpb_ChiTietHoaDon.BackColor = Color.Transparent;
        }

        private void gpb_HoaDon_Enter(object sender, EventArgs e)
        {
            this.gpb_HoaDon.BackColor = Color.Transparent;
        }
        private void loadcbbnl()
        {
            List<nl_DTO> listnl = nl_DAO.Instance.getlistnl();
            cbo_nguyenlieu.DataSource = listnl;
            cbo_nguyenlieu.DisplayMember = "ten";
        }
       
        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mahoadonnhap.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào mã hóa đơn ");
                }
                else
                {
                    if (txt_manv.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào mã nhân viên ");
                    }
                    else
                    {
                        if (hdn_DAO.Instance.insert(int.Parse(txt_mahoadonnhap.Text), int.Parse(txt_manv.Text), cbo_NhaCC.Text))
                        {
                            MessageBox.Show("Nhập thành công ");
                            loadgridview();
                        }
                        else
                        {
                            MessageBox.Show("Nhập thất bại ");
                        }
                    }
                }
            }
            catch
            {

            }
            
        }
        void loadgridview()
        {
            int tongtien = 0;
            gvv_DSHoaDon.DataSource = hdn_DAO.Instance.getcthd();
            gvv_DSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<hdntt_DTO> listhdn = hdn_DAO.Instance.gettt();
            foreach(hdntt_DTO i in listhdn)
            {
                tongtien = tongtien + (int)i.Tien*(int)i.Sl;
            }
            textBox5.Text = tongtien.ToString();
        }

        private void btn_Ghi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_macthd.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào mã chi tiết hóa đơn");
                }
                else
                {
                    if (textBox3.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào mã hóa đơn");
                    }
                    else
                    {
                        if (false)
                        {
                           
                        }
                        else
                        {
                            nl_DTO nl = cbo_nguyenlieu.SelectedItem as nl_DTO;
                            if (hdn_DAO.Instance.insertct(int.Parse(txt_macthd.Text), int.Parse(textBox3.Text), nl.Manl, float.Parse(txt_soluong.Text)))
                            {
                                MessageBox.Show("Nhập thành công");
                                loadgridview();
                            }
                            else
                            {
                                MessageBox.Show("Nhập thất bại");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("HÓA ĐƠN NHẬP", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 200, 120);
            int x = gvv_DSHoaDon.Height;
            int y = gvv_DSHoaDon.RowCount * gvv_DSHoaDon.RowTemplate.Height;
            gvv_DSHoaDon.Height = gvv_DSHoaDon.RowCount * gvv_DSHoaDon.RowTemplate.Height;
            //Tạo bitmap để vẽ lên document
            Bitmap btm = new Bitmap(this.gvv_DSHoaDon.Width, this.gvv_DSHoaDon.Height);
            gvv_DSHoaDon.DrawToBitmap(btm, new Rectangle(0, 0, this.gvv_DSHoaDon.Width - 15, this.gvv_DSHoaDon.Height));
            e.Graphics.DrawImage(btm, 80, 380);
            gvv_DSHoaDon.Height = x;
            e.Graphics.DrawString("Ngày nhập      :   " + DateTime.Now.ToString(), new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 150, 200);
            e.Graphics.DrawString("Tổng tiền     :   " + textBox5.Text + " VND", new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 150, 240);
            e.Graphics.DrawString("Nhân viên          :........................................... ", new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 150, 280);
            e.Graphics.DrawString("BẢNG HÓA ĐƠN", new Font("Arial", 25, FontStyle.Italic), Brushes.Black, 280, 325);
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            foreach(Control i in this.Controls)
            {
                if (i is TextBox || i is ComboBox)
                    i.ResetText();
                if (i is DateTimePicker) ((DateTimePicker)i).Text = DateTime.Now.ToString();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txt_mahoadonnhap.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txt_mahoadonnhap, "Phải nhập mã hóa đơn !");
            else
                this.errorProvider1.Clear();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (txt_macthd.Text.Trim().Length == 0)
                this.errorProvider2.SetError(txt_macthd, "Phải nhập mã chi tiết hóa đơn !");
            else
                this.errorProvider2.Clear();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim().Length == 0)
                this.errorProvider3.SetError(textBox3, "Phải nhập mã hóa đơn !");
            else
                this.errorProvider3.Clear();
        }

        private void gvv_DSHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            txt_mahoadonnhap.Text = gvv_DSHoaDon.CurrentRow.Cells[0].Value.ToString();
            txt_macthd.Text = gvv_DSHoaDon.CurrentRow.Cells[1].Value.ToString();
            cbo_nguyenlieu.SelectedValue = gvv_DSHoaDon.CurrentRow.Cells[2].Value.ToString();
            txt_soluong.Text = gvv_DSHoaDon.CurrentRow.Cells[3].Value.ToString();
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            txt_mahoadonnhap.Focus();
        }
    }
}
