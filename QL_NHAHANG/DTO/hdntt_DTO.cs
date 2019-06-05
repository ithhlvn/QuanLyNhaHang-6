using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class hdntt_DTO
    {
        float tien;
        float sl;

        private hdntt_DTO() { }
        public hdntt_DTO(float tien,float sl)
        {
            this.tien = tien;
            this.sl = sl;
        }
        public hdntt_DTO(DataRow row)
        {
            this.tien = float.Parse(row["DONGIA"].ToString());
            this.sl = float.Parse(row["SOLUONG"].ToString());
        }
        public float Tien { get { return tien; } set {this.tien = value; } }

        public float Sl { get { return sl; } set { this.sl = value; } }
    }
}
