using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class Menu_DAO
    {
        private static Menu_DAO instance;

        public static Menu_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Menu_DAO();

                return Menu_DAO.instance;
            }

            private set
            {
                Menu_DAO.instance = value;
            }
        }
        private Menu_DAO() { }
        public List<Menu_DTO> getmenu(int maban)
        {
            List<Menu_DTO> list = new List<Menu_DTO>();
            DataTable tb = DBconection.Instrance.ExecuteQuery("EXEC usp_getmenu5 @maban ", new object[] { maban });
            foreach(DataRow row in tb.Rows)
            {
                Menu_DTO menu = new Menu_DTO(row);
                list.Add(menu);
            }
            return list;
        }
        public bool addbaocao(string ban,DateTime ngay,float tong)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertbaocao @tenban , @ngay , @tongtien ",new object[] { ban,ngay,tong});
            return n > 0;
        }
        public List<baocao_DTO> getbaocao()
        {
            List<baocao_DTO> list = new List<baocao_DTO>();
            DataTable tb = DBconection.Instrance.ExecuteQuery("SELECT * FROM dbo.BAOCAO1 ");
            foreach (DataRow row in tb.Rows)
            {
                baocao_DTO menu = new baocao_DTO(row);
                list.Add(menu);
            }
            return list;
        }
        public DataTable getl()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM dbo.BAOCAO1");
        }
        
    }
}
