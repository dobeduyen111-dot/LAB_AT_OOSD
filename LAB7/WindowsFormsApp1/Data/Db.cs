using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Data
{
    public static class Db
    {
        private static string ConnectionString
        {
            get
            {
                var item = ConfigurationManager.ConnectionStrings["QuanLyNhanSuDb"];
                return item == null ? "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QuanLyNhanSu;Integrated Security=True;TrustServerCertificate=True;" : item.ConnectionString;
            }
        }

        public static SqlConnection Open()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var cn = Open()) using (var cmd = new SqlCommand(sql, cn)) using (var ad = new SqlDataAdapter(cmd))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                var table = new DataTable();
                ad.Fill(table);
                return table;
            }
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var cn = Open()) using (var cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (var cn = Open()) using (var cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        public static SqlParameter P(string name, object value)
        { return new SqlParameter(name, value ?? System.DBNull.Value); }
    }
}
