using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Entities;
using EmployeeManagementSystem.Repositories;
using EmployeeManagementSystem.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        private EmployeeRepository employeeRepository = new EmployeeRepository();

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm createEmployeeForm = new CreateEmployeeForm();
            createEmployeeForm.FormClosed += CreateEmployeeForm_FormClosed;
            Hide();
            createEmployeeForm.Show();
        }
        private void CreateEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
            employeeDataView.DataSource = DataServices.GetAll();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedEmployee();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            updateEmployees();
        }

        private void updateEmployees()
        {
            MessageBoxes messageBox = new MessageBoxes();

            if (employeeDataView.SelectedRows.Count == 1)
            {
                bool updateSuccessful = true;

     
                DataGridViewRow selectedRow = employeeDataView.SelectedRows[0];

                int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value);
                string employeeName = selectedRow.Cells["EmployeeName"].Value.ToString();
                string employeeDepartment = selectedRow.Cells["EmployeeDepartment"].Value.ToString();
                string employeePhone = selectedRow.Cells["EmployeePhone"].Value.ToString();

              
                try
                {
                    employeeRepository.UpdateEmployee(employeeId, employeeName, employeeDepartment, employeePhone);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(messageBox.birHataOlustu + ex.Message);
                    updateSuccessful = false;
                }

                
                if (updateSuccessful)
                {
                    employeeDataView.DataSource = DataServices.GetAll();    
                    MessageBox.Show(messageBox.basariylaGuncellendi);
                }
            }
            else
            {
                MessageBox.Show(messageBox.satirSecilmedi);
            }
        }
        private void DeleteSelectedEmployee()
        {
            MessageBoxes messageBox = new MessageBoxes();
            if (employeeDataView.SelectedRows.Count > 0)
            {
                using (var connection = DatabaseConnectionFactory.CreateSqlConnection())
                {
                    bool deleteSuccessful = true;

                    foreach (DataGridViewRow selectedRow in employeeDataView.SelectedRows)
                    {
                        int employeeId = Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value);
                        try
                        {
                            employeeRepository.DeleteEmployee(employeeId);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(messageBox.calisanSilmeHata + ex.Message);
                            deleteSuccessful = false;
                        }
                    }
                    if (deleteSuccessful)
                    {
                        // Silme işleminden sonra DataGridView'i güncelleyin
                        employeeDataView.DataSource = DataServices.GetAll();
                        MessageBox.Show(messageBox.calisanSilindi);
                    }
                }
            }
            else
            {
                MessageBox.Show(messageBox.silinecekSatirSecilmedi);
            }
        }
    }
}
