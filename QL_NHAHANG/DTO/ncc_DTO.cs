using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class ncc_DTO
    {
        int mancc;
        string tenncc;
        string diachi;

        public int Mancc { get {return mancc; } set {this.mancc = value; } }
        public string Tenncc { get { return tenncc; } set { this.tenncc = value; } }
        public string Diachi { get { return diachi; } set { this.diachi = value; } }
        private ncc_DTO() { }
        public ncc_DTO(int ma,string ten,string dc)
        {
            this.mancc = ma;
            this.tenncc = ten;
            this.diachi = dc;
        }
        public ncc_DTO(DataRow row)
        {
            this.mancc = int.Parse(row["MANCC"].ToString());
            this.tenncc = row["TENNCC"].ToString();
            this.diachi = row["DIACHI"].ToString();
        }
    }
}
