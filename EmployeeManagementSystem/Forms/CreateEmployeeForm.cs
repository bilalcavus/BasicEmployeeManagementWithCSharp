using EmployeeManagementSystem.Entities;
using EmployeeManagementSystem.Repositories;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class CreateEmployeeForm : Form
    {
        private EmployeeRepository employeeRepository;

        public CreateEmployeeForm()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository(); 
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            InsertNewEmployee();
        }

        private void InsertNewEmployee()
        {
            MessageBoxes messageBox = new MessageBoxes();
            var employee = new Employee
            {
                EmployeeName = txtEName.Text,
                EmployeeDepartment = txtEDep.Text,
                EmployeePhone = txtEPhone.Text
            };

            try
            {
                int result = employeeRepository.InsertEmployee(employee);

                if (result > 0)
                {
                    MessageBox.Show(messageBox.calisanEklendiMessage, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(messageBox.calisanEklemeHata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(messageBox.calisanEklemeHata + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void btnExit_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.FormClosed += Form1_FormClosed;
            Hide();
            form1.Show();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
