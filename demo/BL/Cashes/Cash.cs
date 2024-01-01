using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.DAL;
using System.Data.SqlClient;
using System.Data;
namespace demo.BL.Cashes
{
    public class Cash
    {
        public DataTable getAll()
        {

            connection connect = new connection();
            connect.openConnection();
            DataTable dt = new DataTable();
            dt = connect.selectData("cash_select_all", null);
            connect.closeConnection();
            return dt;
        }
    }
}
