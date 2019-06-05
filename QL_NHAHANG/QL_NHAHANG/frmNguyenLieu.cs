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
    public partial class frmNguyenLieu : Form
    {
        public frmNguyenLieu()
        {
            InitializeComponent();
            getlist();//load danh sách nguyên liệu 
            loadcb();//load danh sách nhóm nguyên liệu vào combobox
        }
        private void getlist()
        {
            gvv_DSThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvv_DSThucDon.DataSource = nl_DAO.Instance.getnl();//gán datasource vào gridview
        }
        private void loadcb()
        {
            List<nhomnl_DTO> group = nhomnl_DAO.Instance.getlisnhom();//lấy danh sách nhóm nguyên liệu
            foreach (nhomnl_DTO nhom in group)
            {
                cboLoainl.Items.Add(nhom.Tennnl.ToString());//add danh sách nhóm nguyên liệu vào combobox
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_nl.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                if (txt_tenbl.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên nguyên liệu");
                }
                else
                {
                    if (txt_dongiaton.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào đơn giá nguyên liệu");
                    }
                    else
                    {
                        if (txt_dvt.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập vào đơn vị tính nguyên liệu");
                        }
                        else
                        {
                            try
                            {

                                if (nl_DAO.Instance.insertnnl(int.Parse(txt_nl.Text), txt_tenbl.Text, float.Parse(txt_dongiaton.Text), txt_dvt.Text, cboLoainl.Text))//gọi hàm insert nguyên liêu và truyền tham số để insert và database
                                {
                                    MessageBox.Show("Thêm thành công");
                                    getlist();//load lại danh sách nguyên liệu
                                    foreach(Control  i in this.Controls)
                                    {
                                        if(i is TextBox || i is ComboBox)
                                        {
                                            i.ResetText();
                                        }
                                    }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Thêm thất bại");
                            }
                        }

                    }
                }
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_nl.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                if (txt_tenbl.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào tên nguyên liệu");
                }
                else
                {
                    if (txt_dongiaton.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào đơn giá");
                    }
                    else
                    {
                        if (txt_dvt.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập vào đơn vị tính");
                        }
                        else
                        {
                            try
                            {
                                if (nl_DAO.Instance.updatennl(int.Parse(txt_nl.Text), cboLoainl.Text, float.Parse(txt_dongiaton.Text), txt_dvt.Text, txt_tenbl.Text))//gọi hàm update nguyên liệu trong lớp nguyenlieu_DAO để sữa thông tin trong database
                                {
                                    MessageBox.Show("Cập nhật thành công");
                                    getlist();
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Cập nhật thất bại");
                            }
                        }

                    }
                }
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_nl.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nguyên liệu");
            }
            else
            {
                try
                {
                    if (nl_DAO.Instance.deletenl(int.Parse(txt_nl.Text)))//gọi hàm xóa nguyên liệu trong database
                    {
                        MessageBox.Show("Xóa thành công");
                        getlist();
                    }

                }
                catch
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }

            
        }

        private void frmNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void gb_qlnguyenlieu_Enter(object sender, EventArgs e)
        {
            this.gb_qlnguyenlieu.BackColor = Color.Transparent;
        }

        private void grb_DSNguyenLieu_Enter(object sender, EventArgs e)
        {
            this.grb_DSNguyenLieu.BackColor = Color.Transparent;
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            txt_nl.Focus();
        }

        private void txt_nl_Leave(object sender, EventArgs e)
        {
            if (txt_nl.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txt_nl, "Phải nhập mã nguyên liệu !");
            else
                this.errorProvider1.Clear();
        }

        private void txt_dongiaton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gvv_DSThucDon_SelectionChanged(object sender, EventArgs e)
        {
            txt_nl.Text = gvv_DSThucDon.CurrentRow.Cells[0].Value.ToString();
            cboLoainl.SelectedValue = gvv_DSThucDon.CurrentRow.Cells[1].Value.ToString();
            txt_tenbl.Text = gvv_DSThucDon.CurrentRow.Cells[2].Value.ToString();
            txt_dongiaton.Text = gvv_DSThucDon.CurrentRow.Cells[3].Value.ToString();
            txt_dvt.Text = gvv_DSThucDon.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
