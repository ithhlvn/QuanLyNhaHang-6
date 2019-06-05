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
    public partial class frmBoPhan : Form
    {
        public frmBoPhan()
        {
            InitializeComponent();
            load();
        }

       

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtmabp.Text == string.Empty)//kiểm tra xem mã bộ phận đã nhập chưa
            {
                MessageBox.Show("Hãy nhập vào mã bo phận ");
            }
            else
            {
                if (txt_TenBoPhan.Text == string.Empty)//kiểm tra xem tên bộ phận đã được nhập chưa
                    MessageBox.Show("Hãy nhập vào tên bộ phận");
                else
                {
                    try
                    {
                        if (Nhanvien_DAO.Instance.insertbophan(int.Parse(txtmabp.Text), txt_TenBoPhan.Text))//gọi hàm insert và truyền tham số để insert vào database
                        {
                            MessageBox.Show("Nhập thành công");
                            load();//load lại bảng danh sách các bộ phận
                            foreach(Control i in this.Controls)
                            {
                                if(i is TextBox)
                                {
                                    i.ResetText();
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Nhập thất bại ");
                    }
                }
            }
            
        }
        public void load()
        {
            gvv_DSBoPhan.DataSource = Nhanvien_DAO.Instance.getbp(); //gán datasource cho gridview
        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            txtmabp.Focus();
        }

        private void frmBoPhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtmabp_TextChanged(object sender, EventArgs e)
        {
            if(txtmabp.Text!=string.Empty&&txt_TenBoPhan.Text!=string.Empty)
            {
                btn_them.Enabled = true;
            }
            else
            {
                btn_them.Enabled = false;
            }
        }

        private void txt_TenBoPhan_TextChanged(object sender, EventArgs e)
        {
            if (txtmabp.Text != string.Empty && txt_TenBoPhan.Text != string.Empty)
            {
                btn_them.Enabled = true;
            }
            else
            {
                btn_them.Enabled = false;
            }
        }

        private void txtmabp_Leave(object sender, EventArgs e)
        {
            if (txtmabp.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtmabp,"Phải nhập mã bộ phận !");
            else
                this.errorProvider1.Clear();
        }

        private void gvv_DSBoPhan_SelectionChanged(object sender, EventArgs e)
        {
            txtmabp.Text = gvv_DSBoPhan.CurrentRow.Cells[0].Value.ToString();
            txt_TenBoPhan.Text = gvv_DSBoPhan.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
