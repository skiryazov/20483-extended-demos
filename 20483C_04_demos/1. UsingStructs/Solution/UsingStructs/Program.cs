using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStructs
{

    internal class Coffee
    {

        public string Name { get; set; }
        public string Bean { get; set; }
        public string CountyOfOrigin { get; set; }
        public int Strength { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var coffee1 = new Coffee();

            coffee1.Strength = 3;

            coffee1.Name = "Fourth Coffee Quencher";
            coffee1.CountyOfOrigin = "Indonesia";

            //coffee1.
            Console.WriteLine("Name: {0}", coffee1.Name);
            Console.WriteLine("Country of Origin: {0}", coffee1.CountyOfOrigin);
            Console.WriteLine("Strength: {0}", coffee1.Strength);
        }
    }
}
