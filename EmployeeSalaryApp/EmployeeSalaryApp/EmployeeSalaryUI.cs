using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        Employee aEmployee = new Employee();

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            string id = employeeIdTextBox.Text;
            string employeeName = NameTextBox.Text;
            string email = emailTextBox.Text;
            aSalary.BasicSalary = Convert.ToInt32(basicEntryTextBox.Text);
            aSalary.Conveyance = Convert.ToInt32(conveyanceTextBox.Text);
            aSalary.MedicalAllowance = Convert.ToInt32(medicalTextBox.Text);
            aEmployee.EmployeeInformation(id, employeeName, email);
            aEmployee.EmployeeSalary = aSalary;
        }

        private void show_Button_Click(object sender, EventArgs e)
        {
            basicDisplayTextBox.Text = aEmployee.EmployeeSalary.BasicSalary.ToString();
            medicalDisplayTextBox.Text = aEmployee.EmployeeSalary.GetMedicalAllowance().ToString();
            conveyanceDisplayTextBox.Text = aEmployee.EmployeeSalary.GetConveyance().ToString();
            noOfIncreamentTextBox.Text = aEmployee.EmployeeSalary.Count.ToString();
            totalDispalyTextBox.Text = aEmployee.EmployeeSalary.GetTotal().ToString();
        }

        private void increament_button_Click(object sender, EventArgs e)
        {
            int increament = Convert.ToInt32(increaseBasicTextBox.Text);
            aEmployee.EmployeeSalary.SalaryIncreament(increament);

        }
    }
}
