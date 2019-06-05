using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;


namespace QL_NHAHANG
{
    public partial class frmNhomNguyenLieu : Form
    {
        public frmNhomNguyenLieu()
        {
            InitializeComponent();
            getlistnhomnl();//load danh sách nguyên liệu 
        }
        void getlistnhomnl()
        {
            gvv_DSLoaiThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvv_DSLoaiThucDon.DataSource = nhomnl_DAO.Instance.getnhomnl();//gán datasource cho gridview
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_maloaithucdon.Text==string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                if(txt_tenloaithucdon.Text==string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên nguyên liệu ");
                }
                else
                {
                    try
                    {
                        if (nhomnl_DAO.Instance.insertnhomnl(int.Parse(txt_maloaithucdon.Text.ToString()), txt_tenloaithucdon.Text.ToString()))//gọi hàm insert trong lớp DAO để insert dữ liệu vào database
                        {
                            MessageBox.Show("Thêm thành công ");
                          foreach(Control i in this.Controls)
                              if(i is TextBox)
                          {
                              i.ResetText();
                          }
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại ");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại ");
                    }
                }
               
            }
           

            getlistnhomnl();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_maloaithucdon.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                if (txt_tenloaithucdon.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên nguyên liệu ");
                }
                else
                {
                    try
                    {
                        if (nhomnl_DAO.Instance.updatennl(int.Parse(txt_maloaithucdon.Text), txt_tenloaithucdon.Text))//gọi hàm update của lớp nl_DAO để sửa thông tin trong database
                        {
                            MessageBox.Show("Sửa thành công ");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại ");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại ");
                    }
                }

            }
            
            getlistnhomnl();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maloaithucdon.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            try
            {
                if (nhomnl_DAO.Instance.delete(int.Parse(txt_maloaithucdon.Text.ToString())))//gọi hàm xóa nhóm nguyên liệu trong database
                {
                    MessageBox.Show("Xóa thành công ");
                }
                else
                {
                   
                }
            }
            catch
            {
                
            }


            getlistnhomnl();
        }

        private void frmNhomNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void grb_dsloaithucdon_Enter(object sender, EventArgs e)
        {
            this.grb_dsloaithucdon.BackColor = Color.Transparent;  
        }

        private void grb_QLNhomNguyenLieu_Enter(object sender, EventArgs e)
        {
            this.grb_QLNhomNguyenLieu.BackColor = Color.Transparent;  
        }

        private void frmNhomNguyenLieu_Load(object sender, EventArgs e)
        {
            txt_maloaithucdon.Focus();
        }

        private void txt_maloaithucdon_Leave(object sender, EventArgs e)
        {
            if (txt_maloaithucdon.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txt_maloaithucdon, "Phải nhập mã nhóm nguyên liệu !");
            else
                this.errorProvider1.Clear();
        }

        private void gvv_DSLoaiThucDon_SelectionChanged(object sender, EventArgs e)
        {
            txt_maloaithucdon.Text = gvv_DSLoaiThucDon.CurrentRow.Cells[0].Value.ToString();
            txt_tenloaithucdon.Text = gvv_DSLoaiThucDon.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
