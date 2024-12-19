using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class AverageExample
    {

        public static void Method()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            double avg1 = array.Average();
            Console.WriteLine(avg1);

            double avg2 = (from x in array select x).Average();
            Console.WriteLine(avg2);

            var avg3 = Employee.GetAllEmployee().Select(x => x.Salary).Average();
            Console.WriteLine(avg3);

            var avg4 = (from x in Employee.GetAllEmployee() select x.Salary).Average();
            Console.WriteLine(avg4);

            var avg5 = Employee.GetAllEmployee().Where(x => x.Designation == "Java FullStack Developer").Average(x => x.Salary);
            Console.WriteLine(avg5);
        }

    }
}
