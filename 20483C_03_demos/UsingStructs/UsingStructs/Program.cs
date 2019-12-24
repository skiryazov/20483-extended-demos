using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStructs
{

    struct Coffee
    {
        // 1. public field
        // public int Strength;

        // 2. pair of methods
        //private int strength;
        //public int getStrength()
        //{
        //    return strength;
        //}
        //public void setStrength(int value)
        //{
        //    strength = value;
        //}

        // 3. add validation
        //private int strength;
        //public int getStrength()
        //{
        //    if (user.hasAccess())
        //        return strength;
        //}
        //public void setStrength(int value)
        //{
        //    if (strength > 0 && strength <= 4)
        //        strength = value;
        //    else throw new ArgumentOutOfRangeException();
        //}

        // 3.a) "virtual" variables
        //private DateTime dateOfBirth;
        //public int Age
        //{
        //    get
        //    {
        //        return (int)(DateTime.Now - dateOfBirth).TotalDays / 365;
        //    }
        //}

        // 4. .NET property - full form
        //private int strength;
        //public int Strength
        //{
        //    get
        //    {
        //        return strength;
        //    }
        //    set
        //    {
        //        strength = value;
        //    }
        //}

        public string Name { get; set; }
        public string Bean { get; set; }
        public string CountyOfOrigin { get; set; }
        public int Strength { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee1 = new Coffee();

            coffee1.Strength = 3;

            coffee1.Name = "Fourth Coffee Quencher";
            coffee1.CountyOfOrigin = "Indonesia";
            Console.WriteLine("Name: {0}", coffee1.Name);
            Console.WriteLine("Country of Origin: {0}", coffee1.CountyOfOrigin);
            Console.WriteLine("Strength: {0}", coffee1.Strength);
        }
    }
}
