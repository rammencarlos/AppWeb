using App.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess
{
    public class UserDA
    {
        public int CreateUser(UserDTO user)
        {
            SqlConnection sqlConn = null;
            SqlDataReader sqlDr = null;

            try
            {
                sqlConn = new SqlConnection("Server=(local); DataBase=NCapas;Integrated Security=SSPI");
                sqlConn.Open();

                SqlCommand sqlcmd = new SqlCommand("CreateUser", sqlConn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@NickName_param",SqlDbType.VarChar).Value = user.NickName;
                sqlcmd.Parameters.AddWithValue("@Email_param", SqlDbType.VarChar).Value = user.Email;
                sqlcmd.Parameters.AddWithValue("@Password_param", SqlDbType.VarChar).Value = user.Password;
                sqlcmd.Parameters.AddWithValue("@IsEnabled_param", SqlDbType.VarChar).Value = user.IsEnabled;
                sqlcmd.Parameters.AddWithValue("@CreatedDate_param", SqlDbType.VarChar).Value = user.CreatedDate;

                 sqlcmd.ExecuteNonQuery();

            }finally
            {
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                if (sqlDr != null)
                {
                    sqlDr.Close();
                }
            }

            return 0;
        }

    }
}
