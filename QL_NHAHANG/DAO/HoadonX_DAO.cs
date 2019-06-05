using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class HoadonX_DAO
    {
        private static HoadonX_DAO instance;

        public static HoadonX_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoadonX_DAO();

                return HoadonX_DAO.instance;
            }

            private set
            {
                HoadonX_DAO.instance = value;
            }
        }
        private HoadonX_DAO() { }
        public int getidhdbayidban(int idban)
        {
            List<hdxuat_DTO> list = new List<hdxuat_DTO>();
            DataTable db;
            db = DBconection.Instrance.ExecuteQuery("EXEC usp_getmahdbyidbana @maban ", new object[] { idban});
            if (db.Rows.Count > 0)
            {
                hdxuat_DTO hd = new hdxuat_DTO(db.Rows[0]);
                return hd.Mahd;
            }
            return -1;
        }
        public bool thanhtoan(int maban)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_thanhtoan2 @maban ", new object[] { maban });
            return n > 0;
        }
    }
}
