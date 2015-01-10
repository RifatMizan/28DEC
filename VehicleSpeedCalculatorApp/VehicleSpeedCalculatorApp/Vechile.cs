using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSpeedCalculatorApp
{
    class Vechile
    {
        private string vechileName;
        private string vechileRegNo;
        private int vechileSpeed;
        public int maxSpeed = 0;
        public int minSpeed = 0;
        public string VechileRegNo
        {
            set { vechileRegNo = value; }
        }

        public string VechileName
        {
            get { return vechileName; }
            set { vechileName = value; }
        }

        public int VechileSpeed
        {
            get { return vechileSpeed; }
            set { vechileSpeed = value; }
        }

        public int speedCalculator(int vechileSpeed)
        {
            VechileSpeed = vechileSpeed;
            return vechileSpeed;
        }
        int temp = 0;
        public int MinSpeedCalculator()
        {
            maxSpeed = VechileSpeed;
            
            int returnMinSpeed = 0;
            if (temp == 0)
            {

                returnMinSpeed = maxSpeed;
                temp = maxSpeed;
            }
            else
            {

                if (temp > maxSpeed)
                {
                    returnMinSpeed = maxSpeed;
                }
                else
                {
                    returnMinSpeed = temp;
                }
               
                
            }
            return returnMinSpeed;
        }
        public int MaxSpeedCalculator()
        {
            maxSpeed = VechileSpeed;
           
            int b = 0;
            if (temp == 0)
            {

                b = maxSpeed;
                temp = maxSpeed;
            }
            else
            {

                if (temp < maxSpeed)
                {
                    b = maxSpeed;
                }
                else
                {
                    b = temp;
                }
                temp = VechileSpeed;

            }
            return b;
        }

        public float AverageCalculator(int maxSpeed, int minSpeed)
        {
            float avg = (maxSpeed+minSpeed)/2;
            return avg;
        }
    }
}
