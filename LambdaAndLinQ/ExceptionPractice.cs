using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLinQ
{
    internal class ExceptionPractice
    {

        public static void Method()
        {
            int[] array = { 29, 37, 0, 12, 23 };
            try
            {
                for (int i=0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine(array[-1]);
            }
           
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception!!!" + e.Message);
            }
            finally
            {
                try
                {
                    int num = 0;
                    Console.WriteLine($"{2/num}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception" + e.Message);
                }
                Console.WriteLine(array[2]);
            }
        }

    }
}
