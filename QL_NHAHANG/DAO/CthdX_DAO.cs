using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class CthdX_DAO
    {
        private static CthdX_DAO instance;

        public static CthdX_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CthdX_DAO();

                return CthdX_DAO.instance;
            }

            private set
            {
                CthdX_DAO.instance = value;
            }
        }
        private CthdX_DAO() { }
        public List<CThd_DTO> getlistbyhdid(int mahd)//lấy danh sách chi tiết hóa đơn theo mã hóa đơn
        {
            List<CThd_DTO> list = new List<CThd_DTO>();
            DataTable tb = DBconection.Instrance.ExecuteQuery("EXEC usp_getCThd @mahd ", new object[] { mahd });
            foreach(DataRow row in tb.Rows)
            {
                CThd_DTO hd = new CThd_DTO(row);
                list.Add(hd);
            }
            return list;
        }
    }
}
