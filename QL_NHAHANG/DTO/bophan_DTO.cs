using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class bophan_DTO
    {
        int ma;
        string ten;

        public bophan_DTO(int ma, string ten)
        {
            this.Ma = ma;
            this.Ten = ten;
        }
        public bophan_DTO(DataRow row)
        {
            this.Ma = int.Parse(row["MABP"].ToString());
            this.Ten = row["TENBP"].ToString();
        }

        public int Ma {get {return ma; } set {this.ma = value; } }
        public string Ten { get { return ten; } set {this.ten = value; } }
    }
}
