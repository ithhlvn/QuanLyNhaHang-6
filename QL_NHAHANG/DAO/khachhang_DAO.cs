using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class khachhang_DAO
    {
        private static khachhang_DAO instance;

        public static khachhang_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new khachhang_DAO();

                return khachhang_DAO.instance;
            }

            private set
            {
                khachhang_DAO.instance = value;
            }
        }
        private khachhang_DAO() { }
        public DataTable getKhachhnag()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM DBO.KHACHHANG");//thực hiện câu truy vấn SQL trong database
        }
        public bool insertkh(int makh,string tenKH,string diachi)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertKH @makh , @tenKH , @diachi ", new object[] { makh , tenKH,diachi});
            return n > 0;
        }
        public bool updatekh(int makh,string tenkh,string diachi)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updateKH @makh , @tenKH , @diachi ", new object[] { makh , tenkh ,diachi});
            return n > 0;
        }
        public bool delete(int makh)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_deleteKH @makh ", new object[] { makh });
            return n > 0;
        }
    }
}
