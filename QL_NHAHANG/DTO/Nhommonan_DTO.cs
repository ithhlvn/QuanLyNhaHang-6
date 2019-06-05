using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Nhommonan_DTO
    {
        private int manhom;
        private string tennhom;
        public Nhommonan_DTO() { }
        public Nhommonan_DTO(int manhom,string tennhom)
        {
            this.manhom = manhom;
            this.tennhom = tennhom;

        }
        public Nhommonan_DTO(DataRow data)
        {
            this.manhom = int.Parse(data["MANMA"].ToString());
            this.tennhom = data["TENNMA"].ToString();
        }
        public int Manhom
        {
            get
            {
                return manhom;
            }
            set
            {
                manhom = value;
            }
        }
        public string Tennhom
        {
            get
            {
                return tennhom;
            }
            set
            {
                tennhom = value;
            }
        }

    }
}
