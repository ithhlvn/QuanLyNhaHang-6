using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAHANG
{
    
    public partial class frmChonmon : Form
    {
        List<Monan_DTO> list;
        public static int maban = 0;
        public frmChonmon()
        {
            InitializeComponent();
            txtMab.Text = maban.ToString();
            loadcb();
        }
        private void loadcb()
        {
            List<Nhommonan_DTO> group = nhommonan_DAO.Instance.loadtennhom();//lấy danh sách món ăn
            cbbthucdon.DataSource = group;//add danh sách món ăn vào combobox
            cbbthucdon.DisplayMember = "tennhom";//hiểm thị danh sách món ăn mới trường là tên món ăn

            //foreach (Nhommonan_DTO nhom in group)
            //{
                
            //    cbbthucdon.Items.Add(nhom.Tennhom.ToString());
                
            //}
        }
        private void loadfoodbythucdon(int id)
        {
            list = monan_DAO.Instance.getlisbyID(id);//lấy danh sách thực đơn
            Cbbmon.DataSource = list;//load danh sách thực đơn vào combobox
            Cbbmon.DisplayMember = "tenmonan";
            //foreach(Monan_DTO mon in list)
            //{
            //    Cbbmon.Items.Add(mon.Tenmonan.ToString());
            //}
        }

        private void cbbthucdon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lấy mã thực đơn
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Nhommonan_DTO selected = cb.SelectedItem as Nhommonan_DTO;
            id = selected.Manhom;
            loadfoodbythucdon(id);//load danh sách món ăn theo loại thực đơn
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(false)
            {
                
            }
            else
            {
                if(txtMab.Text==string.Empty)
                {
                    MessageBox.Show("Hãy nhập mã bàn ");
                }
                else
                {
                    if (txtMactHD.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập mã chi tiết hóa đơn ");
                    }
                    else
                    {
                        if (txtMahd.Text == string.Empty)
                        {
                            MessageBox.Show("Hãy nhập mã hóa đơn ");
                        }
                        else
                        {
                            if (txtManv.Text == string.Empty)
                            {
                                MessageBox.Show("Hãy nhập mã nhân viên ");
                            }
                            else
                            {
                                if (txtMkh.Text == string.Empty)
                                {
                                    MessageBox.Show("Hãy nhập mã khách hàng ");
                                }
                                else
                                {
                                    if (txtSl.Text == string.Empty)
                                    {
                                        MessageBox.Show("Hãy nhập số lượng ");
                                    }
                                    else
                                    {
                                        if (txtten.Text == string.Empty)
                                        {
                                            MessageBox.Show("Hãy nhập tên khách hàng ");
                                        }
                                        else
                                        {
                                            try
                                            {
                                                //lấy dữ liệu từ các textbox, comboox,.....
                                                int makh = int.Parse(txtMkh.Text);
                                                int mahd = int.Parse(txtMahd.Text);
                                                int maban = int.Parse(txtMab.Text);
                                                int macthd = int.Parse(txtMactHD.Text);
                                                int manv = int.Parse(txtManv.Text);
                                                string dc = txtdc.Text;
                                                string tenkh = txtten.Text;
                                                float sl = float.Parse(txtSl.Text);
                                                string tenmonan = Cbbmon.Text.ToString();
                                                int mamonan = 0;

                                                foreach (Monan_DTO mon in list)
                                                {
                                                    if (string.Compare(tenmonan,mon.Tenmonan)==0)
                                                    {
                                                        mamonan = mon.Mamonan;
                                                        break;
                                                    }


                                                }
                                                DateTime dt = DateTime.Today;
                                                if (makh != 0 & mahd != 0 & maban != 0 & macthd != 0 & manv != 0 & dc != null & tenkh != null & sl != 0.0F & tenmonan != null & mamonan != 0)
                                                {
                                                    insertkh(makh, tenkh, dc);//insert vào bảng khách hàng
                                                    updatesttban(maban);//update trạng thái bàn
                                                    insertHD(mahd, maban, manv, makh, dt);//insert vào bảng hóa đơn
                                                    insertCTHD(macthd, mahd, mamonan, sl);//insert vao bảng chi tiết hóa đơn
                                                    this.Hide();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Hãy điền đầy đủ thông tin");
                                                }

                                            }
                                            catch
                                            {
                                                MessageBox.Show("Mã khách hàng, Mã hóa đơn, hoặc Mã chi tiết hóa đơn đã tồn tại");
                                            }
                                        }
                                    
                                    }

                                }

                            }
                        }
                    }
                }
            }
            
            
            
        }
        public void insertkh(int makh,string tenkh, string dc)
        {
            khachhang_DAO.Instance.insertkh(makh,tenkh, dc);
        }
        public void updatesttban(int maban)
        {
            Goimon_DAO.Instance.updatesttban(maban);
        }
        public void insertHD(int mahd,int maban, int manv, int mkh, DateTime tgvao)
        {
            Goimon_DAO.Instance.insertHD(mahd, maban, manv, tgvao, mkh);
        }
        public void insertCTHD(int MACTHDX, int MAHDX, int MAMA, float SOLUONG)
        {
            Goimon_DAO.Instance.insertCTHD(MACTHDX, MAHDX, MAMA, SOLUONG);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmChonmon_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtMahd_Leave(object sender, EventArgs e)
        {
            if (txtMahd.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtMahd, "Phải nhập mã hóa đơn !");
            else
                this.errorProvider1.Clear();
        }

        private void txtMactHD_Leave(object sender, EventArgs e)
        {
            if (txtMactHD.Text.Trim().Length == 0)
                this.errorProvider2.SetError(txtMactHD, "Phải nhập mã chi tiết hóa đơn !");
            else
                this.errorProvider2.Clear();
        }
    }
}
