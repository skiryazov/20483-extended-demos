using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Object o = i;
            i++;
            Console.WriteLine(o);
            Object p = o;
            int j = (int)o;
            j++;
            Console.WriteLine(o);
            Console.WriteLine(p);

            // boxing allows us to add value types to lists of type Object
            ArrayList list = new ArrayList() { i, j, o, p, "string" };
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            // even constant literals can be boxed
            5.ToString();

        }

        

    }
}
