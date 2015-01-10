using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        private double maximumWeight { set; get; }
        private int noOfItem;
        private double currentWeight{set; get; }
        private double remainingWeight;
        public int NoOfItem
        {
            set { noOfItem = value; }
        }

        public double RemainingWeight
        {
            get { return remainingWeight; }
            set { remainingWeight = value; }
        }

        public void SetValueNoOfItem(int noOfItem)
        {
            NoOfItem = noOfItem;
        }

        public void SetMaximumWeight(double MaximumWeight)
        {
            this.maximumWeight = MaximumWeight;
        }

        public double GetCurrentWeight(double CurrentWeight)
        {
            this.currentWeight += CurrentWeight;
            return this.currentWeight;
        }

        public double SetRemainingWeight()
        {
            RemainingWeight = maximumWeight - currentWeight;
            return RemainingWeight;
        }
    }
}
