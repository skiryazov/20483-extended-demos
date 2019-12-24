using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructors
{
    public abstract class Beverage
    {
        public Beverage()
        {
            // This is the default constructor.
            // You can use this to set default values.
            IsFairTrade = false;
            servingTemperature = int.MinValue;
            Name = "Not known";

        }

        public Beverage(string name, bool isFairTrade, int servingTemp)
        {
            // This is the alternative constructor.
            this.Name = name;
            this.IsFairTrade = isFairTrade;
            this.servingTemperature = servingTemp;
        }

        protected int servingTemperature;
        public int GetServingTemperature() {
            return int.MinValue;
        }

        public string Name { get; set; }
        public bool IsFairTrade { get; set; }
    }
}
