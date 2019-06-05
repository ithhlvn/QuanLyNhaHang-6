using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class nl_DTO
    {
        int manl;
        int mannl;
        string ten;
        float sol;
        string dv;

        public int Manl { get { return manl; } set { this.manl = value; } }
        public int Mannl { get { return mannl; } set { this.mannl = value; } }
        public string Ten { get { return ten; } set {this.ten = value; } }
        public float Sol { get { return sol; } set { this.sol = value; } }
        public string Dv { get { return dv; } set { this.dv = value; } }

        private nl_DTO() { }
        public nl_DTO(int manl, int mannl, string ten, float sol, string dv)
        {
            this.Manl = manl;
            this.Mannl = mannl;
            this.Ten = ten;
            this.Sol = sol;
            this.Dv = dv;
        }
        public nl_DTO(DataRow row)
        {
            this.Manl = int.Parse(row["MANL"].ToString());
            this.Mannl = int.Parse(row["MANNL"].ToString());
            this.Ten = row["TENNL"].ToString();
            this.Sol = float.Parse(row["DONGIA"].ToString());
            this.Dv = row["DONVITINH"].ToString();
        }
    }
}
