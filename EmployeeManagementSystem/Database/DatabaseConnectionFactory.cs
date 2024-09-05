using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Database
{
    public class DatabaseConnectionFactory
    {
        private static readonly string _connectionString = "Server=.\\SQLEXPRESS;" +
            "Database=EmployeeManagement;" +
            "User Id=sa;Password=admin;" +
            "TrustServerCertificate=True;";
        public static SqlConnection CreateSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
