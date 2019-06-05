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
    public partial class frmMonAn : Form
    {
        public frmMonAn()
        {
            InitializeComponent();
            loadmonan();//load danh sách món ăn vào bảng món ăn
            loadcb();//load danh sách món ăn vào combobox theo loại thực đơn
        }
        private void loadcb()
        {
            List<Nhommonan_DTO> group = nhommonan_DAO.Instance.loadtennhom();//lấy danh sách nhóm món ăn từ database
            foreach(Nhommonan_DTO nhom in group)
            {
                cboLoaiTD.Items.Add(nhom.Tennhom.ToString());//add loại thực đơn vào combobox
            }
        }
        private void loadmonan()
        {
            gvv_DSThucDon.DataSource = monan_DAO.Instance.getNhommonan();//gán datasource vào gridview món ăn
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mathucdon.Text == string.Empty)
                MessageBox.Show("Hãy nhập mã thực đơn");
            else
            {
                if (txt_tenthucdon.Text == string.Empty)
                    MessageBox.Show("Hãy nhập tên thực đơn");
                else
                {
                    if (txt_dongiaton.Text == string.Empty)
                        MessageBox.Show("Hãy nhập đơn giá");
                    else
                    {
                        if(txt_dvt.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập đơn vị tính");
                        }
                        else
                        {
                            if (lsb_trangthai.Text == string.Empty)
                                MessageBox.Show("Hãy nhập trạng thái ");
                            else
                            {
                                try
                                {
                                    //lấy thông tin từ các textbox
                                    string tenmonan = txt_tenthucdon.Text;
                                    int mamonan = int.Parse(txt_mathucdon.Text);
                                    string tennhom = cboLoaiTD.Text;
                                    string donvi = txt_dvt.Text;
                                    string trangthai = lsb_trangthai.Text;
                                    float dongia = float.Parse(txt_dongiaton.Text);
                                    if (monan_DAO.Instance.insertmonan(tennhom, mamonan, tenmonan, dongia, donvi, trangthai))//gọi hàm insert món ăn và truyền tham số để insert vào bảng món ăn trong database
                                    {
                                        MessageBox.Show("Thành công!");
                                        loadmonan();
                                        foreach(Control i in this.Controls)
                                        {
                                            if(i is TextBox || i is ListBox || i is ComboBox)
                                            {
                                                i.ResetText();
                                            }
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
            }
                

           
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_mathucdon.Text == string.Empty)
                MessageBox.Show("Hãy nhập mã thực đơn");
            else
            {
                if (txt_tenthucdon.Text == string.Empty)
                    MessageBox.Show("Hãy nhập tên thực đơn");
                else
                {
                    if (txt_dongiaton.Text == string.Empty)
                        MessageBox.Show("Hãy nhập đơn giá");
                    else
                    {
                        if (txt_dvt.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập đơn vị tính");
                        }
                        else
                        {
                            if (lsb_trangthai.Text == string.Empty)
                                MessageBox.Show("Hãy nhập trạng thái ");
                            else
                            {
                                try
                                {
                                    //lấy thông tin từ các textbox
                                    string tenmonan = txt_tenthucdon.Text;
                                    int mamonan = int.Parse(txt_mathucdon.Text);
                                    string tennhom = cboLoaiTD.Text;
                                    string donvi = txt_dvt.Text;
                                    float dongia = float.Parse(txt_dongiaton.Text);
                                    string trangthai = lsb_trangthai.Text;
                                    if (monan_DAO.Instance.updatetmonan(tennhom, mamonan, tenmonan, dongia, donvi, trangthai))//gọi hàm update và truyền tham số để sửa thông tin bàn trong database
                                    {
                                        MessageBox.Show("Thành công!");
                                        loadmonan();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thất bại ");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Thông tin không hợp lệ ! ");
                                }
                            }
                        }
                    }
                }
            }

            


}

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mathucdon.Text == string.Empty)
                MessageBox.Show("Hãy nhập mã thực đơn");
            try
            {
                int mamonan = int.Parse(txt_mathucdon.Text);
                if (monan_DAO.Instance.deletemonan(mamonan))//gọi hàm xóa món ăn
                {
                    MessageBox.Show("Thành công!");
                    loadmonan();
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
            
        }

        private void frmMonAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void gb_qlthucdon_Enter(object sender, EventArgs e)
        {
            this.gb_qlthucdon.BackColor = Color.Transparent;
        }

        private void grb_DSMonAn_Enter(object sender, EventArgs e)
        {
            this.grb_DSMonAn.BackColor = Color.Transparent;
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            txt_mathucdon.Focus();
        }

        private void txt_mathucdon_Leave(object sender, EventArgs e)
        {
            if (txt_mathucdon.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txt_mathucdon, "Phải nhập mã món ăn !");
            else
                this.errorProvider1.Clear();
        }

        private void txt_dongiaton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gvv_DSThucDon_SelectionChanged(object sender, EventArgs e)
        {
            txt_mathucdon.Text = gvv_DSThucDon.CurrentRow.Cells[0].Value.ToString();
            cboLoaiTD.Text = gvv_DSThucDon.CurrentRow.Cells[1].Value.ToString();
            txt_tenthucdon.Text = gvv_DSThucDon.CurrentRow.Cells[2].Value.ToString();
            txt_dongiaton.Text = gvv_DSThucDon.CurrentRow.Cells[3].Value.ToString();
            txt_dvt.Text = gvv_DSThucDon.CurrentRow.Cells[4].Value.ToString();
        }

    }
}
