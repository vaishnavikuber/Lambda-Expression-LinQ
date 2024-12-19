using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class AllAnyExample
    {

        public static void GetDetails()
        {
            var detail = Employee.GetAllEmployee().All(x=>x.Salary>=600000);
            Console.WriteLine(detail);

            var any = Employee.GetAllEmployee().Any(x => x.Salary >= 600000);
            Console.WriteLine(any);
        }
    }
}
