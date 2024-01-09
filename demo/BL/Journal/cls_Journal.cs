using demo.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
