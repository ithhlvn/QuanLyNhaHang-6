using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Monan_DTO
    {
        int mamonan;
        string tenmonan;
        float dongia;
        private Monan_DTO() { }
        public Monan_DTO(int mamon,string ten, float dongia)
        {
            this.mamonan = mamon;
            this.tenmonan = ten;
            this.dongia = dongia;
        }
        public Monan_DTO(DataRow row)
        {
            this.mamonan = int.Parse(row["MAMA"].ToString());
            this.tenmonan = row["TENMA"].ToString();
            this.dongia = float.Parse(row["DONGIA"].ToString());
        }

        public int Mamonan { get { return mamonan; } set { this.mamonan = value; } }
        public string Tenmonan { get { return tenmonan; } set {this.tenmonan = value; } }
        public float Dongia { get { return dongia; } set { this.dongia = value; } }
    }
}
