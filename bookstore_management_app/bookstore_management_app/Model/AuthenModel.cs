using bookstore_management_app.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore_management_app.Model
{
    internal class AuthenModel
    {
        string connectionString;
        public AuthenModel() {
            this.connectionString = ConfigurationManager.ConnectionStrings["BanhangnhasachTienPhong"].ConnectionString;
        }

        public bool isCheckAccount(string username, string password)
        {

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prGetAccount", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Access the values returned by the stored procedure
                        string username_1, role;
                        int iMaNV, status;
                        Authorize.Instance.Status = Convert.ToInt16( reader.GetBoolean(2) );
                        status = Authorize.Instance.Status;
                        if (status == (int )ACCOUNT_STATUS.ACTIVATE)
                        {
                            username_1 = reader.GetString(0);
                            role = reader.GetString(1);
                            iMaNV = reader.GetInt32(3);
                            Authorize.Instance.saveSession(username_1, role, Authorize.Instance.Status, iMaNV);
                            return true;
                        }
                    }
                    reader.Close();
                    return false;
                }
                
            }
        }

        public bool changePassword(string username, string oldPassword, string newPassword)
        {

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("prChangePassword", cnn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@oldPassword", oldPassword);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);

                    cnn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? true: false;
                }

            }
        }
    }
}
