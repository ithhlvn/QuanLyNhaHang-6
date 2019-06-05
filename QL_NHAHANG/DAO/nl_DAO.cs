using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class nl_DAO
    {
        private static nl_DAO instance;

        public static nl_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nl_DAO();

                return nl_DAO.instance;
            }

            private set
            {
                nl_DAO.instance = value;
            }
        }
        private nl_DAO() { }
        public DataTable getnl()
        {
            return DBconection.Instrance.ExecuteQuery(" SELECT * FROM dbo.NGUYENLIEU ");
        }
        public bool insertnnl(int manll, string tennl, float dongia, string donvitinh ,string ten)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertnguyenlieu2 @manl  , @tennl , @dongia , @donvitinh , @ten ",new object[] { manll,tennl,dongia, donvitinh,ten });
            return n > 0;
        }
        public bool updatennl(int manll, string tennl, float dongia, string donvitinh, string ten)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updatenl1 @manl  , @tennl , @ten , @dongia , @donvitinh  ", new object[] { manll, tennl , ten , dongia, donvitinh});
            return n > 0;
        }
        public bool deletenl(int ma)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_deletenl @manl  ", new object[] { ma });
            return n > 0;
        }
        public List<nl_DTO> getlistnl()
        {
            List<nl_DTO> group = new List<nl_DTO>();
            DataTable table = DBconection.Instrance.ExecuteQuery("SELECT * FROM dbo.NGUYENLIEU");
            foreach (DataRow row in table.Rows)
            {
                nl_DTO nhom = new nl_DTO(row);
                group.Add(nhom);
            }
            return group;
        }
    }
}
