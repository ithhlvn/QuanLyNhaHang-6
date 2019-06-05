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
    public partial class frmThemmon : Form
    {
        public static int mahoadon = 0;
        List<Monan_DTO> list;
        public frmThemmon()
        {
            InitializeComponent();
            loadcb();//load dữ liệu cho các combobox
            txtMahd.Text = mahoadon.ToString();//gán mã hóa đơn cho textbox
        }
        public void insertCTHD(int MACTHDX, int MAHDX, int MAMA, float SOLUONG)
        {
            Goimon_DAO.Instance.insertCTHD(MACTHDX, MAHDX, MAMA, SOLUONG);//insert thông tin vào bảng chi tiết hóa đơn trong database
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMactHD.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập vào chi tiết hóa đơn ");
            }
            else
            {
                if (txtManv.Text == string.Empty)
                {
                    MessageBox.Show("Hãy nhập vào mã nhân viên ");
                }
                else
                {
                    if (txtSl.Text == string.Empty)
                    {
                        MessageBox.Show("Hãy nhập vào số lượng ");
                    }
                    else
                    {
                        try
                        {
                            //lấy thông tin từ các textbox, combobox
                            int mahd = int.Parse(txtMahd.Text);

                            int macthd = int.Parse(txtMactHD.Text);
                            int manv = int.Parse(txtManv.Text);


                            float sl = float.Parse(txtSl.Text);
                            string tenmonan = Cbbmon.Text.ToString();
                            int mamonan = 0;

                            foreach (Monan_DTO mon in list)
                            {
                                if (tenmonan.CompareTo(mon.Tenmonan) == 0)
                                {
                                    mamonan = mon.Mamonan;//lấy mã món ăn theo tên món ăn
                                    break;
                                }


                            }
                            if (macthd != 0 && mahd != 0 && manv != 0 && sl != 0.0F && tenmonan != null && mamonan != 0)
                            {
                                insertCTHD(macthd, mahd, mamonan, sl);//insert thông tin vào bảng chi tiết hóa đơn trong database
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hãy điền đầy đủ thông tin ");
                            }


                        }
                        catch
                        {
                            MessageBox.Show("Mã chi tiết hóa đơn đã tồn tại");
                        }

                    }

                }
            }
            
        }
        private void loadfoodbythucdon(int id)
        {
            //load danh sách món ăn cho combobox
            list = monan_DAO.Instance.getlisbyID(id);
            Cbbmon.DataSource = list;
            Cbbmon.DisplayMember = "tenmonan";
            //foreach(Monan_DTO mon in list)
            //{
            //    Cbbmon.Items.Add(mon.Tenmonan.ToString());
            //}
        }
        private void loadcb()
        {
            //load danh sách nhóm món ăn cho combobox
            List<Nhommonan_DTO> group = nhommonan_DAO.Instance.loadtennhom();
            cbbthucdon.DataSource = group;
            cbbthucdon.DisplayMember = "tennhom";

            //foreach (Nhommonan_DTO nhom in group)
            //{

            //    cbbthucdon.Items.Add(nhom.Tennhom.ToString());

            //}
        }

        private void cbbthucdon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load danh sách món ăn theo nhóm món ăn được chọn ở combobox nhóm món ăn
            int id = 0;
            ComboBox cb = sender as ComboBox; //tạo đối tượng combobox và gán nó bằng sender được chọn
            if (cb.SelectedItem == null)
                return;
            Nhommonan_DTO selected = cb.SelectedItem as Nhommonan_DTO;//tạo đối tượng nhóm món ăn
            id = selected.Manhom;//lấy mã nhóm món ăn
            loadfoodbythucdon(id);//load danh sách món ăn theo mã món ăn
        }

        private void frmThemmon_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
