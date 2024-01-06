using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.DAL;
using System.Data.SqlClient;
using System.Data;

namespace demo.BL.Accounts
{
    public class Account
    {
        public string getAccName(int acc_no)
        {
            connection connect = new connection();
            connect.openConnection();
            SqlParameter param = new SqlParameter();
            param = new SqlParameter("@acc_no", SqlDbType.Int);
            param.Value = acc_no;
            string accName = connect.selectStringValue("getAccountName", param);
            connect.closeConnection();
            return accName;
        }
    }
}
