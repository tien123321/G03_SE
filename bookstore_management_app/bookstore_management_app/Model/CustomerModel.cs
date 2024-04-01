using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Windows.Forms;
using bookstore_management_app.Entity;

namespace bookstore_management_app.Model
{
    public class CustomerModel
    {
        private static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["BanhangnhasachTienPhong"].ToString();
        private Customer _customer;
        public List<Customer> _customers;

        public CustomerModel()
        {
            this._customers = new List<Customer>();
        }
        
        public List<Customer> findAll()
        {
            this._customers = new List<Customer>();
            //Declare the SqlDataReader
            SqlDataReader rdr = null;

            //Create connection
            SqlConnection conn = new SqlConnection(constr);

            //Create command
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblKhachhang", conn);

            try
            {
                //Open the connection
                conn.Open();

                // 1. get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    // get the results of each column
                    int id = (int)rdr["PK_iKhachhang"];
                    string fullname = (string)rdr["sTenkhachhang"];
                    string address = (string)rdr["sDiachi"];
                    string phone = (string)rdr["sSDTKH"];
                    _customers.Add(new Customer(id, fullname, address,phone));
                }
            }
            finally
            {
                // 3. close the reader
                if(rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if(conn != null)
                {
                    conn.Close();
                }
            }

            return this._customers;
        }

        public List<Customer> find(Customer filterCustomer)
        {
            this._customers = new List<Customer>();
            //Declare the SqlDataReader
            SqlDataReader rdr = null;

            //Create connection
            SqlConnection conn = new SqlConnection(constr);
            Console.Write(filterCustomer.filter());
            //Create command
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblKhachhang"+filterCustomer.filter(), conn);
            
            try
            {
                //Open the connection
                conn.Open();

                // 1. get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    // get the results of each column
                    int id = (int)rdr["PK_iKhachhang"];
                    string fullname = (string)rdr["sTenkhachhang"];
                    string address = (string)rdr["sDiachi"];
                    string phone = (string)rdr["sSDTKH"];
                    _customers.Add(new Customer(id, fullname, address,phone));
                }
            }
            finally
            {
                // 3. close the reader
                if(rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if(conn != null)
                {
                    conn.Close();
                }
            }

            return this._customers;
        }

        public Customer create(Customer customer)
        {
            this._customers = new List<Customer>();
            Customer createdCustomer;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO tblKhachhang (sTenKhachhang, sDiachi, sSDTKH) VALUES (@fullname, @address, @phone)";
                    cmd.Parameters.AddWithValue("@fullname", customer.Fullname);
                    cmd.Parameters.AddWithValue("@address", customer.Address);
                    cmd.Parameters.AddWithValue("@phone", customer.Phone);
                    cmd.ExecuteNonQuery();
                    createdCustomer = new Customer(999, "", "", "");
               
                }
                cnn.Close();
            }

            return createdCustomer;
        }

        public Customer update(Customer customer)
        {
            Customer createdCustomer;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE tblKhachhang 
                    SET sTenKhachhang = @fullname, sDiachi = @address Where sSDTKH = @phone";
                    cmd.Parameters.AddWithValue("@fullname", customer.Fullname);
                    cmd.Parameters.AddWithValue("@address", customer.Address);
                    cmd.Parameters.AddWithValue("@phone", customer.Phone);
                    cmd.ExecuteNonQuery();
                    createdCustomer = new Customer(999, "", "", "");
               
                }
                cnn.Close();
            }

            return createdCustomer;
        }

        public Customer delete(Customer customer)
        {
            Customer createdCustomer;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE tblKhachhang Where sSDTKH = @phone";
                    cmd.Parameters.AddWithValue("@phone", customer.Phone);
                    cmd.ExecuteNonQuery();
                    createdCustomer = new Customer(999, "", "", "");
               
                }
                cnn.Close();
            }
            return createdCustomer;
        }
        
        public bool exist(Customer customer)
        {
            int totalRecord = 0;
            //Declare the SqlDataReader
            SqlDataReader rdr = null;

            //Create connection
            SqlConnection conn = new SqlConnection(constr);

            //Create command
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblKhachhang WHERE sSDTKH = " + customer.Phone, conn);

            try
            {
                //Open the connection
                conn.Open();

                // 1. get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    // get the results of each column
                    int id = (int)rdr["PK_iKhachhang"];
                    string fullname = (string)rdr["sTenkhachhang"];
                    string address = (string)rdr["sDiachi"];
                    string phone = (string)rdr["sSDTKH"];
                    totalRecord++;
                }
            }
            finally
            {
                // 3. close the reader
                if(rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if(conn != null)
                {
                    conn.Close();
                }
            }

            if (totalRecord > 0)
            {
                return true;
            }
            return false;
        }
    }
}