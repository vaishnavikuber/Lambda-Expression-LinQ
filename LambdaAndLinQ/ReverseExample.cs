using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class ReverseExample
    {

        public static void Method()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            var reverse = array.Reverse();
            foreach (int x in reverse)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("------------------");

            var reverse2 = (from x in array select x).Reverse();
            foreach (int x in reverse2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("---------------------");

            var reverse3 = Employee.GetAllEmployee().Select(x => x.EmployeeName).Reverse();
            foreach (var x in reverse3)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("------------------------");

            var reverse4= (from x in Employee.GetAllEmployee() select x.EmployeeId).Reverse();
            foreach (var x in reverse4)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("------------------------");
            List<string> list = new List<string>() { "apple" , "banana" ,"watermelon" ,"mango" ,"orange" };
            var reverse5 = list.Reverse<string>();
            foreach(var x in reverse5)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("------------------------");

            var reverse6 = (from x in Employee.GetAllEmployee() select x).Reverse();
            foreach (var x in reverse6)
            {
                Console.WriteLine(x.EmployeeName);
            }

            Console.WriteLine("------------------------");
        }

    }
}
