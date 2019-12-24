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
            Tea tea1 = new Tea();
            Coffee coffee2 = new Coffee("Fourth Espresso", true, 170, "Arabica", "Dark", "Columbia");

            //Beverage bevarage1 = new Beverage();
            List<Beverage> menu = new List<Beverage> { coffee1, tea1, coffee2};
            foreach(Beverage bev in menu)
            {
                Console.WriteLine("Serving temp: " + bev.GetServingTemperature());
            }

            Console.WriteLine("Serving temp of tea: " + tea1.GetServingTemperature());
            Console.WriteLine("Serving temp of tea as bev: " + ((Beverage)tea1).GetServingTemperature());

        }
    }
}
