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
using System.Security.AccessControl;

namespace demo.BL.Account
{
    internal class cls_accounts
    {
        DataTable dt;
        public DataTable get_all_finalAcc()
        {
            DAL.connection connection = new DAL.connection();
            dt = new DataTable();
            connection.openConnection();
            dt = connection.selectData("get_all_account_reports", null);
            connection.closeConnection();
            return dt;
        }
        public DataTable get_all_AccType()
        {
            DAL.connection connection = new DAL.connection();
            dt = new DataTable();
            connection.openConnection();
            dt = connection.selectData("get_all_account_types", null);
            connection.closeConnection();
            return dt;
        }
        public DataTable get_all_Accounts()
        {
            DAL.connection connection = new DAL.connection();
            dt = new DataTable();
            dt = connection.selectData("account_select_all", null);
            connection.openConnection();
            connection.closeConnection();
            return dt;
        }

        public DataTable get_Account(int acc_no)
        {
            DAL.connection connection = new DAL.connection();
            dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@acc_no", SqlDbType.Int);
            parameters[0].Value = acc_no;
            connection.openConnection();
            dt = connection.selectData("account_select", parameters);
            connection.closeConnection();
            return dt;
        }

        public void Add_Account(int acc_no, int acc_parent_no, string acc_name, int acc_type, int acc_report, int acc_level, double acc_debit, double acc_credit, double acc_balance)
        {
            DAL.connection connection = new DAL.connection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@acc_no", SqlDbType.Int) { Value = acc_no },
                new SqlParameter("@acc_parent_no", SqlDbType.Int) { Value = acc_parent_no },
                new SqlParameter("@acc_name", SqlDbType.NVarChar, 60) { Value = acc_name },
                new SqlParameter("@acc_type", SqlDbType.Int) { Value = acc_type },
                new SqlParameter("@acc_report", SqlDbType.Int) { Value = acc_report },
                new SqlParameter("@acc_level", SqlDbType.Int) { Value = acc_level },
                new SqlParameter("@acc_debit", SqlDbType.Money) { Value = acc_debit },
                new SqlParameter("@acc_credit", SqlDbType.Money) { Value = acc_credit },
                new SqlParameter("@acc_balance", SqlDbType.Money) { Value = acc_balance },
            };
            connection.openConnection();
            connection.ExecuteCmd("account_add", parameters);
            connection.closeConnection();
        }

        public void Edit_Account(int acc_no, int acc_parent_no, string acc_name, int acc_type, int acc_report, int acc_level, double acc_debit, double acc_credit, double acc_balance)
        {
            DAL.connection connection = new DAL.connection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@acc_no", SqlDbType.Int) { Value = acc_no },
                new SqlParameter("@acc_parent_no", SqlDbType.Int) { Value = acc_parent_no },
                new SqlParameter("@acc_name", SqlDbType.NVarChar, 60) { Value = acc_name },
                new SqlParameter("@acc_type", SqlDbType.Int) { Value = acc_type },
                new SqlParameter("@acc_report", SqlDbType.Int) { Value = acc_report },
                new SqlParameter("@acc_level", SqlDbType.Int) { Value = acc_level },
                new SqlParameter("@acc_debit", SqlDbType.Money) { Value = acc_debit },
                new SqlParameter("@acc_credit", SqlDbType.Money) { Value = acc_credit },
                new SqlParameter("@acc_balance", SqlDbType.Money) { Value = acc_balance },
            };
            connection.openConnection();
            connection.ExecuteCmd("account_update", parameters);
            connection.closeConnection();
        }

        public void Delete_Account(int acc_no)
        {
            DAL.connection connection = new DAL.connection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@acc_no", SqlDbType.Int) { Value = acc_no },

            };
            connection.openConnection();
            connection.ExecuteCmd("account_delete", parameters);
            connection.closeConnection();
        }
        public DataTable Account_Check(int acc_no)
        {
            DAL.connection connection = new DAL.connection();
            dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@acc_no", SqlDbType.Int);
            parameters[0].Value = acc_no;
            connection.openConnection();
            dt = connection.selectData("check_account", parameters);
            connection.closeConnection();
            return dt;
        }
        public DataTable journal_Check(int acc_no)
        {
            DAL.connection connection = new DAL.connection();
            dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@acc_no", SqlDbType.Int);
            parameters[0].Value = acc_no;
            connection.openConnection();
            dt = connection.selectData("check_journal", parameters);
            connection.closeConnection();
            return dt;
        }

    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;

//using System.Threading.Tasks;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Data.SqlClient;
//using System.Security.Cryptography;
//using System.Xml.Linq;

//namespace demo.BL.Account
//{
//    internal class cls_accounts
//    {
//        DataTable dt;
//        public DataTable get_all_finalAcc()
//        {
//            DAL.connection connection = new DAL.connection();
//            connection.openConnection();
//            dt = new DataTable();
//            dt = connection.selectData("get_all_account_reports", null);
//            connection.closeConnection();
//            return dt;
//        }
//        public DataTable get_all_AccType()
//        {
//            DAL.connection connection = new DAL.connection();
//            connection.openConnection();
//            dt = new DataTable();
//            dt = connection.selectData("get_all_account_types", null);
//            connection.closeConnection();
//            return dt;
//        }
//        public DataTable get_all_Accounts()
//        {
//            DAL.connection connection = new DAL.connection();
//            connection.openConnection();
//            dt = new DataTable();
//            dt = connection.selectData("account_select_all", null);
//            connection.closeConnection();
//            return dt;
//        }

//        public DataTable get_Account(int acc_no)
//        {
//            DAL.connection connection = new DAL.connection();
//            connection.openConnection();
//            dt = new DataTable();
//            SqlParameter[] parameters = new SqlParameter[1];
//            parameters[0]=new SqlParameter("@acc_no",SqlDbType.Int);
//            parameters[0].Value = acc_no;
//            dt = connection.selectData("account_select", parameters);
//            connection.closeConnection();
//            return dt;
//        }
//    }
//}
