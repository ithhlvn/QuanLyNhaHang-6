using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class nhommonan_DAO
    {
        private static nhommonan_DAO instance;

        public static nhommonan_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nhommonan_DAO();

                return nhommonan_DAO.instance;
            }

            private set
            {
                nhommonan_DAO.instance = value;
            }
        }
        private nhommonan_DAO() { }
        public DataTable getNhommonan()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM DBO.NHOMMONAN");
        }
        public bool insertnhommonan(int manhom, string tennhom)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertmaMA @manma , @tennma ",new object[] { manhom,tennhom});
            return n > 0;
        }
        public bool updatenhommonan(int manhom, string tennhom)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updatemaMA @manma , @tennma ", new object[] { manhom, tennhom });
            return n > 0;
        }
        public bool deletenhommonan(int manhom)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_deletemaMA @manma  ", new object[] { manhom });
            return n > 0;
        }
        public List<Nhommonan_DTO> loadtennhom()
        {
            List<Nhommonan_DTO> group = new List<Nhommonan_DTO>();
            DataTable table = DBconection.Instrance.ExecuteQuery("SELECT * FROM dbo.NHOMMONAN");
            foreach(DataRow row in table.Rows)
            {
                Nhommonan_DTO nhom = new Nhommonan_DTO(row);
                group.Add(nhom);
            }
            return group;
        }
    }
}
