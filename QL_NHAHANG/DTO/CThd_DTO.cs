using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class CThd_DTO
    {
        int macthd;
        int mahd;
        int mamonan;
        float soluong;
        private CThd_DTO() { }
        public CThd_DTO(int mact, int mahd,int mamon,float soluong)
        {
            this.macthd = mact;
            this.mahd = mahd;
            this.mamonan = mamon;
            this.soluong = soluong;
        }
        public CThd_DTO(DataRow row)
        {
            this.macthd = int.Parse(row["MACTHDX"].ToString());
            this.mahd = int.Parse(row["MAHDX"].ToString());
            this.mamonan = int.Parse(row["MAMA"].ToString());
            this.soluong = float.Parse(row["SOLUONG"].ToString());
        }

        public int Macthd { get { return macthd; } set {this.macthd = value; } }
        public int Mahd { get { return mahd; } set { this.mahd = value; } }
        public int Mamonan { get { return mamonan; } set { this.mamonan = value; } }
        public float Soluong { get { return soluong; } set {this.soluong = value; } }
    }
}
