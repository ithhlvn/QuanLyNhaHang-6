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
    public partial class frmuser : Form
    {
        public frmuser()
        {
            InitializeComponent();
        }

        private void lbl_matkhau_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtma.Text==string.Empty)
            {
                MessageBox.Show("Nhập vào mã nhân viên");
            }
            else
            {
                if(txt_tendn.Text ==string.Empty)
                {
                    MessageBox.Show("Nhập vào tên người dùng ");
                }
                else
                {
                    if (txt_matkhau.Text == string.Empty)
                    {
                        MessageBox.Show("Nhập vào mật khẩu ");
                    }
                }
            }
            try
            {
                if (user_DAO.Instance.createND(int.Parse(txtma.Text), txt_tendn.Text, txt_matkhau.Text))//insert tài khoản vào database
                {
                    MessageBox.Show("Đăng ký thành công");
                }

            }
            catch
            {
                MessageBox.Show("Mã người dùng tồn tại !");
            }

        }

        private void frmuser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtma_Leave(object sender, EventArgs e)
        {
            if (txtma.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtma, "Phải nhập mã nhân viên !");
            else
                this.errorProvider1.Clear();
        }

        private void frmuser_Load(object sender, EventArgs e)
        {
            txtma.Focus();
        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {
            if (txtma.Text != string.Empty)
            {
                if(txt_tendn.Text!= string.Empty)
                {
                    if (txt_matkhau.Text != string.Empty)
                    {
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void txt_tendn_TextChanged(object sender, EventArgs e)
        {
            if (txtma.Text != string.Empty)
            {
                if (txt_tendn.Text != string.Empty)
                {
                    if (txt_matkhau.Text != string.Empty)
                    {
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            if (txtma.Text != string.Empty)
            {
                if (txt_tendn.Text != string.Empty)
                {
                    if (txt_matkhau.Text != string.Empty)
                    {
                        button1.Enabled = true;
                    }
                }
            }
        }
    }
}
