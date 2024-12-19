using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLinQ
{
    internal class VoterId
    {

        public static void CheckVoter()
        {
            Console.WriteLine("enter your age");
            int age=int.Parse(Console.ReadLine());

            try
            {
                if(age<18)
                {
                    throw new AgeInvalidException("You are not eligible!!!");
                }
                else
                {
                    Console.WriteLine("You are eligible!!");
                }
            }
            catch(AgeInvalidException e)
            {
                Console.WriteLine(e.VMessage);
            }
        }

    }
}
