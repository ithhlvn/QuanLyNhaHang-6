using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QL_NHAHANG
{
    public partial class frmQuanLyNhaHang : Form
    {
        public static frmGoiMon gm;
        private int img = 1;
        public frmQuanLyNhaHang()
        {
            InitializeComponent();
            timer1.Start();//khởi động timer tick
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmDangNhap.key==1)
            {
                //Mở form quản lý nhân viên
                frmNhanVien nv = new frmNhanVien();
                nv.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
            
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.key == 1)
            {
                //....
                frmKhachHang kh = new frmKhachHang();
                kh.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
            
        }

        private void phânQuyềnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmDangNhap.key == 1)
            {
                frmNhaCungCap ncc = new frmNhaCungCap();
                ncc.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }

          
        }

        private void phânQuyềnSửDụngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (frmDangNhap.key == 1)
            {
                frmuser pq = new frmuser();
                pq.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }

            
            
        }

        private void bànKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.key == 1)
            {
                frmBan b = new frmBan();
                b.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
            
        }

        private void hệThốngKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.key == 1)
            {
                frmKhuVuc kv = new frmKhuVuc();
                kv.Show();
            }
            else
            {

                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
           
        }

        private void loạiThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.key == 1)
            {
                frmNhomMonAn nma = new frmNhomMonAn();
                nma.Show();
            }
            else
            {

                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
            
        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.key == 1)
            {
                frmMonAn ma = new frmMonAn();
                ma.Show();
            }
            else
            {

                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }

            
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gm = new frmGoiMon();
            gm.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap hdn = new frmHoaDonNhap();
            hdn.Show();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.key == 1)
            {
                frmBaoCaoDoanhThuNgay hdx = new frmBaoCaoDoanhThuNgay();
                hdx.Show();
            }
            else
            {

                MessageBox.Show("Bạn phải đăng nhập dưới quyền admin");
            }
            
        }

        private void frmQuanLyNhaHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            { e.Cancel = true; }
         
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void frmQuanLyNhaHang_Load(object sender, EventArgs e)
        {
            
        }

        private void frmQuanLyNhaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //sét sự kiện mỗi lần timer tick thay đổi giá trị
            if (img == 1)
            {
                pictureBox1.Image = QL_NHAHANG.Properties.Resources.m101;
                img = 2;
            }
            else if(img ==2)
            {
                pictureBox1.Image = QL_NHAHANG.Properties.Resources.cac_nha_hang_tiec_cuoi_sang_trong_o_thanh_pho_ho_chi_minh;
                img = 3;
            }
            else if(img ==3)
            {
                pictureBox1.Image = QL_NHAHANG.Properties.Resources.tieng_anh_nha_hang;
               img = 4;
            }
            else
            {
                pictureBox1.Image = QL_NHAHANG.Properties.Resources.thiet_ke_noi_that_nha_hang_Nhat__1_;
               img = 1;
            }
             
        }

        private void quanrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmDangNhap.key==1)
            {
                frmNhomNguyenLieu f = new frmNhomNguyenLieu();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn hãy đăng nhập dưới quyền admin ");
            }
            
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.key == 1)
            {
                frmNguyenLieu f = new frmNguyenLieu();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn hãy đăng nhập dưới quyền admin ");
            }

        }

        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmDangNhap.key==1)
            {
                frmBoPhan f = new frmBoPhan();
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn hãy đăng nhập dưới quyền admin");
            }
            
        }

        private void đăngXuấtCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap.key = 0;
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doipass f = new doipass();
            f.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDangNhap.key == 1)
            {
                frmHoaDonNhap hdn = new frmHoaDonNhap();
                hdn.Show();
            }
            else
            {
                MessageBox.Show("Bạn hãy đăng nhập dưới quyền admin");
            }

            
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDanSuDung frm = new frmHuongDanSuDung();
            frm.Show();
        }

        private void bảoTrìDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
