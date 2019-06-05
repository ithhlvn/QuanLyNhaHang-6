using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ban_DAO
    {
        private static ban_DAO instance;//tạo đối tượng ban_DAO

        public static ban_DAO Instance//phương thức get & set
        {
            get
            {
                if (instance == null)
                    instance = new ban_DAO();

                return ban_DAO.instance;
            }

            private set
            {
                ban_DAO.instance = value;
            }
        }
        private ban_DAO() { }
        public DataTable getBan()//hàm lấy danh sách bàn từ database
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM DBO.BAN");//thực hiện câu truy vấn trên sql thông qua code c#
        }
        public bool insertBan(int maban,string tenban,string tenkhuvuc,string trangthai)//hàm insert thông tin bàn
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertban @maban , @tenban , @tenkhuvuc , @trangthai ",new object[] { maban,tenban,tenkhuvuc,trangthai});
            return n > 0;
        }
        public bool updatetBan(int maban, string tenban, string tenkhuvuc , string trangthai)//hàm update bàn
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updateban @maban , @tenban , @tenkhuvuc , @trangthai ", new object[] { maban, tenban, tenkhuvuc , trangthai});
            return n > 0;
        }
        public bool deleteban(int maban)//hàm xóa bàn
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_deleteban @maban", new object[] { maban });
            return n > 0;
        }
        public List<Ban_DTO> getlistban()//hàm lấy danh sách bàn và add vào mảng
        {
            List<Ban_DTO> listban = new List<Ban_DTO>();

            DataTable table = DBconection.Instrance.ExecuteQuery("SELECT * FROM DBO.BAN");
            foreach(DataRow row in table.Rows)
            {
                Ban_DTO ban = new Ban_DTO(row);
                listban.Add(ban);
            }

            return listban;
        }
    }
}
