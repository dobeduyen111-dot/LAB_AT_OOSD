using eSHOPPING.Data;
using eSHOPPING.Models;
using System;
using System.Data.SqlClient;
namespace eSHOPPING.Repositories
{
    public class CustomerRepository
    {
        public bool CheckUsername(string username)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string sql =
                    "SELECT COUNT(*) FROM Customer WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool Create(Customer customer)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Customer
                    (
                        FullName,
                        DateOfBirth,
                        IdPassport,
                        Address,
                        Phone,
                        Username,
                        PasswordHash,
                        Email
                    )
                    VALUES
                    (
                        @FullName,
                        @DateOfBirth,
                        @IdPassport,
                        @Address,
                        @Phone,
                        @Username,
                        @PasswordHash,
                        @Email
                    )";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName",
                        customer.FullName);
                    cmd.Parameters.AddWithValue("@DateOfBirth",
                        customer.DateOfBirth);
                    cmd.Parameters.AddWithValue("@IdPassport",
                        customer.IdPassport);
                    cmd.Parameters.AddWithValue("@Address",
                        customer.Address);
                    cmd.Parameters.AddWithValue("@Phone",
                        customer.Phone);
                    cmd.Parameters.AddWithValue("@Username",
                        customer.Username);
                    cmd.Parameters.AddWithValue("@PasswordHash",
                        customer.PasswordHash);
                    cmd.Parameters.AddWithValue("@Email",
                        string.IsNullOrWhiteSpace(customer.Email)
                            ? (object)DBNull.Value
                            : customer.Email);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}