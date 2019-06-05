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
    public partial class frmDinhLuong : Form
    {
        public frmDinhLuong()
        {
            InitializeComponent();
        }

        private void frmDinhLuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void grbDanhSachMonAn_Enter(object sender, EventArgs e)
        {
            this.grbDanhSachMonAn.BackColor = Color.Transparent;
        }

        private void grbDinhLuongMonAn_Enter(object sender, EventArgs e)
        {
            this.grbDinhLuongMonAn.BackColor = Color.Transparent;
        }
    }
}
