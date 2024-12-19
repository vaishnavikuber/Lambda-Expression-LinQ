using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class OrderByExample
    {

       public static void Order()
        {
            int[] array = { 10, 30, 20, 40, 60 };
            var order1 = array.OrderBy(x => x);

            foreach (int x in order1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("-------------------------");

            var order2 = (from x in array select x).OrderBy(x => x);
            foreach (int x in order2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("-------------------------");

            var oredr3= Employee.GetAllEmployee().Select(x=>x.EmployeeId).OrderBy(x => x);
            foreach(var x in oredr3)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("-------------------------");

            var order4= (from x in Employee.GetAllEmployee() select x).OrderBy(x=>x.EmployeeName);
            foreach (var x in order4)
            {
                Console.WriteLine(x.EmployeeName);
            }

            Console.WriteLine("-------------------------");

            var order5 = (from x in Employee.GetAllEmployee() select x.EmployeeName).OrderByDescending(x => x);
            foreach (var x in order5)
            {
                Console.WriteLine(x);
            }
        }

        
    }
}
