using Dapper;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Entities;
using System;

namespace EmployeeManagementSystem.Repositories
{
    public class EmployeeRepository
    {
        public int InsertEmployee(Employee employee)
        {
            using (var connection = DatabaseConnectionFactory.CreateSqlConnection())
            {
                // Bu sorgu, çalışanı ekler ve son eklenen kaydın kimlik ID'sini döndürür.
                return connection.ExecuteScalar<int>(
                    "INSERT INTO Employees (EmployeeName, EmployeeDepartment, EmployeePhone) " +
                    "VALUES (@EmployeeName, @EmployeeDepartment, @EmployeePhone); " +
                    "SELECT CAST(SCOPE_IDENTITY() as int);",
                    employee
                );

            }
        }

        public int UpdateEmployee(int id, string name, string department, string phone)
        {
            using (var connection = DatabaseConnectionFactory.CreateSqlConnection())
            {
                var dbEmployeeUpdate = connection.Execute(
                    "UPDATE Employees SET " +
                    "EmployeeName = @EmployeeName, " +
                    "EmployeeDepartment = @EmployeeDepartment, " +
                    "EmployeePhone = @EmployeePhone " +
                    "WHERE EmployeeId = @EmployeeId",
                    new { EmployeeId = id, EmployeeName = name, EmployeeDepartment = department, EmployeePhone = phone }
                );
                return dbEmployeeUpdate;
            }
        }
        public int DeleteEmployee(int id)
        {
            using (var connection = DatabaseConnectionFactory.CreateSqlConnection())
            {
                var dbEmployeeDelete = connection.Execute(
                    "DELETE FROM Employees WHERE EmployeeId = @EmployeeId",
                 new {EmployeeId = id }
                );
                return dbEmployeeDelete;
            }
        }


    }
}
