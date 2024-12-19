using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class ElementAtExample
    {

       public static void Method()
        {
            int[] array = { 10, 30, 20, 40, 60 };
            var element = array.ElementAt(2);
            Console.WriteLine(element);

            var element2 = (from e in array select e).ElementAt(2);
            Console.WriteLine(element2);

            var element3=array.ElementAtOrDefault(5);
            Console.WriteLine(element3);

            var first = array.First();
            Console.WriteLine(first);

            var last=array.Last();
            Console.WriteLine(last);
        }

    }
}
