using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class monan_DAO
    {
        private static monan_DAO instance;

        public static monan_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new monan_DAO();

                return monan_DAO.instance;
            }

            private set
            {
                monan_DAO.instance = value;
            }
        }
        private monan_DAO() { }
        public DataTable getNhommonan()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM DBO.MONAN");
        }
        public bool insertmonan(string tennhom,int mamon,string tenmonan, float dongia, string donvitinh , string trangthai)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertmonan @tennhommonan , @mamonan , @tenmonan , @dongia , @donvitinh , @trangthai ",new object[] {tennhom,mamon,tenmonan,dongia,donvitinh,trangthai });
            return n > 0;
        }
        public bool updatetmonan(string tennhom, int mamon, string tenmonan, float dongia, string donvitinh,string trangthai)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updatemonan @tennhommonan , @mamonan , @tenmonan , @dongia , @donvitinh , @trangthai ", new object[] { tennhom, mamon, tenmonan, dongia, donvitinh ,trangthai});
            return n > 0;
        }
        public bool deletemonan(int mamon)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_deletemonan @mamon ", new object[] { mamon });
            return n > 0;
        }
        public List<Monan_DTO> getlisbyID(int id)
        {
            List<Monan_DTO> list = new List<Monan_DTO>();
            DataTable td = DBconection.Instrance.ExecuteQuery("EXEC usp_getlistfood @id ", new object[] { id });
            foreach(DataRow row in td.Rows)
            {
                Monan_DTO mon = new Monan_DTO(row);
                list.Add(mon);
            }
            return list;
        }
        public int getmamon(string ten)
        {

            return (int)DBconection.Instrance.ExecuteSalar("EXEC usp_getmamon @ten ", new object[] { ten});
        }
    }
}
