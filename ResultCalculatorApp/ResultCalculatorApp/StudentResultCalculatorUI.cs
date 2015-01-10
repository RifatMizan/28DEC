using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCalculatorApp
{
    public partial class StudentResultCalculatorUI : Form
    {
        public StudentResultCalculatorUI()
        {
            InitializeComponent();
        }
         Result anResult = new Result();
        private void Show_Button_Click(object sender, EventArgs e)
        {
            float markOfPhysics = Convert.ToInt32(physicsTextBox.Text);
            float markOfChemistry = Convert.ToInt32(chemistryTextBox.Text);
            float markOfMath = Convert.ToInt32(mathTextBox.Text);
            float averageMark = anResult.GetAverage(markOfPhysics, markOfChemistry, markOfMath);
            string obtainGrade = anResult.CalculateGrade(averageMark);

            averageTextBox.Text = averageMark.ToString();
            gradeLetterTextBox.Text = obtainGrade;
        }
    }
}
