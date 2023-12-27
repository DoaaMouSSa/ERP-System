using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.DAL;
using System.Data.SqlClient;
using System.Data;

namespace demo.BL.company
{
    public class Company
    {
        public void Add(string aname, string ename, string apos, string epos, string phone, string fax, string email, string website, byte[] img)
        {
            //connection connect = new connection();
            //connect.openConnection();
            //SqlParameter[] param = new SqlParameter[9];
            //param[0] = new SqlParameter("@c_aname", SqlDbType.NVarChar, 200);
            //param[0].Value = aname;
            //param[1] = new SqlParameter("@c_ename", SqlDbType.NVarChar, 200);
            //param[1].Value = ename;
            //param[2] = new SqlParameter("@c_aposition", SqlDbType.NVarChar, 200);
            //param[2].Value = apos;
            //param[3] = new SqlParameter("@c_eposition", SqlDbType.NVarChar, 20);
            //param[3].Value = epos;
            //param[4] = new SqlParameter("@c_tel", SqlDbType.NVarChar, 20);
            //param[4].Value = phone;
            //param[5] = new SqlParameter("@c_fax", SqlDbType.NVarChar, 20);
            //param[5].Value = fax;
            //param[6] = new SqlParameter("@c_email", SqlDbType.NVarChar, 50);
            //param[6].Value = email;
            //param[7] = new SqlParameter("@c_website", SqlDbType.NVarChar, 50);
            //param[7].Value = website;
            //param[8] = new SqlParameter("@c_logo", SqlDbType.Image);
            //param[8].Value = img;
            //connect.ExecuteCmd("company_add", param);
            //connect.closeConnection();
        }
        public void update(int c_no,string aname, string ename, string apos, string epos, string phone, string fax, string email, string website, byte[] img)
        {
            //connection connect = new connection();
            //connect.openConnection();
            //SqlParameter[] param = new SqlParameter[10];
            //param[0] = new SqlParameter("@c_no", SqlDbType.Int);
            //param[0].Value = c_no;
            //param[1] = new SqlParameter("@c_aname", SqlDbType.NVarChar, 200);
            //param[1].Value = aname;
            //param[2] = new SqlParameter("@c_ename", SqlDbType.NVarChar, 200);
            //param[2].Value = ename;
            //param[3] = new SqlParameter("@c_aposition", SqlDbType.NVarChar, 200);
            //param[3].Value = apos;
            //param[4] = new SqlParameter("@c_eposition", SqlDbType.NVarChar, 20);
            //param[4].Value = epos;
            //param[5] = new SqlParameter("@c_tel", SqlDbType.NVarChar, 20);
            //param[5].Value = phone;
            //param[6] = new SqlParameter("@c_fax", SqlDbType.NVarChar, 20);
            //param[6].Value = fax;
            //param[7] = new SqlParameter("@c_email", SqlDbType.NVarChar, 50);
            //param[7].Value = email;
            //param[8] = new SqlParameter("@c_website", SqlDbType.NVarChar, 50);
            //param[8].Value = website;
            //param[9] = new SqlParameter("@c_logo", SqlDbType.Image);
            //param[9].Value = img;
            //connect.ExecuteCmd("company_update", param);
            //connect.closeConnection();
        }
        public DataTable getAll()
        {

            //connection connect = new connection();
            //connect.openConnection();
            DataTable dt = new DataTable();
            //dt= connect.selectData("company_select",null);
            //connect.closeConnection();
            return dt;
        }
        public void Delete(int compNo)
        {
            //connection connect = new connection();
            //connect.openConnection();
            //SqlParameter[] param = new SqlParameter[1];
            //param[0] = new SqlParameter("@c_no", SqlDbType.Int);
            //param[0].Value = compNo;
            //connect.ExecuteCmd("company_soft_delete", param);
            //connect.closeConnection();
        }
    }
}
