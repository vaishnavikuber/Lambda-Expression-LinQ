using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class MaxAndMinExample
    {
        public static void Method()
        {

            int[] array = { 10, 20, 30, 40, 50 };

            var min = array.Min();
            Console.WriteLine(min);

            var max = array.Max();
            Console.WriteLine(max);

            var min2 = Employee.GetAllEmployee().Min(x => x.Salary);
            Console.WriteLine(min2);

            var max2 = Employee.GetAllEmployee().Max(x => x.Salary);
            Console.WriteLine(max2);

            var min3 = (from x in Employee.GetAllEmployee() select x.Salary).Min();
            Console.WriteLine(min3);

            var sk = array.Skip(2);
            foreach(var x in sk)
            {
                Console.WriteLine(x);
            }

            var sk2 = Employee.GetAllEmployee().SkipWhile(x => x.Salary <+ 600000);
            foreach(var x in sk2)
            {
                Console.WriteLine(x.Salary);
            }

        }

    }
}
