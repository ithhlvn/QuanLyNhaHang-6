using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Loaithucdon_DTO
    {
        private int mathucdon;
        private string tenthucdon;
        private Loaithucdon_DTO() { }
        public Loaithucdon_DTO(int mathucdon,string tenthucdon)
        {
            this.mathucdon = mathucdon;
            this.tenthucdon = tenthucdon;
        }
        public Loaithucdon_DTO(DataRow row)
        {
            this.mathucdon = int.Parse(row["MANMA"].ToString());
            this.tenthucdon = row["TENNMA"].ToString();
        }

        public int Mathucdon { get { return mathucdon; } set { this.mathucdon = value; } }
        public string Tenthucdon { get { return tenthucdon; } set { this.tenthucdon = value; } }
    }
}
