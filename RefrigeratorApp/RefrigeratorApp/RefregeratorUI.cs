using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class RefregeratorUI : Form
    {
        public RefregeratorUI()
        {
            InitializeComponent();
        }
        Refrigerator aRefrigerator = new Refrigerator();
        private void saveButton_Click(object sender, EventArgs e)
        {
            double maximumWeight = Convert.ToDouble(maxWeightTextBox.Text);
            aRefrigerator.SetMaximumWeight(maximumWeight);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int noOfItem = Convert.ToInt32(numOfItemTextBox.Text);
            double currentWeight = Convert.ToDouble(weightTextBox.Text);
            aRefrigerator.SetValueNoOfItem(noOfItem);
            currentWeightTextBox.Text = aRefrigerator.GetCurrentWeight(currentWeight).ToString();
            remainWeightTextBox.Text = aRefrigerator.SetRemainingWeight().ToString();
        }
    }
}
