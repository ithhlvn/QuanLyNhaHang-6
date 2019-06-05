using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class nhomnl_DTO
    {
        int mannl;
        string tennnl;
        private nhomnl_DTO() { }
        public nhomnl_DTO(int mannl,string tennnl)
        {
            this.mannl = mannl;
            this.tennnl = tennnl;
        }
        public nhomnl_DTO(DataRow row)
        {
            this.mannl = int.Parse(row["MANNL"].ToString());
            this.tennnl = row["TENNNL"].ToString();
        }
        public int Mannl { get { return mannl; } set {this.mannl = value; } }
        public string Tennnl { get { return tennnl; } set {this.tennnl = value; } }

    }
}
