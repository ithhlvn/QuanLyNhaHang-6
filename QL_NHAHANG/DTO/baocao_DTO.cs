using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class baocao_DTO
    {
        //lớp đối tượng báo cáo
        string ban;
        DateTime ngay;
        float tongtien;

        public baocao_DTO(string ban, DateTime ngay, float tongtien)
        {
            this.Ban = ban;
            this.Ngay = ngay;
            this.Tongtien = tongtien;
        }
        public baocao_DTO(DataRow row)
        {
            this.Ban = row["TENBAN"].ToString();
            this.Ngay = (DateTime)row["NGAY"];
            this.Tongtien = float.Parse(row["TONGTIEN"].ToString());
        }

        public string Ban { get { return ban; } set { this.ban = value; } }
        public DateTime Ngay { get { return ngay; } set { this.ngay = value; } }
        public float Tongtien { get { return tongtien; } set { this.tongtien = value; } }
    }
}
