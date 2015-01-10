using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Employee
    {
        private string Id { set; get; }
        private string EmployeeName { set; get; }
        private string Email { set; get; }
        public Salary EmployeeSalary { set; get; }

        public void EmployeeInformation(string id, string employeeName, string email)
        {
            this.Id = id;
            this.EmployeeName = employeeName;
            this.Email = email;
        }
    }
}
