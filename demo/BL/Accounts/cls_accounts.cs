using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Xml.Linq;
using demo.DAL;

namespace demo.BL.Account
{
    internal class cls_accounts
    {
        DataTable dt;
        public DataTable get_all_finalAcc()
        {
            DAL.connection connection = new DAL.connection();
            connection.openConnection();
            dt = new DataTable();
            dt = connection.selectData("get_all_account_reports", null);
            connection.closeConnection();
            return dt;
        }
        public DataTable get_all_AccType()
        {
            DAL.connection connection = new DAL.connection();
            connection.openConnection();
            dt = new DataTable();
            dt = connection.selectData("get_all_account_types", null);
            connection.closeConnection();
            return dt;
        }
        public DataTable get_all_Accounts()
        {
            DAL.connection connection = new DAL.connection();
            connection.openConnection();
            dt = new DataTable();
            dt = connection.selectData("account_select_all", null);
            connection.closeConnection();
            return dt;
        }
        
        public DataTable get_Account(int acc_no)
        {
            DAL.connection connection = new DAL.connection();
            connection.openConnection();
            dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0]=new SqlParameter("@acc_no",SqlDbType.Int);
            parameters[0].Value = acc_no;
            dt = connection.selectData("account_select", parameters);
            connection.closeConnection();
            return dt;
        }

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
