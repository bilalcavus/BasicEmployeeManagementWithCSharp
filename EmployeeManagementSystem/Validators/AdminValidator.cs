using EmployeeManagementSystem.Entities;
using EmployeeManagementSystem.Validators.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Validators
{
    public static class AdminValidator
    {
        public static ValidationMessage LoginValidator(Admin admin)
        {
            string message = "";
            if (string.IsNullOrEmpty(admin.AdminName))
            {
                message += "Admin adı boş geçilemez!";
            }
            if (string.IsNullOrEmpty(admin.AdminPassword))
            {
                message += "Sifre bos gecilemez!";
            }

            if (string.IsNullOrEmpty(message))
            {
                return new ValidationMessage { IsValid = true };
            }
            return new ValidationMessage { IsValid = false, Message = message };
        }
    }
}
