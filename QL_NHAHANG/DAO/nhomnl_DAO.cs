using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class nhomnl_DAO
    {
        private static nhomnl_DAO instance;

        public static nhomnl_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nhomnl_DAO();

                return nhomnl_DAO.instance;
            }

            private set
            {
                nhomnl_DAO.instance = value;
            }
        }
        private nhomnl_DAO() { }
        public DataTable getnhomnl()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM dbo.NHOMNGUYENLIEU");
        }
        public bool insertnhomnl(int ma,string ten)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertnhomnl @mannl , @tennnl", new object[] { ma, ten });
            return n > 0;
        }
        public bool updatennl(int ma,string ten)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updatenhomnl @mannl , @tennnl", new object[] { ma,ten });
            return n > 0;
        }
        public bool delete(int ma)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC ups_deletenhomnnl1 @mannl ", new object[] { ma });
            return n > 1 ;

        }
        public List<nhomnl_DTO> getlisnhom()
        {
            DataTable tb = DBconection.Instrance.ExecuteQuery("SELECT * FROM dbo.NHOMNGUYENLIEU");
            List<nhomnl_DTO> list = new List<nhomnl_DTO>();
            foreach(DataRow row in tb.Rows)
            {
                nhomnl_DTO x = new nhomnl_DTO(row);
                list.Add(x);
            }
            return list;
        }
    }
}
