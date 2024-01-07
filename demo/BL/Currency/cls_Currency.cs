using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.BL.Currency
{
    internal class cls_Currency
    {

        DataTable dt;
        public DataTable get_all_currency()
        {
            DAL.connection connection = new DAL.connection();
            dt = new DataTable();
            connection.openConnection();
            dt = connection.selectData("currency_select_all", null);
            connection.closeConnection();
            return dt;
        }

        public DataTable get_currency_exchange(string curr_name)
        {
            DAL.connection connection = new DAL.connection();
            dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@curr_aname", SqlDbType.NVarChar,20);
            parameters[0].Value = curr_name;
            connection.openConnection();
            dt = connection.selectData("get_curr_exch", parameters);
            connection.closeConnection();
            return dt;
        }
    }
}
