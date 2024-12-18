using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLinQ
{
    internal class DivideBy2
    {

        public static void Divide(List<int> l)
        {
            
            foreach(int i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("after dividing by 2");
            List<int> list = l.FindAll(x => x % 2 == 0);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }

    }
}
