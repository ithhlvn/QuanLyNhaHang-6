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
    public partial class frmKhuVuc : Form
    {
        public frmKhuVuc()
        {
            InitializeComponent();
            loadKV();//load danh sách khu vực vào bảng khu vực
        }
        private void loadKV()
        {
            gvv_DSKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvv_DSKhuVuc.DataSource = khuvuc_DAO.Instance.getKV();//gán datasource cho gridview
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(lsb_tenkv.Text==string.Empty)//kiểm tra dữ liệu đã nhập chưa
            {
                MessageBox.Show("Hãy nhập tên khu vực ");
            }
            else
            {
                if(txt_makv.Text==string.Empty)
                    MessageBox.Show("Hãy nhập mã khu vực ");
                else
                {
                    if (lsb_trangthai.Text == string.Empty)
                        MessageBox.Show("Hãy nhập trạng thái ");
                    else
                    {
                        try
                        {
                            //lấy dữ liệu từ texbox, listbox,
                            string tenkv = lsb_tenkv.Text;
                            int makv = int.Parse(txt_makv.Text);
                            string trangthai = lsb_trangthai.Text;
                            if (khuvuc_DAO.Instance.insertkv(makv, tenkv, trangthai))//gọi hàm insert khu vực và truyền tham số
                            {
                                MessageBox.Show("Thành công !");
                                loadKV();//load lại bảng danh sách khu vực
                                foreach(Control i in Controls)
                                {
                                    if(i is TextBox || i is ListBox)
                                    {
                                        i.ResetText();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thất bại ! ");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin không hợp lệ! ");
                        }
                    }
                }
                    
            }
            
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lsb_tenkv.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập tên khu vực ");
            }
            else
            {
                if (txt_makv.Text == string.Empty)
                    MessageBox.Show("Hãy nhập mã khu vực ");
                else
                {
                    if (lsb_trangthai.Text == string.Empty)
                        MessageBox.Show("Hãy nhập trạng thái ");
                    else
                    {
                        try
                        {
                            //lấy thông tin từ các textbox,...
                            string tenkv = lsb_tenkv.Text;
                            int makv = int.Parse(txt_makv.Text);
                            string trangthai = lsb_trangthai.Text;
                            if (khuvuc_DAO.Instance.updatetkv(makv, tenkv, trangthai))//gọi đến hàm update thông tin khu vực
                            {
                                MessageBox.Show("Thành công! ");
                                loadKV();
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
           
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void frmKhuVuc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void gb_dsKhuvuc_Enter(object sender, EventArgs e)
        {
            this.gb_dsKhuvuc.BackColor = Color.Transparent;
        }

        private void gb_khuvuc_Enter(object sender, EventArgs e)
        {
            this.gb_khuvuc.BackColor = Color.Transparent;
        }

        private void txt_makv_Leave(object sender, EventArgs e)
        {
            if (txt_makv.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txt_makv, "Phải nhập mã khu vực !");
            else
                this.errorProvider1.Clear();
        }

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            txt_makv.Focus();
        }

        private void gvv_DSKhuVuc_SelectionChanged(object sender, EventArgs e)
        {
            txt_makv.Text = gvv_DSKhuVuc.CurrentRow.Cells[0].Value.ToString();
            lsb_tenkv.Text = gvv_DSKhuVuc.CurrentRow.Cells[1].Value.ToString();
            lbl_trangthai.Text = gvv_DSKhuVuc.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
