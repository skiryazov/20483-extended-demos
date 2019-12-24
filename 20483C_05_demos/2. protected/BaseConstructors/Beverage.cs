using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructors
{
    class Beverage
    {
        public Beverage() {
            servingTemperature = int.MinValue;
        }
        public string Name { get; set; }
        public bool IsFairTrade { get; set; }

        private int servingTemperature;
        public int GetServingTemperature()
        {
            return servingTemperature;
        }
    }

    class Coffee : Beverage
    {
        public Coffee()
        {
            //servingTemperature = 80;
        }
        public string Bean { get; set; }
        public string Roast { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}
