using EmployeeManagementSystem.Entities;
using EmployeeManagementSystem.Repositories;
using EmployeeManagementSystem.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class LoginForm : Form
    {
        MessageBoxes messageBox = new MessageBoxes(); 
        private Admin admin;
        private AdminRepository adminRepository;
        public LoginForm()
        {
            admin = new Admin();
            adminRepository = new AdminRepository();
            InitializeComponent();
            //Data binding
            txtAdminName.DataBindings.Add("Text", admin, nameof(admin.AdminName));
            txtPassword.DataBindings.Add("Text", admin, nameof(admin.AdminPassword));
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            var validationResult = AdminValidator.LoginValidator(admin);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.Message);
                return;
            }
            if (adminRepository.Login(admin))
            {
                Form1 form1 = new Form1();
                form1.FormClosed += Form1_FormClosed;
                Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show(messageBox.gecersizAdminVePassword);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
