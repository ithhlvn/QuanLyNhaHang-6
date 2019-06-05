using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class khuvuc_DAO
    {
        private static khuvuc_DAO instance;

        public static khuvuc_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new khuvuc_DAO();

                return khuvuc_DAO.instance;
            }

            private set
            {
                khuvuc_DAO.instance = value;
            }
        }
        private khuvuc_DAO() { }
        public DataTable getKV()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM DBO.KHUVUC");
        }
        public bool insertkv(int mkv,string tenkv,string trangthai)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertkhuvuc @makv , @tenkv , @trangthai ",new object[] { mkv,tenkv,trangthai});
            return n > 0;
        }
        public bool updatetkv(int mkv, string tenkv,string trangthai)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updatekhuvuc @makv , @tenkv , @trangthai ", new object[] { mkv, tenkv, trangthai });
            return n > 0;
        }
    }
}
