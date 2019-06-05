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
    public partial class frmNhomMonAn : Form
    {
        public frmNhomMonAn()
        {
            InitializeComponent();
            loadMenu();//load danh sách các nhóm món ăn lên gridview
        }
        private void loadMenu()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = nhommonan_DAO.Instance.getNhommonan();//gán datasource cho gridview
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txtMaNMA.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào mã thực đơn");
            else
            {
                if (txtTenNMA.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên thực đơn");
                }
                else
                {
                    try
                    {
                        int manhom = int.Parse(txtMaNMA.Text);
                        string tennhom = txtTenNMA.Text;
                        if (nhommonan_DAO.Instance.insertnhommonan(manhom, tennhom))//gọi hàm insert trong lớp DAO để insert thông tin vào database
                        {
                            MessageBox.Show("Thành công !");
                            loadMenu();
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
                        MessageBox.Show("Thông tin không hợp lệ !");
                    }
                }
            }
            
            
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txtMaNMA.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào mã thực đơn");
            else
            {
                if (txtTenNMA.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên thực đơn");
                }
                else
                {
                    try
                    {
                        int manhom = int.Parse(txtMaNMA.Text);
                        string tennhom = txtTenNMA.Text;
                        if (nhommonan_DAO.Instance.updatenhommonan(manhom, tennhom))//gọi hàm update trong DAO để sửa thông tin trong database
                        {
                            MessageBox.Show("Thành công !");
                            loadMenu();
                        }
                        else
                        {
                            MessageBox.Show("Thất bại!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin không hợp lệ ");
                    }
                }
            }

            
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txtMaNMA.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào mã thực đơn");
            try
            {
                int manhom = int.Parse(txtMaNMA.Text);
                if (nhommonan_DAO.Instance.deletenhommonan(manhom))//gọi hàm xóa nhóm món ăn trong database
                {
                    MessageBox.Show("Thành công !");
                    loadMenu();
                }
                else
                {
                    MessageBox.Show("Thất bại !");
                }

            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ ");
            }
            
        }

        private void frmNhomMonAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtMaNMA_Leave(object sender, EventArgs e)
        {
            if (txtMaNMA.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaNMA, "Phải nhập mã nhóm món ăn !");
            else
                this.errorProvider1.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNMA.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNMA.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void frmNhomMonAn_Load(object sender, EventArgs e)
        {
            txtMaNMA.Focus();
        }
    }
}
