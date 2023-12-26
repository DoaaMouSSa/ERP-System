using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using demo.DAL;
using System.Security.Cryptography;

namespace demo.PL.Users
{
    internal class Cls_Users
    {
        private readonly DAL.connection connection;

        public Cls_Users()
        {
            connection = new DAL.connection();
        }

        public DataTable GenerateUID()
        {
            connection.openConnection();
            DataTable dataTable = connection.selectData("generate_UID", null);
            connection.closeConnection();
            return dataTable;
        }

        public DataTable SelectAllUsers()
        {
            connection.openConnection();
            DataTable dataTable = connection.selectData("user_select_all", null);
            connection.closeConnection();
            return dataTable;
        }

        public void AddUser(int uID, string uFName, string userName, string uPassword, string uPhone, string uEmail, byte[] uImage)
        {
            connection.openConnection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@u_no", SqlDbType.Int) { Value = uID },
                new SqlParameter("@u_fname", SqlDbType.NVarChar, 60) { Value = uFName },
                new SqlParameter("@u_name", SqlDbType.NVarChar, 10) { Value = userName },
                new SqlParameter("@u_password", SqlDbType.NVarChar, 20) { Value = HashPassword(uPassword) },
                new SqlParameter("@u_tel", SqlDbType.NVarChar, 20) { Value = uPhone },
                new SqlParameter("@u_email", SqlDbType.NVarChar, 50) { Value = uEmail },
                new SqlParameter("@u_img", SqlDbType.Image) { Value = uImage }
            };

            connection.ExecuteCmd("user_add", parameters);
            connection.closeConnection();
        }
        public void EditUser(int uID, string uFName, string userName, string uPassword, string uPhone, string uEmail, byte[] uImage)
        {
            connection.openConnection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@u_no", SqlDbType.Int) { Value = uID },
                new SqlParameter("@u_fname", SqlDbType.NVarChar, 60) { Value = uFName },
                new SqlParameter("@u_name", SqlDbType.NVarChar, 10) { Value = userName },
                new SqlParameter("@u_password", SqlDbType.NVarChar, 20) { Value = HashPassword(uPassword) },
                new SqlParameter("@u_tel", SqlDbType.NVarChar, 20) { Value = uPhone },
                new SqlParameter("@u_email", SqlDbType.NVarChar, 50) { Value = uEmail },
                new SqlParameter("@u_img", SqlDbType.Image) { Value = uImage }
            };

            connection.ExecuteCmd("user_update", parameters);
            connection.closeConnection();
        }
        public void DeleteUser(int uID)
        {
            connection.openConnection();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@u_no", SqlDbType.Int) { Value = uID },

            };

            connection.ExecuteCmd("user_delete", parameters);
            connection.closeConnection();
        }

        
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hexHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hexHash.Substring(0, Math.Min(20, hexHash.Length));
            }
        }

        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] enteredHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                string hexEnteredHash = BitConverter.ToString(enteredHash).Replace("-", "").ToLower();

                return hexEnteredHash.Substring(0, Math.Min(20, hexEnteredHash.Length))
                    .Equals(storedHash, StringComparison.OrdinalIgnoreCase);
            }
        }

    }

}
