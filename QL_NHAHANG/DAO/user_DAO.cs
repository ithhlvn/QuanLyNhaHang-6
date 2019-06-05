using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class user_DAO
    {
        private static user_DAO instance;

        public static user_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new user_DAO();
                return instance;
            }

            set
            {
                user_DAO.instance = value;
            }
        }
        private user_DAO() { }
        public bool login(string username, string password)
        {
            string query = "SELECT * FROM DBO.NGUOIDUNG WHERE TENND=N'" + username + " ' AND MATKHAU=N'" + password + " '";
            DataTable result = DBconection.Instrance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool createND(int ma, string user, string pass)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_creatuser @manv , @user , @matkhau ", new object[] { ma,user,pass });
            return n > 0;
        }
        public bool updateuser(string user , string pass, string pass1)
        {
            int n = DBconection.Instrance.ExecuteNonQuery("EXEC usp_updateuser2 @user , @pass , @pass1 ", new object[] { user, pass, pass1 });
            return n > 0;
        }
    }
}
