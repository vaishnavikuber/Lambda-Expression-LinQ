using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class WhereLINQ
    {
        public static void ArrayFun()
        {
            int[] arr = {10,20,30,40,50,60,70,80,90};

            var elements = arr.Where(x => x > 20);
            foreach ( var elem in elements)
            {
                Console.WriteLine(elem);
            }

            var greater = from num in arr where num > 30 select num;
            foreach ( var num in greater )
            {
                Console.WriteLine(num);

            }
        }


    }
}
