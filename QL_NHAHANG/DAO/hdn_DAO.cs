using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class hdn_DAO
    {
        private static hdn_DAO instance;

        public static hdn_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new hdn_DAO();

                return hdn_DAO.instance;
            }

            private set
            {
                hdn_DAO.instance = value;
            }
        }
        private hdn_DAO() { }
        public bool insert(int mahd,int manv, string ten)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_inserthdnhap @mahdn , @manv , @tenncc ", new object[] {mahd,manv,ten });
            return n > 0;

        }
        public bool insertct(int macthd, int mahd, int manl, float soluong)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertcthdnv @macthd , @mahd , @manl , @soluong", new object[] {macthd,mahd,manl,soluong });
            return n > 0;
                
        }
        public DataTable getcthd()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT DISTINCT a.MACTHDN, a.MAHDN, a.MANL,a.SOLUONG,c.DONGIA,b.MANCC FROM dbo.CHITIETHOADONNHAP a ,dbo.HOADONNHAP b,dbo.NGUYENLIEU c WHERE a.MANL = c.MANL");
        }
        public List<hdntt_DTO> gettt()
        {
            List<hdntt_DTO> list = new List<hdntt_DTO>();
            DataTable tb = DBconection.Instrance.ExecuteQuery("SELECT DISTINCT a.MACTHDN, a.MAHDN, a.MANL,a.SOLUONG,c.DONGIA,b.MANCC FROM dbo.CHITIETHOADONNHAP a ,dbo.HOADONNHAP b,dbo.NGUYENLIEU c WHERE a.MANL = c.MANL");
            foreach (DataRow row in tb.Rows)
            {
                hdntt_DTO menu = new hdntt_DTO(row);
                list.Add(menu);
            }
            return list;
        }
    }
}
