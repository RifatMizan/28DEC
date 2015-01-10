using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeedCalculatorApp
{
    public partial class VechileUI : Form
    {
        public VechileUI()
        {
            InitializeComponent();
        }

        Vechile aVechile = new Vechile();
        private void create_Button_Click(object sender, EventArgs e)
        {

        }
        int maxSpeed = 0;
        int minspeed = 0;
        int a = 0;
        private void enter_Button_Click(object sender, EventArgs e)
        {
            
            int vechileSpeed = Convert.ToInt32(speedTextBox.Text);
            int tb = aVechile.speedCalculator(vechileSpeed);
            
        }

        private void show_Button_Click(object sender, EventArgs e)
        {
            int maxSpeed = aVechile.MaxSpeedCalculator();
            int minSpeed = aVechile.MinSpeedCalculator();
            minspeedTextBox.Text = minSpeed.ToString();
            maxSpeedTextBox.Text = maxSpeed.ToString();
            avgSpeedTextBox.Text = aVechile.AverageCalculator(maxSpeed, minSpeed).ToString();
        }
    }
}
