using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace demo.BL.Account
{
    internal class HelperFunction
    {
        public string getAccountName(int accNumber)
        {
            DAL.connection conn = new DAL.connection();
            conn.openConnection();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@u_name", SqlDbType.Int);
            param[0].Value = accNumber;
            DataTable dt = new DataTable();
            dt = conn.selectData("getAccountName", param);
            conn.closeConnection();
            string accountName = dt.ToString();
            return accountName;
        }
    }
}
