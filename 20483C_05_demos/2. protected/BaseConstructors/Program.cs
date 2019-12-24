using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee1 = new Coffee();
            //coffee1.servingTemperature = 80; // doesn't work for either private or protected

            Console.WriteLine($"Serving temperature: {coffee1.GetServingTemperature()}");
        }
    }
}
