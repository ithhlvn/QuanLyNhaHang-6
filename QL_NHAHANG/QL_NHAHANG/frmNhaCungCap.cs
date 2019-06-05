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

namespace QL_NHAHANG
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
            loadncc();//load danh sách nhà cung cấp
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            txt_MaNhaCungCap.Focus();
        }
        private void loadncc()
        {
            gvv_DSNhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvv_DSNhaCC.DataSource = nhaCC_DAO.Instance.getNCC();//gán datasource cho gridview
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_DiaChi.Text == string.Empty)
                MessageBox.Show("Hãy nhập địa chỉ");
            else
            {
                if (txt_MaNhaCungCap.Text == string.Empty)
                    MessageBox.Show("Hãy nhập mã nhà cung cấp ");
                else
                {
                    if (txt_tenncc.Text == string.Empty)
                        MessageBox.Show("Hãy nhập tên nhà cung cấp");
                    else
                    {
                        try
                        {
                            //lấy thông tin từ textbox
                            string diachi = txt_DiaChi.Text;
                            string tenncc = txt_tenncc.Text;
                            int mancc = int.Parse(txt_MaNhaCungCap.Text);
                            if (nhaCC_DAO.Instance.insertNCC(mancc, tenncc, diachi))//gọi hàm insert trong lớp DAO để insert vào database
                            {
                                MessageBox.Show(" Thành công! ");
                                loadncc();
                                foreach(Control i in this.Controls)
                                {
                                    if (i is TextBox)
                                        i.ResetText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thất bại!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin không hợp lệ!");
                        }
                    }
                }
            }
            
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_DiaChi.Text == string.Empty)
                MessageBox.Show("Hãy nhập địa chỉ");
            else
            {
                if (txt_MaNhaCungCap.Text == string.Empty)
                    MessageBox.Show("Hãy nhập mã nhà cung cấp ");
                else
                {
                    if (txt_tenncc.Text == string.Empty)
                        MessageBox.Show("Hãy nhập tên nhà cung cấp");
                    else
                    {
                        try
                        {
                            //lấy thông tin từ textbox
                            string diachi = txt_DiaChi.Text;
                            string tenncc = txt_tenncc.Text;
                            int mancc = int.Parse(txt_MaNhaCungCap.Text);
                            if (nhaCC_DAO.Instance.updateNCC(mancc, tenncc, diachi))//gọi hàm update từ class nhacc_DAO để sửa thông tin nhà cung cấp trong database
                            {
                                MessageBox.Show(" Thành công! ");
                                loadncc();
                            }
                            else
                            {
                                MessageBox.Show("Thất bại!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin không hợp lệ!");
                        }
                    }
                }
            }
            
            
        }

        private void btn__xoa_Click(object sender, EventArgs e)
        {

            if (txt_MaNhaCungCap.Text == string.Empty)
                MessageBox.Show("Hãy nhập mã nhà cung cấp ");
            try
            {
                int mancc = int.Parse(txt_MaNhaCungCap.Text);
                if (nhaCC_DAO.Instance.deleteNCC(mancc))//gọi hàm xóa thông tin nhà cung cấp trong database
                {
                    MessageBox.Show(" Thành công! ");
                    loadncc();
                }
                else
                {
                    MessageBox.Show("Thất bại! ");
                }
            }
            catch
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại !");
            }
            
        }

        private void frmNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void gpb_DSNhaCC_Enter(object sender, EventArgs e)
        {
            this.gpb_DSNhaCC.BackColor = Color.Transparent;
        }

        private void txt_MaNhaCungCap_Leave(object sender, EventArgs e)
        {
            if (txt_MaNhaCungCap.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txt_MaNhaCungCap, "Phải nhập mã nhà cung cấp !");
            else
                this.errorProvider1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt_tenncc.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txt_tenncc, "Phải nhập tên nhà cung cấp !");
            else
                this.errorProvider1.Clear();
        }

        private void gvv_DSNhaCC_SelectionChanged(object sender, EventArgs e)
        {
            txt_MaNhaCungCap.Text = gvv_DSNhaCC.CurrentRow.Cells[0].Value.ToString();
            txt_tenncc.Text = gvv_DSNhaCC.CurrentRow.Cells[1].Value.ToString();
            txt_DiaChi.Text = gvv_DSNhaCC.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
