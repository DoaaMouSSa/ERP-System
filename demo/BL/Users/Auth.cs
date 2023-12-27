using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
// old
//namespace demo.BL.Users
//{
//    public class Auth
//    {
//        public DataTable Login(string userName,string pwd)
//        {
//            DAL.connection conn=new DAL.connection();
//            conn.openConnection();
//            SqlParameter[] param = new SqlParameter[2];
//            param[0]=new SqlParameter("@user_name",SqlDbType.NVarChar,20);
//            param[0].Value = userName;
//            param[1] = new SqlParameter("@pwd", SqlDbType.NVarChar, 20);
//            param[1].Value = pwd;
//            DataTable dt= new DataTable();
//            dt = conn.selectData("sp_Login", param);
//            conn.closeConnection();
//            return dt;
//        }
//    }
//}


// new

namespace demo.BL.Users
{
    public class Auth
    {
        public DataTable Login(string userName, string pwd)
        {
            DAL.connection conn = new DAL.connection();
            conn.openConnection();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@u_name", SqlDbType.NVarChar, 10);
            param[0].Value = userName;
            param[1] = new SqlParameter("@u_pwd", SqlDbType.NVarChar, 20);
            param[1].Value = pwd;
            DataTable dt = new DataTable();
            dt = conn.selectData("user_login", param);
            conn.closeConnection();
            return dt;
        }
    }
}
