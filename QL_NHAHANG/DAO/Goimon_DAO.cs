using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Goimon_DAO
    {
        private static Goimon_DAO instance;

        public static Goimon_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Goimon_DAO();

                return Goimon_DAO.instance;
            }

            private set
            {
                Goimon_DAO.instance = value;
            }
        }
        private Goimon_DAO() { }
        public bool updatesttban(int maban)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updatesttban @maban ", new object[] { maban });
            return n > 0;
        }
        public bool insertHD(int MAHDX, int MABAN, int MANV, DateTime THOIGIANVAO, int MAKH)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertHD @mahd , @maban , @manhanvien , @thoigianvao , @makh ", new object[] { MAHDX,MABAN,MANV,THOIGIANVAO,MAKH});
            return n > 0;
        }
        public bool insertCTHD(int MACTHDX, int MAHDX, int MAMA, float SOLUONG)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_insertHDX @macthd , @mahd , @maman , @soluong ", new object[] {MACTHDX,MAHDX,MAMA,SOLUONG }) ;
            return n > 0;
        }
        public bool gopban(int mb1, int mb2)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_gopbananc @idban1 , @idban2 ", new object[] { mb1,mb2});
            return n > 0;
        }
    }
}
