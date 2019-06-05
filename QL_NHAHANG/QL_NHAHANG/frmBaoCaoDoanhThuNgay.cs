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
    public partial class frmBaoCaoDoanhThuNgay : Form
    {
        public frmBaoCaoDoanhThuNgay()
        {
            InitializeComponent();
            load();//load datagridview 
        }
        void load()
        {
            float tong = 0.0F;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//thiết lập tham số cho các cột autosize cho vừa bảng gridview
            dataGridView1.DataSource = Menu_DAO.Instance.getl();//gán datasource cho datagridview
            List<baocao_DTO> ls = Menu_DAO.Instance.getbaocao();//lấy danh sách các báo cáo từ database
            foreach(baocao_DTO a in ls)
            {
                tong += a.Tongtien;//tính tổng doanh thu
            }
            textBox1.Text = tong.ToString();//gán tổng doanh thu ào textbox
        }

        private void frmBaoCaoDoanhThuNgay_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BÁO CÁO DOANH THU", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 105, 120);
            int x = dataGridView1.Height;
            int y = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;
            //tạo bitmap để vẽ lên document
            Bitmap btm = new Bitmap(this.dataGridView1.Width,this.dataGridView1.Height);
            //cắt datagridview chuyển sang bitmap
            dataGridView1.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridView1.Width - 15, this.dataGridView1.Height));
            e.Graphics.DrawImage(btm,150,380);
            dataGridView1.Height = x;
            e.Graphics.DrawString("Ngày báo cáo       :   " + DateTime.Now.ToString(), new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 150, 200);
            e.Graphics.DrawString("Tổng doanh thu     :   "+textBox1.Text + " VND", new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 150, 240);
            e.Graphics.DrawString("Nhân viên          :........................................... " , new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 150,280);
            e.Graphics.DrawString("BẢNG CHI TIẾT", new Font("Arial", 25 , FontStyle.Italic), Brushes.Black, 280, 325);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
