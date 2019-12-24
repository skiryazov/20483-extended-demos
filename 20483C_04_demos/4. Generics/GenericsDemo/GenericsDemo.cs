using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace GenericsDemo
{
    public class GenericsDemo
    {
        public static void Main() {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);

            // problem 1: you need to cast
            //int value = arrayList[0]; // doesn't work
            int value = (int)arrayList[0];

            // problem 2: no compile-time protection 
            arrayList.Add("not a number");
            value = (int)arrayList[1]; // No compilation error. What would happen if we run it?

            // now let's see the light
            List<int> list = new List<int>();
            list.Add(1);
            //list.Add("not a number"); // doesn't compile

            value = list[0]; // Do you see casting anywhere?
            var value2 = list[0]; // we can even do that - it knows that it's an int coming from the list
        }
    }

    public class CustomSortedList<T> where T : IComparable
    {

    }
}
