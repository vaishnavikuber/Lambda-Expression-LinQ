using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class ContainsLINQ
    {

        public static void CheckContains()
        {
            string[] names = { "avanti", "vaibhav", "david", "vaibhavi" };

            var mName = names.Where(x=>x.Contains("v"));

            var qName = from n in names where n.Contains('v') select n;

            foreach(var n in qName)
            {
                Console.WriteLine(n);
            }
            foreach(var n in mName)
            {
                Console.WriteLine(n);
            }
        }
    }
}
