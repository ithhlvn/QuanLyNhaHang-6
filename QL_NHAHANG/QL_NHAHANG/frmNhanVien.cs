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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            loadNhanvien();//load danh sách nhân viên 
            loaddatafromGrv();
            loadcbb();
        }
        void loadNhanvien()
        {
            dgvDanhsachnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhsachnhanvien.DataSource = Nhanvien_DAO.Instance.getNhanvien();//gán datasource cho gridview
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào địa chỉ ");
            else
            {
                if(false)
                {
                   
                }
                else
                {
                    if (txtMaNV.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào mã nhân viên");
                    }
                    else
                    {
                        if (txtTenNV.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập vào tên nhân viên ");
                        }
                        else
                        {
                            try
                            {
                                //lấy thông tin từ textbox, combobox,....
                                int maNV = int.Parse(txtMaNV.Text);
                                string tenNV = txtTenNV.Text;
                                string dc = txtDiachi.Text;
                                string dienthoai = txtDienthoai.Text;
                                string boPhan = cbBophan.Text;
                                string gioitinh = cbGioitinh.Text;
                                string ngaysinh = dtpNgaysinh.Text;
                                DateTime ngaySinh = Convert.ToDateTime(ngaysinh);
                                if (Nhanvien_DAO.Instance.insertNhanvien(maNV, tenNV, boPhan, dienthoai, dc, gioitinh, ngaySinh))//gọi hàm insert để insert vào database
                                {
                                    MessageBox.Show("Thêm thành công !!");
                                    loadNhanvien();
                                    foreach (Control i in this.Controls)
                                    {
                                        if (i is TextBox || i is ComboBox)
                                            i.ResetText();
                                        if (i is DateTimePicker) ((DateTimePicker)i).Text = DateTime.Now.ToString();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Thất bại !!");
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Hãy điền đầy đủ thông tin");

                            }
                        }
                        
                    }
                }
            }
            
            
        }
        public void loaddatafromGrv()
        {
            //hiển thị thông tin vào các textbox, combobox, khi ta chọn một dòng trong gridview
            txtTenNV.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "TENNV"));
            txtMaNV.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "MANV"));
            txtDienthoai.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "DIENTHOAI"));
            txtDiachi.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "DIACHI"));              
            cbGioitinh.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "GIOITINH"));
            dtpNgaysinh.DataBindings.Add(new Binding("Text", dgvDanhsachnhanvien.DataSource, "NGAYSINH"));
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text == string.Empty)
                MessageBox.Show("Hãy nhập vào địa chỉ ");
            else
            {
                if (txtDienthoai.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào số điện thoại");
                }
                else
                {
                    if (txtMaNV.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào mã nhân viên");
                    }
                    else
                    {
                        if (txtTenNV.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập vào tên nhân viên ");
                        }
                        else
                        {
                            try
                            {
                                //lấy thông tin từ các textbox, combobox
                                int maNV = int.Parse(txtMaNV.Text);
                                string tenNV = txtTenNV.Text;
                                string dc = txtDiachi.Text;
                                string dienthoai = txtDienthoai.Text;
                                string boPhan = cbBophan.Text;
                                string gioitinh = cbGioitinh.Text;
                                string ngaysinh = dtpNgaysinh.Text;
                                DateTime ngaySinh = Convert.ToDateTime(ngaysinh);
                                if (Nhanvien_DAO.Instance.updateNhanvien(maNV, tenNV, boPhan, dienthoai, dc, gioitinh, ngaySinh))//gọi hàm update để sửa thông tin nhân viên trong database
                                {
                                    MessageBox.Show("Update Thành công!!");
                                    loadNhanvien();

                                }
                                else
                                {
                                    MessageBox.Show("Thất bại !!");
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Hãy điền đầy đủ thông tin !");

                            }
                        }

                    }
                }
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào mã nhân viên");
            }
            try
            {
                int maNV = int.Parse(txtMaNV.Text);
                if (Nhanvien_DAO.Instance.deleteNhanvien(maNV))//gọi hàm xóa thông tin nhân viên trong database
                {
                    MessageBox.Show("Xóa thành công !!");
                    loadNhanvien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!");
                }
            }
            catch
            {
                MessageBox.Show("Mã nhân viên không tồn tại !");
            }
            
        }
        void loadcbb()
        {
            List<bophan_DTO> ls = Nhanvien_DAO.Instance.getlist();//lấy danh sách các bộ phận trong nhà hàng
            foreach(bophan_DTO tb in ls)
            {
                cbBophan.Items.Add(tb.Ten);//add danh sách các bộ phận vào combobox
            }
        }

        private void dgvDanhsachnhanvien_SelectionChanged(object sender, EventArgs e)
        {
           // loaddatafromGrv();

            txtMaNV.Text = dgvDanhsachnhanvien.CurrentRow.Cells[0].Value.ToString();
            cbBophan.SelectedValue = dgvDanhsachnhanvien.CurrentRow.Cells[1].Value.ToString();
            txtTenNV.Text = dgvDanhsachnhanvien.CurrentRow.Cells[2].Value.ToString();
            cbGioitinh.Text = dgvDanhsachnhanvien.CurrentRow.Cells[3].Value.ToString();
            dtpNgaysinh.Text = dgvDanhsachnhanvien.CurrentRow.Cells[4].Value.ToString();
            txtDiachi.Text = dgvDanhsachnhanvien.CurrentRow.Cells[5].Value.ToString();
            txtDienthoai.Text = dgvDanhsachnhanvien.CurrentRow.Cells[6].Value.ToString();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập ký tự là số !");
            }

        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập ký tự là chữ !");
            }
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMaNV, "Phải nhập mã nhân viên !");
            else
                this.errorProvider1.Clear();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dtpNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
