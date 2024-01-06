using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
