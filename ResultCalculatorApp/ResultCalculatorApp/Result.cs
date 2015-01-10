using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultCalculatorApp
{
    class Result
    {
        private float markOfPhysics { set; get; }
        private float markOfChemistry { set; get; }
        private float markOfMath { set; get; }

       

        public float GetAverage(float markOfPhysics, float markOfChemistry, float markOfMath)
        {
            this.markOfPhysics = markOfPhysics;
            this.markOfChemistry = markOfChemistry;
            this.markOfMath = markOfMath;
            float totalAverage = (markOfChemistry + markOfPhysics + markOfMath) / 3;
            return totalAverage;
        }

        public string CalculateGrade(float Total)
        {
            string grade = "f";
            if (Total >= 80 && Total<=100)
            {
                grade = "A+";
            }
            else if (Total >= 70 && Total<80)
            {
                grade = "B+";
            }
            else if(Total>=60 && Total<70)
            {
                grade = "C+";
            }
            else if (Total >= 50 && Total < 60)
            {
                grade = "D+";
            }
            else
            {
                grade = "F+";
            }
            return grade;
        }
    }
}
