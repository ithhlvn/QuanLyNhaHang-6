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
    public partial class frmBan : Form
    {
        public frmBan()
        {
            InitializeComponent();
            loadban();
        }
        private void loadban()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = ban_DAO.Instance.getBan();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //Lấy các giá trị từ các textbox
            string teneban = txt_tenban.Text;
            string tenkhv = lsb_tenkv.Text;
            string trangthai = lsb_trangthai.Text;
            if (teneban == string.Empty)//kiểm tra tên bàn đã được nhập chưa
            {
                MessageBox.Show("Hãy Nhập Tên Bàn");
            }               
            else
            {
                if (tenkhv == string.Empty)//kiểm tra tên kv có được nhập chưa
                {
                    MessageBox.Show("Hãy Nhập Tên Khu Vực");
                }
                else
                {
                    if (trangthai == string.Empty)//kiểm tra trạng thái bàn đã được nhập chưa
                    {
                        MessageBox.Show("Hãy Nhập Trạng Thái");
                    }
                    else
                    {
                        if(txt_maban.Text == string.Empty)//Kiểm tra mã bàn đã được nhập chưa
                            MessageBox.Show("Hãy Nhập Mã Bàn");
                        else
                        {
                            try
                            {
                                int maban = int.Parse(txt_maban.Text);
                                if (ban_DAO.Instance.insertBan(maban, teneban, tenkhv, trangthai))//truyên tham số vào hàm insert trong lớp ban_DAO
                                {
                                    MessageBox.Show("Thành công!");
                                    loadban();//load lại gridview danh sách bàn

                                    foreach(Control i in this.Controls)
                                    {
                                        if (i is TextBox || i is ListBox)
                                            i.ResetText();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Thất bại !");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Nhập sai mã bàn !");

                            }
                        }
                    }
                       
                }
                
            }
            

            

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //lấy các giá trị từ các textbox,...
            string teneban = txt_tenban.Text;
            string tenkhv = lsb_tenkv.Text;
            string trangthai = lsb_trangthai.Text;
            if (teneban == string.Empty)//Kiểm tra các giá trị có hợp lệ không
            {
                MessageBox.Show("Hãy Nhập Tên Bàn");
           
            }
            else
            {
                if (tenkhv == string.Empty)//Kiểm tra các giá trị có hợp lệ không
                {
                    MessageBox.Show("Hãy Nhập Tên Khu Vực");
                }
                else
                {
                    if (trangthai == string.Empty)
                    {
                        MessageBox.Show("Hãy Nhập Trạng Thái");
                    }
                    else
                    {
                        if (txt_maban.Text == string.Empty)
                            MessageBox.Show("Hãy Nhập Mã Bàn");
                        else
                        {
                            try
                            {

                                int maban = int.Parse(txt_maban.Text);
                                if (ban_DAO.Instance.updatetBan(maban, teneban, tenkhv, trangthai))//gọi hàm update và truyền tham số để thay đổi thông tin bàn
                                {
                                    MessageBox.Show("Thành công ");
                                    loadban();//load lại gridview
                                }
                                else
                                {
                                    MessageBox.Show("Thất bại ");
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
            

}

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maban.Text == string.Empty)//check xem mã bàn có được nhập chưa
                MessageBox.Show("Hãy Nhập Mã Bàn");
            try
            {
                int maban = int.Parse(txt_maban.Text);
                if (maban == 0)
                    MessageBox.Show("Hãy Nhập Mã Bàn");

                if (ban_DAO.Instance.deleteban(maban))//gọi hàm xóa bàn và truyền tham số
                {
                    MessageBox.Show("Thành công ");
                    loadban();//load lại gridview
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ ");
            }
            
        }

        private void frmBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void grb_ban_Enter(object sender, EventArgs e)
        {
            this.grb_ban.BackColor = Color.Transparent;
        }

        private void txt_maban_TextChanged(object sender, EventArgs e)
        {
            if (txt_maban.Text != string.Empty && txt_tenban.Text != string.Empty)
            {
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }
            else
            {
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
            }
        }

        private void txt_tenban_TextChanged(object sender, EventArgs e)
        {
            if (txt_maban.Text != string.Empty && txt_tenban.Text != string.Empty)
            {
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }
            else
            {
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
            }
        }

        private void txt_maban_Leave(object sender, EventArgs e)
        {
            if (txt_maban.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txt_maban, "Phải nhập mã bàn !");
            else
                this.errorProvider1.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_maban.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lsb_tenkv.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_tenban.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lsb_trangthai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            txt_maban.Focus();
        }
    }
}
