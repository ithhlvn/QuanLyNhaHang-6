
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
    public partial class frmDangNhap : Form
    {
        public static int key = 0;
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem người dùng đã nhập tên tài khoản và pass chưa
            string user = txt_tendn.Text.Trim();//get dữ liệu từ textbox tài khoản
            string pass = txt_matkhau.Text;//get dữ liệu từ textbox mật khẩu
            if(user==string.Empty)//kiểm tra tài khoản có được nhập chưa
            {
                MessageBox.Show("Hãy nhập tài khoản ");
            }
            else
            {
                if(pass==string.Empty)
                    MessageBox.Show("Hãy nhập Password");
            }
            if (longin(user, pass))//đăng nhập vào hệ thống
            {
                if (string.Compare(user, "admin") == 0)//Hàm so sánh 2 chuỗi
                {
                    key = 1;
                }
                frmQuanLyNhaHang f = new frmQuanLyNhaHang();
                this.Hide();
                f.Show();
            }
            else {
                MessageBox.Show("Tài khoản không hợp lệ!");
            }

        }
        private bool longin(string user,string pass)
        {
            return user_DAO.Instance.login(user, pass);
            //truyền paramater cho hàm login
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //btn_dangnhap.Enabled = false;
            //txt_tendn.Focus();
            //if (txt_tendn.Text != "" && txt_matkhau.Text != "")
            //{
            //    btn_dangnhap.Enabled = true;
            this.AcceptButton = btn_dangnhap;
            //}
        }

        private void grb_DangNhap_Enter(object sender, EventArgs e)
        {
            this.grb_DangNhap.BackColor = Color.Transparent;  
        }

        private void txt_tendn_TextChanged(object sender, EventArgs e)
        {
            if (txt_tendn.Text != string.Empty)
            {
                if (txt_matkhau.Text != string.Empty)
                {
                    btn_dangnhap.Enabled = true;
                }
            }
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_tendn.Text != string.Empty)
            {
                if (txt_matkhau.Text != string.Empty)
                {
                    btn_dangnhap.Enabled = true;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_dangnhap.PerformClick();

        }

        private void btn_dangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_dangnhap.PerformClick();
        }
    }
}
