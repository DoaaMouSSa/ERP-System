﻿using System;
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
            if(mode== "isWindows") connect = new SqlConnection(@"Server=DESKTOP-GSNAP69\SQLEXPRESS;database=acc_dt;Integrated Security=True;");
          //  else connect = new SqlConnection(@"Server=DESKTOP-GSNAP69\SQLEXPRESS;database=acc_db;integrated_security=false;user id=;password=");

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
        //method to execute query
    }
}
