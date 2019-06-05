using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class hdxuat_DTO
    {
        int mahd;
        int maban;
        private hdxuat_DTO() { }
        public hdxuat_DTO(int maHD,int maB)
        {
            this.mahd = maHD;
            this.maban = maB;
        }
        public hdxuat_DTO(DataRow row)
        {
            this.mahd = int.Parse(row["MAHDX"].ToString());
            this.maban = int.Parse(row["MABAN"].ToString());
        }
        public int Mahd { get { return mahd; } set {this.mahd = value; } }
        public int Maban { get { return maban; } set { this.maban = value; } }
    }
}
