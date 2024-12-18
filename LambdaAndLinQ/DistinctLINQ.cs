using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class DistinctLINQ
    {

        public static void ArrayLINQ()
        {
            int[] array = { 10, 20, 30, 40, 50,20 ,30};
            var number = array.Distinct();
            foreach ( var i in number )
            {
                Console.WriteLine( i );
            }
            var num= (from x in array select x).Distinct();
            foreach( var i in number )
            {
                Console.WriteLine( i );
            }
        }

    }
}
