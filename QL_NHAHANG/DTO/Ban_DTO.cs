using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Ban_DTO
    {
        //lớp đối tượng bàn
        private int maban;
        private string tenban;
        private int makhuvuc;
        private string trangthai;

        public static int with = 90;
        public static int hight = 90;
        public Ban_DTO() { }

        public Ban_DTO(int maban,int makv,string tenban,string trangthai)
        {
            this.maban = maban;
            this.makhuvuc = makv;
            this.tenban = tenban;
            this.trangthai = trangthai;

        }
        public Ban_DTO(DataRow data)
        {
            this.maban = int.Parse(data["MABAN"].ToString());
            this.makhuvuc = int.Parse(data["MAKV"].ToString());
            this.tenban = data["TENBAN"].ToString();
            this.trangthai = data["TRANGTHAI"].ToString();
        }

        public int Maban {
            get {return maban; } set {this.maban = value; }
        }
        public string Tenban { 
             get {return tenban; } set {this.tenban = value; } }
        public int Makhuvuc { get {return makhuvuc; } set {this.makhuvuc = value; } }
        public string Trangthai { get {return trangthai; } set { this.trangthai = value; } }
    }
}
