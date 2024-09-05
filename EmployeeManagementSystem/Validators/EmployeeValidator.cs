using Dapper;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Entities;
using EmployeeManagementSystem.Validators.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Validators
{
    public static class EmployeeValidator
    {
        public static ValidationMessage EmployeeExist(Employee employee)
        {
            string message = "";
            if (employee.EmployeeId <= 0) // ID geçerli değilse (0 veya negatifse)
            {
                message += "Invalid employee ID. ";
            }
            if (string.IsNullOrEmpty(employee.EmployeeName))
            {
                message += "Does not exist this name";
            }
            if (string.IsNullOrEmpty(message))
            {
                return new ValidationMessage { IsValid = true };
            }
            return new ValidationMessage { IsValid = false, Message = message };

        }
    }
}
