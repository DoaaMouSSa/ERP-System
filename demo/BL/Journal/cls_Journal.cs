using demo.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace demo.BL.Journal
{
    internal class cls_Journal
    {
        private readonly DAL.connection connection;
        public cls_Journal()
        {
            connection = new DAL.connection();
        }
        public DataTable Generate_JNo()
        {
            connection.openConnection();
            DataTable dataTable = connection.selectData("generate_JNo", null);
            connection.closeConnection();
            return dataTable;
        }

        public void Journal_hdr_add(int j_no, DateTime j_date, string j_note, int j_type,int j_post,double t_debit,double t_credit,double t_balance, int u_add, DateTime add_date , int curr_no)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@j_no", SqlDbType.Int) { Value = j_no },
                new SqlParameter("@j_date", SqlDbType.DateTime) { Value = j_date },
                new SqlParameter("@j_note", SqlDbType.NVarChar, 100) { Value = j_note },
                new SqlParameter("@j_type", SqlDbType.Int) { Value = j_type },
                new SqlParameter("@j_post", SqlDbType.Int) { Value = j_post }, 
                new SqlParameter("@t_debit", SqlDbType.Money) { Value = t_debit }, 
                new SqlParameter("@t_credit", SqlDbType.Money) { Value = t_credit }, 
                new SqlParameter("@t_balance", SqlDbType.Money) { Value = t_balance }, 
                new SqlParameter("@u_add", SqlDbType.Int) { Value = u_add }, 
                new SqlParameter("@add_date", SqlDbType.DateTime) { Value = add_date }, 
                new SqlParameter("@curr_no", SqlDbType.Int) { Value = curr_no } 
            };
            connection.openConnection();
            connection.ExecuteCmd("journal_hdr_add", parameters);
            connection.closeConnection();
        }
        
        public void Journal_details_add(int acc_no, double acc_debit, double acc_credit, int acc_currency, string acc_not, int j_no_hdr_id)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@acc_no", SqlDbType.Int) { Value = acc_no },
                new SqlParameter("@acc_debit", SqlDbType.Money) { Value = acc_debit },
                new SqlParameter("@acc_credit", SqlDbType.Money) { Value = acc_credit },
                new SqlParameter("@acc_currency", SqlDbType.Int) { Value = acc_currency },
                new SqlParameter("@acc_not", SqlDbType.NVarChar, 100) { Value = acc_not },
                new SqlParameter("@j_no_hdr_id", SqlDbType.Int) { Value = j_no_hdr_id }
            };


            connection.openConnection();
            connection.ExecuteCmd("journal_details_add", parameters);
            connection.closeConnection();
        }

    }
}
