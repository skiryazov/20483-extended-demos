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
            Console.WriteLine(coffee1.GetServingTemperature());


            //Beverage bevarage1 = new Beverage();
            List<Beverage> menu = new List<Beverage> { coffee1, tea1, coffee2};
            foreach(Beverage bev in menu)
            {
                Console.WriteLine("Serving temp: " + ((Coffee)bev).GetServingTemperature());
            }   
        }
    }
}
