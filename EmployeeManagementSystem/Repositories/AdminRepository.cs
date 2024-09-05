using Dapper;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repositories
{
    public class AdminRepository
    {
        public bool Login(Admin admin)
        {
            using (var connection = DatabaseConnectionFactory.CreateSqlConnection())
            {
                var dbAdmin = connection.QueryFirstOrDefault<Admin>("SELECT * FROM Admins WHERE AdminName = @AdminName AND AdminPassword = @AdminPassword", admin);
                return dbAdmin != null; 

            }
        }
    }
}
