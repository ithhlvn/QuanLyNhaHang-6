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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            loadKH();//load danh sách khách hàng vào gridview
        }
        private void loadKH()
        {
            gvv_DSKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvv_DSKhachHang.DataSource = khachhang_DAO.Instance.getKhachhnag();//gán datasource cho gridview
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            insertKH();//insert thông tin khách hàng vào bảng khách hàng trong database
            foreach (Control i in this.Controls)
            {
                if (i is TextBox)
                    i.ResetText();
            }
        }
        //hàm insert khách hàng
        private void insertKH()
        {
            if(txt_tenkh.Text==string.Empty)//check dữ liệu
            {
                MessageBox.Show("Hãy nhập tên khách hàng ");
            }
            else
            {
                if(false)
                { }
                else
                {
                    if(txt_makh.Text==string.Empty)
                    {
                        MessageBox.Show("Hãy nhập mã khách hàng ");
                    }
                    else
                    {
                        try
                        {
                            //lấy thông tin từ các textbox
                            string tenkh = txt_tenkh.Text;
                            string diachi = txt_diachi.Text;
                            int makh = int.Parse(txt_makh.Text);
                            if (khachhang_DAO.Instance.insertkh(makh, tenkh, diachi))//gọi và truyền tham số vào hàm insert khách hàng
                            {
                                MessageBox.Show("Thêm thành công !");
                                loadKH();//load lại bảng khách hàng
                           
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại !");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin không hợp lệ");
                        }

                    }
                }
            }
            
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            update();
        }
        //hàm update khách hàng
        private void update()
        {
            if (txt_tenkh.Text == string.Empty)//check các dữ liệu đã được nhập chưa
            {
                MessageBox.Show("Hãy nhập tên khách hàng ");
            }
            else
            {
                if (false)
                {

                }
                    
                else
                {
                    if (txt_makh.Text == string.Empty)
                        MessageBox.Show("Hãy nhập mã khách hàng ");
                    else
                    {
                        try
                        {
                            //lấy dự liệu từ các textbox
                            string tenkh = txt_tenkh.Text;
                            string diachi = txt_diachi.Text;
                            int makh = int.Parse(txt_makh.Text);
                            if (khachhang_DAO.Instance.updatekh(makh, tenkh, diachi))//gọi hàm update và truyền tham số cho nó
                            {
                                MessageBox.Show("Sửa thành công !");
                                loadKH();
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại");
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Thông tin không hợp lệ ");
                        }
                    }
                }
            }
            
            
        }
        //hàm delete khách hàng
        private void deleteKH()
        {
            
            if (txt_makh.Text == string.Empty)//check dữ liệu đã được nhập chưa
            {
                MessageBox.Show("Hãy nhập mã khách hàng ");
            }
            else
            {
                try
                {
                    int makh = int.Parse(txt_makh.Text);
                    if (khachhang_DAO.Instance.delete(makh))//gọi hàm xóa và truyền tham số cho nó
                    {
                        MessageBox.Show("Xóa thành công !");
                        loadKH();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại! ");
                    }
                }
                catch
                {
                    MessageBox.Show("Thông tin không hợp lệ");
                }
            }
                 
            
            
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            deleteKH();
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void grb_QLKH_Enter(object sender, EventArgs e)
        {
            this.grb_QLKH.BackColor = Color.Transparent;
        }

        private void gb_dskh_Enter(object sender, EventArgs e)
        {
            this.gb_dskh.BackColor = Color.Transparent;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
           if(txt_makh.Text.Trim().Length==0)
               this.errorProvider1.SetError(txt_makh,"Phải nhập mã khách hàng !");
            else
            this.errorProvider1.Clear();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void gvv_DSKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            txt_makh.Text = gvv_DSKhachHang.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = gvv_DSKhachHang.CurrentRow.Cells[1].Value.ToString();
            txt_diachi.Text = gvv_DSKhachHang.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
