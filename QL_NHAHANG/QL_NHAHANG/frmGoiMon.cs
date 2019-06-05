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
using System.Globalization;

namespace QL_NHAHANG
{
    public partial class frmGoiMon : Form
    {
        float tongtien = 0;
        List<Ban_DTO> listban;
        public frmGoiMon()
        {
            InitializeComponent();
            loadban();//load các bàn ăn
            loadlistbana();//load thông tin của bàn được chọn
            loadcbb();
        }
        //load thông tin bàn
        private void loadlistbana()
        {
            dgv_DSBan.Controls.Clear();//xóa thông tin cũ trong listview
            dgv_DSBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DSBan.DataSource = ban_DAO.Instance.getBan();//gán datasource
        }

        //load combobox danh sách bàn
        private void loadcbb()
        {
            cbbban.DataSource = listban;
            cbbban.DisplayMember = "Tenban";
        }

        //load danh sách bàn
       
        public  void loadban()
        {
            fltable.Controls.Clear();
            listban = ban_DAO.Instance.getlistban();
            foreach(Ban_DTO table in listban)
            {
                Button btn = new Button() { Width=Ban_DTO.with,Height = Ban_DTO.hight , Font = new Font("Arial", 9, FontStyle.Bold) };//thiết kế button hiển thị các bàn
                btn.Text = table.Tenban + Environment.NewLine + table.Trangthai + Environment.NewLine + "Khu Vực: " + table.Makhuvuc.ToString();// set text button bằng tên của bàn
                btn.Tag = table;
                btn.Click += Btn_Click;//sự kiện click vào bàn
                //thay đổi màu cảu button theo trạng thái của bàn 
                switch (table.Trangthai)
                {
                    case "Còn trống":
                        btn.BackColor = Color.RoyalBlue;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                fltable.Controls.Add(btn);//add button vào control

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //load thông tin của bàn khi click vào 1 bàn nào đó
            try {
                tongtien = 0;
                int maban = ((sender as Button).Tag as Ban_DTO).Maban;
                lvhd.Tag = (sender as Button).Tag;
                showmenu(maban);
                }
            catch
            {

            }
            
        }
        //hàm show thông tin của bàn theo mã bàn
        void showmenu(int maban)
        {
            lvhd.Items.Clear();
     
            List<Menu_DTO> list = Menu_DAO.Instance.getmenu(maban);//lấy danh sách thông tin bàn

            
            foreach (Menu_DTO item in list)
            {
                //add danh sách thông tin bàn vào listview
                ListViewItem lvitem = new ListViewItem(item.Mahd.ToString());
                lvitem.SubItems.Add(item.Tenban.ToString());
                lvitem.SubItems.Add(item.Tenmonan.ToString());
                lvitem.SubItems.Add(item.Soluong.ToString());
                lvitem.SubItems.Add(item.Dongia.ToString());
                tongtien += item.Dongia*item.Soluong;
                lvitem.SubItems.Add(item.Donvi.ToString());
                lvhd.Items.Add(lvitem);
            }
            CultureInfo cutural = new CultureInfo("vi-VN");//thiết lập đơn vị tiền tệ
            txttongtien.Text = tongtien.ToString("c",cutural);
        }

        void showhd(int maban)
        {
            try
            {
                lvhd.Items.Clear();
                List<CThd_DTO> list = CthdX_DAO.Instance.getlistbyhdid(HoadonX_DAO.Instance.getidhdbayidban(maban));//lấy danh sách hóa đơn của bàn
                //add danh sách hóa đơn vào mảng
                foreach (CThd_DTO item in list)
                {
                    ListViewItem lvitem = new ListViewItem(item.Macthd.ToString());
                    lvitem.SubItems.Add(item.Mamonan.ToString());
                    lvhd.Items.Add(lvitem);
                }
            }
            catch
            {

            }
            
        }
        private void btn_GoiMon_Click(object sender, EventArgs e)
        {
            btn_LamMoi.Enabled = btn_InHoaDon.Enabled = btn_ThanhToan.Enabled = true;
            try
            {
                Ban_DTO ban = lvhd.Tag as Ban_DTO;
                if (ban != null)
                {


                    int mahd = HoadonX_DAO.Instance.getidhdbayidban(ban.Maban);//lấy mã hóa đơn từ mã bàn
                    if (mahd == -1)
                    {
                        frmChonmon.maban = ban.Maban;
                        frmChonmon f = new frmChonmon();
                        f.ShowDialog();
                    }
                    else
                    {
                        frmThemmon.mahoadon = mahd;
                        frmThemmon f = new frmThemmon();
                        f.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn bàn");
                }
            }
            catch
            {

            }

            loadlistbana();//load lại danh sách bàn
        }
        private void gopban()
        {
            try
            {
                Ban_DTO ban1 = lvhd.Tag as Ban_DTO;//lấy thông tin bàn thứ nhất
                Ban_DTO ban2 = cbbban.SelectedItem as Ban_DTO;//lấy thông tin bàn thứ hai
                foreach(Ban_DTO b in listban)
                {
                    if (string.Compare(cbbban.Text, b.Tenban) == 0)
                    {
                        ban2 = b;
                        
                    }
                    if (string.Compare(ban1.Tenban, b.Tenban) == 0)
                    {
                        ban1 = b;
                        
                    }
                }
                if (ban1.Trangthai.Equals("Còn trống"))
                {
                    MessageBox.Show("Bàn: " + ban1.Tenban + " Trống");
                }
                else
                {
                    if (ban2.Trangthai.Equals("Còn trống"))
                    {
                        MessageBox.Show("Bàn: " + ban2.Tenban + " Trống");
                    }
                    else
                    {
                        if (ban1.Maban == ban2.Maban)
                        {
                            MessageBox.Show("Trùng Bàn !");
                        }
                        else
                        {
                            if (MessageBox.Show(string.Format("Bạn co muốn gọp bàn :   {0} vào bàn:   {1} không ?", ban1.Tenban, ban2.Tenban), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                Goimon_DAO.Instance.gopban(ban1.Maban, ban2.Maban);//gọi hàm gọp bàn
                            loadcbb();
                            loadban();
                            loadlistbana();
                        }
                        
                    }
                }
                
            }
            catch
            {
                MessageBox.Show(" Bàn Trống ");
            }
            
            
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ban_DTO ban = lvhd.Tag as Ban_DTO;  //tạo đối tượng bàn
            DateTime dt = new DateTime();
            
            
            try
            {
                

                if (ban != null)
                {
                    DialogResult rs = MessageBox.Show("Bạn đang chọn bàn : " + ban.Tenban, "Nhắc nhở ", MessageBoxButtons.OKCancel);
                    if(rs==DialogResult.OK)
                    {
                        if (HoadonX_DAO.Instance.thanhtoan(ban.Maban))
                        {
                            MessageBox.Show("Thanh toán thành công");
                            if (tongtien != 0)
                            {
                                Menu_DAO.Instance.addbaocao(ban.Tenban, dtp_ThoiGian.Value, tongtien);//add vào bảng báo cáo khi thanh toán
                            }
                            lvhd.Items.Clear();
                            tongtien = 0;
                            txttongtien.Text = "0";
                            
                            loadlistbana();//load lại danh sách bàn
                            loadban();// load lại thông tin bàn
                        }
                    }

                    
                }
                else
                {
                    MessageBox.Show("Hãy chọn bàn cần thanh toán");
                }
            }
            catch
            {

            }
            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load lại danh sách bàn vào thông tin bàn
            
            loadcbb();
            loadban();
            loadlistbana();
   
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //set thông tin hóa đơn vào giấy in
            try
            {
                Ban_DTO ban = lvhd.Tag as Ban_DTO;
                if (ban != null)
                {
                    List<Menu_DTO> list = Menu_DAO.Instance.getmenu(ban.Maban);
                    Menu_DTO menu1 = list[0];
                    DateTime dt = new DateTime();

                    //vẽ các string vào graphics, giấy in như một đối tượng graphics
                    e.Graphics.DrawString(@" Nhà Hàng Rose
 Kính Chào Quý Khách ", new Font("Brush", 25, FontStyle.Italic), Brushes.Black, 0, 20);
                   e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 300, 200);
                    e.Graphics.DrawString("KHÁCH HÀNG: " + menu1.Tenkh  , new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 50, 300);
                   float y = 400;
                    

                    e.Graphics.DrawString("Tên Bàn: " + menu1.Tenban, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 50, 350);


                    e.Graphics.DrawString("Tên Món Ăn: " + "  | ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 50, 400);

                    e.Graphics.DrawString("Số Lượng: " + "  | ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 300, 400);

                    e.Graphics.DrawString("Đơn Giá: ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 500, 400);

                    foreach (Menu_DTO menu in list)
                    {
                        y += 50;
                        

                        e.Graphics.DrawString(menu.Tenmonan, new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 50, y);

                        e.Graphics.DrawString(menu.Soluong.ToString(), new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 350, y);

                        e.Graphics.DrawString(menu.Dongia.ToString() + " đ ", new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 520, y);

                    }
                    e.Graphics.DrawString("Tổng Tiền :  " + txttongtien.Text, new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 400, y + 50);
                    e.Graphics.DrawString("Ngày thanh toán :  " + DateTime.Now.ToString(), new Font("Arial", 20, FontStyle.Italic), Brushes.Black, 300, y + 100);
                    e.Graphics.DrawString("Nhân viên thanh toán :  ", new Font("Arial", 15, FontStyle.Italic), Brushes.Black, 400, y + 150);


                }
            }
            catch
            {

            }
            
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;//thiết lập giấy in
            printPreviewDialog1.ShowDialog();//hiển thị thông tin hóa đơn trên giấy in
        }

        private void frmGoiMon_Load(object sender, EventArgs e)
        {
            btn_ThanhToan.Enabled = btn_InHoaDon.Enabled = btn_LamMoi.Enabled = false;
        }

        private void frmGoiMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
            gopban();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dgv_DSBan_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
