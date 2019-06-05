using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using DAO;
namespace DAO
{
    public class nhaCC_DAO
    {
        private static nhaCC_DAO instance;

        public static nhaCC_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new nhaCC_DAO();

                return nhaCC_DAO.instance;
            }

            private set
            {
                nhaCC_DAO.instance = value;
            }
        }
        private nhaCC_DAO() { }
        public DataTable getNCC()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM DBO.NHACUNGCAP");
        }
        public bool insertNCC(int mancc, string tenncc, string diachi)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertNCC @mancc , @tenncc , @diachi ",new object[] { mancc,tenncc,diachi });
            return n > 0;
        }
        public bool updateNCC(int mancc, string tenncc, string diachi)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updateNCC @mancc , @tenncc , @diachi ", new object[] { mancc, tenncc, diachi });
            return n > 0;
        }
        public bool deleteNCC(int mancc)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_deletencc @mancc  ", new object[] { mancc});
            return n > 0;
        }
        public List<ncc_DTO> getlist()
        {
            List<ncc_DTO> group = new List<ncc_DTO>();
            DataTable table = DBconection.Instrance.ExecuteQuery("SELECT * FROM dbo.NHACUNGCAP");
            foreach (DataRow row in table.Rows)
            {
                ncc_DTO nhom = new ncc_DTO(row);
                group.Add(nhom);
            }
            return group;
        }
    }
}
