using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Salary
    {
        public string EmployeeID { get; set; } 
        public float BasicSalary { set; get; }
        public float MedicalAllowance { get; set; }
        public float Conveyance { set; get; }
        public int Count { set; get; }

        public double GetTotal()
        {
            return (BasicSalary + GetMedicalAllowance() + GetConveyance());
           
        }

        public void SalaryIncreament(int increament)
        {
            BasicSalary += ((BasicSalary*increament)/100);
            Count++;
        }

        public float GetMedicalAllowance()
        {
            return ((BasicSalary * MedicalAllowance) / 100);
        }
        public float GetConveyance()
        {
            return ((BasicSalary * Conveyance) / 100);
        }

    }
}
