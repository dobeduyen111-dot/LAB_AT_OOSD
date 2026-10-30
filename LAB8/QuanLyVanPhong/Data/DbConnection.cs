using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyVanPhong.Data
{
    public static class DbConnection
    {
        private static string ConnectionString
        {
            get
            {
                var setting = ConfigurationManager.ConnectionStrings["QuanLyVanPhongDb"];
                if (setting == null) throw new ConfigurationErrorsException("Thiếu connectionStrings/QuanLyVanPhongDb trong App.config.");
                return setting.ConnectionString;
            }
        }
        public static SqlConnection OpenConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }
        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }
        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }
        public static object StoredProcedureScalar(string procedure, params SqlParameter[] parameters)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(procedure, cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60;
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }
        public static int StoredProcedure(string procedure, params SqlParameter[] parameters)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(procedure, cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60;
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }
        public static SqlParameter P(string name, object value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }
    }
}
