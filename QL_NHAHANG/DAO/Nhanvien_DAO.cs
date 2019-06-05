using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class Nhanvien_DAO
    {
        private static Nhanvien_DAO instance;

        public static Nhanvien_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Nhanvien_DAO();

                return Nhanvien_DAO.instance;
            }

            private set
            {
                Nhanvien_DAO.instance = value;
            }
        }
        private Nhanvien_DAO() { }
        public DataTable getNhanvien()
        {
            return DBconection.Instrance.ExecuteQuery("SELECT * FROM DBO.NHANVIEN");
        }
        public bool insertNhanvien(int maNV, string tenNV,string boPhan, string dThoai,string dChi,string gioitinh,DateTime ngaysinh)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insernhanvienprc2 @mnv , @tenbp , @ten , @gioitinh , @ngaysinh , @diachi , @dienthoai ", new object[] {maNV,boPhan,tenNV,gioitinh, ngaysinh ,dChi,dThoai });
            return n > 0;
        }
        public bool updateNhanvien(int maNV, string tenNV, string boPhan, string dThoai, string dChi, string gioitinh, DateTime ngaysinh)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_update3 @mnv , @tenbp , @ten , @gioitinh , @ngaysinh , @diachi , @dienthoai ", new object[] { maNV, boPhan, tenNV, gioitinh, ngaysinh, dChi, dThoai });
            return n > 0;
        }
        public bool deleteNhanvien(int maNV)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_DELETENvien @mnv", new object[] { maNV});
            return n > 0;
        }
        public DataTable getbp()
        {
            return DBconection.Instrance.ExecuteQuery(" SELECT * FROM dbo.BOPHAN ");
        }
        public List<bophan_DTO> getlist()
        {
            List<bophan_DTO> group = new List<bophan_DTO>();
            DataTable table = DBconection.Instrance.ExecuteQuery(" SELECT * FROM dbo.BOPHAN ");
            foreach (DataRow row in table.Rows)
            {
                bophan_DTO nhom = new bophan_DTO(row);
                group.Add(nhom);
            }
            return group;
        }
        public bool insertbophan(int ma,string ten)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertbophan @ma , @ten ",new object[] {ma, ten });
            return n > 0;
        }
    }
}
