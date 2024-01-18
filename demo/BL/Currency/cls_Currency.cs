using demo.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo.BL.Currency
{
    internal class cls_Currency
    {
        DAL.connection connection ;
        DataTable dt;
        public void Add_currency(string curr_aname,string curr_ename,string curr_symbol,int curr_type,double curr_exchng,string curr_decent)
        {
            connection = new DAL.connection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@curr_aname", SqlDbType.NVarChar, 20) { Value = curr_aname },
                new SqlParameter("@curr_ename", SqlDbType.NVarChar, 20) { Value = curr_ename },
                new SqlParameter("@curr_symbol", SqlDbType.NVarChar, 20) { Value = curr_symbol },
                new SqlParameter("@curr_type", SqlDbType.Int) { Value = curr_type },
                new SqlParameter("@curr_exchng", SqlDbType.Money) { Value = curr_exchng },
                new SqlParameter("@curr_decent", SqlDbType.NVarChar, 10) { Value = curr_decent }
            };
            
            connection.openConnection();
            connection.ExecuteCmd("currency_add", parameters);
            connection.closeConnection();
        }

        public DataTable currency_select_one(int curr_no)
        {
            connection = new connection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@curr_no", SqlDbType.Int) { Value = curr_no }
            };
            connection.openConnection();
            DataTable dt = new DataTable();
            dt = connection.selectData("currency_select_one", parameters);
            connection.closeConnection();
            return dt;
        }

        
        public void currency_update(int curr_no , string curr_aname, string curr_ename, string curr_symbol, int curr_type, double curr_exchng, string curr_decent)
        {
            connection = new DAL.connection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@curr_no", SqlDbType.Int) { Value = curr_no },
                new SqlParameter("@curr_aname", SqlDbType.NVarChar, 20) { Value = curr_aname },
                new SqlParameter("@curr_ename", SqlDbType.NVarChar, 20) { Value = curr_ename },
                new SqlParameter("@curr_symbol", SqlDbType.NVarChar, 20) { Value = curr_symbol },
                new SqlParameter("@curr_type", SqlDbType.Int) { Value = curr_type },
                new SqlParameter("@curr_exchng", SqlDbType.Money) { Value = curr_exchng },
                new SqlParameter("@curr_decent", SqlDbType.NVarChar, 10) { Value = curr_decent }
            };

            connection.openConnection();
            connection.ExecuteCmd("currency_update", parameters);
            connection.closeConnection();
        }
       
        public void currency_delete(int curr_no)
        {
            connection = new DAL.connection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@curr_no", SqlDbType.Int) { Value = curr_no }
            };
            connection.openConnection();
            connection.ExecuteCmd("currency_delete", parameters);
            connection.closeConnection();
        }
    

    public DataTable get_all_currency()
        {
            connection = new DAL.connection();
            dt = new DataTable();
            connection.openConnection();
            dt = connection.selectData("currency_select_all", null);
            connection.closeConnection();
            return dt;
        }
    }
}
