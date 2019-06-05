using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Menu_DTO
    {
        int mahd;
        string tenban;
        string tenmonan;
        int soluong;
        float dongia;
        string donvi;
        string tenkh;
        private Menu_DTO() { }
        public Menu_DTO(int mahd, string tenban, string tenmon, int soluong, float dongia, string donvi, string tenkh)
        {
            this.mahd = mahd;
            this.tenban = tenban;
            this.tenmonan = tenmon;
            this.soluong = soluong;
            this.dongia = dongia;
            this.donvi = donvi;
            this.tenkh = tenkh;
           
        }
        public Menu_DTO(DataRow row)
        {
            this.mahd = int.Parse(row["MAHDX"].ToString());
            this.tenban = row["TENBAN"].ToString();
            this.tenmonan = row["TENMA"].ToString();
            this.soluong = int.Parse(row["SOLUONG"].ToString());
            this.dongia = int.Parse(row["DONGIA"].ToString());
            this.donvi = row["DONVITINH"].ToString();
            this.tenkh = row["TENKH"].ToString();
            
        }

        public int Mahd { get { return mahd; } set { this.mahd = value; } }
        public string Tenban { get { return tenban; } set { this.tenban = value; } }
        public string Tenmonan { get { return tenmonan; } set { this.tenmonan = value; } }
        public float Dongia { get { return dongia; } set { this.dongia = value; } }
        public string Donvi { get { return donvi; } set { this.donvi = value; } }
        public int Soluong { get { return soluong; } set { this.soluong = value; } }

        public string Tenkh { get {return tenkh; } set {this.tenkh = value; } }
    }
}
