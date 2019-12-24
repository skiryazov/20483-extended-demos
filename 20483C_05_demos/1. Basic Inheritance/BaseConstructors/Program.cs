using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructors
{
    class Program
    {
        class Beverage
        {
            public string Name { get; set; }
            public bool IsFairTrade { get; set; }

            protected int servingTemperature;
            public int GetServingTemperature() {
                return servingTemperature;
            }
        }

        class Coffee : Beverage
        {
            public Coffee()
            {
                servingTemperature = 80;
            }

            public string Bean { get; set; }
            public string Roast { get; set; }
            public string CountryOfOrigin { get; set; }
        }
        static void Main(string[] args)
        {
            Coffee coffee1 = new Coffee();
            coffee1.IsFairTrade = true;
            coffee1.Bean = "Robusta";
            Console.WriteLine($"Bean: {coffee1.Bean}, fair trade: {coffee1.IsFairTrade}");
        }
    }
}
