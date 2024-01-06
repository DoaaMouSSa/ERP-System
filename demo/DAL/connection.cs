using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace demo.DAL
{
    public class connection
    {
        SqlConnection connect;
        SqlCommand cmd = new SqlCommand();
        //constructor to initalize connection string to DB
        public connection()
        {
            string mode = "isWindows";
            if(mode== "isWindows") connect = new SqlConnection(@"Server=DESKTOP-GSNAP69\SQLEXPRESS;database=acc_dt;Integrated Security=true;");
            else connect = new SqlConnection(@"Server=DESKTOP-GSNAP69\SQLEXPRESS;database=acc_db;integrated_security=false;user id=;password=");

        }
        //method to open connection
        public void openConnection()
        {
            if (connect.State != ConnectionState.Open) connect.Open();
        }
        //method to close connection
        public void closeConnection()
        {
            if (connect.State == ConnectionState.Open) connect.Close();
        }
        //method to execute stored procedure {cud operations}
        //sp => name of stored procedure
        //data=>array of parameters
        public void ExecuteCmd(string sp,SqlParameter[] data)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = connect;
            if(data != null)
            {
                cmd.Parameters.AddRange(data);
            }
            cmd.ExecuteNonQuery();
        }
        //method to execute stored procedure {read data only}
        public DataTable selectData(string sp, SqlParameter[] data) 
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = connect;
            if(data!=null)
            {
                for(int i=0;i<data.Length;i++)
                {
                    cmd.Parameters.Add(data[i]);
                }
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            return dt;  
        }
        public string selectStringValue(string sp, SqlParameter data)
        {
    
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = connect;
            //cmd.Parameters.AddWithValue("@acc_no",1);

             cmd.Parameters.Add(data);
            //var returnParameter= cmd.Parameters.Add(data);
            // @ReturnVal could be any name
            //var returnParameter  = cmd.Parameters.Add("@str", SqlDbType.NVarChar,100);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter retval = new SqlParameter("@str", SqlDbType.NVarChar, 100);
            //cmd.Parameters.Add(retval);
            //retval.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("@str", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;

            //SqlParameter result = cmd.Parameters.Add(new SqlParameter("@str", SqlDbType.NVarChar, 100));
            //result.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            string result = cmd.Parameters["@str"].Value.ToString();

            return result;
        }
    }
}
