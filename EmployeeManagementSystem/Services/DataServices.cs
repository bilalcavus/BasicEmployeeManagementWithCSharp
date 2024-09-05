using Dapper;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Services
{
    public static class DataServices
    {
        public static List<Employee> GetAll()
        {
            using (var connection = DatabaseConnectionFactory.CreateSqlConnection())
            {
                return  connection.Query<Employee>("SELECT * FROM Employees ").ToList(); 
            }
        }
    }
}
