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
    public partial class doipass : Form
    {
        public doipass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuser.Text==string.Empty)//Kiểm tra textbox tài khoản có được nhập chưa
            {
                MessageBox.Show("Hãy nhập vào tài khoản");
            }
            else
            {
                if (txtpass.Text == string.Empty)//kiểm tra textbox mật khẩu có được nhập chưa
                {
                    MessageBox.Show("Hãy nhập mật khẩu cũ");
                }
                else
                {
                    if (txtpass1.Text == string.Empty)//Kiểm tra textbox mật khẩu mới có được nhập chưa
                    {
                        MessageBox.Show("Hãy nhập mật khẩu mới");
                    }
                    else
                    {
                        try
                        {
                            if(user_DAO.Instance.updateuser(txtuser.Text,txtpass.Text,txtpass1.Text))//truyền tham số vào hàm đăng nhập tài khoản trong lớp user_DAO
                            {
                                MessageBox.Show("Đổi thành công");
                                button1.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu sai !!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Đổi thất bại ");
                        }
                    }
                }
            }
        }

        private void doipass_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if(txtuser.Text!=string.Empty)
            {
                if (txtpass.Text != string.Empty)
                {
                    if (txtpass1.Text != string.Empty)
                    {
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtuser.Text != string.Empty)
            {
                if (txtpass.Text != string.Empty)
                {
                    if (txtpass1.Text != string.Empty)
                    {
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void txtpass1_TextChanged(object sender, EventArgs e)
        {
            if (txtuser.Text != string.Empty)
            {
                if (txtpass.Text != string.Empty)
                {
                    if (txtpass1.Text != string.Empty)
                    {
                        button1.Enabled = true;
                    }
                }
            }
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void doipass_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
