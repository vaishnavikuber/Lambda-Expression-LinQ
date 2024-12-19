using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LambdaAndLinQ;

namespace LambdaAndLinQ
{
    internal class Person
    {

        public int SSN {  get; set; }
        public string Name { get; set; }
        public string Address {  get; set; }
        public int Age {  get; set; }

        public static void Details()
        {

            List<Person> person = new List<Person>()
           {

               new Person(){ SSN= 101 , Name= "Shanta", Address="Hubli", Age=14},
                   new Person(){ SSN= 101 , Name= "Mandakini", Address="Dharwad", Age=24},
                   new Person(){ SSN= 102 , Name= "Yashu", Address="Bangalore", Age=23},
                   new Person(){ SSN= 103 , Name= "Bhuvan", Address="Mysore", Age=27},
                   new Person(){ SSN= 104 , Name= "Hema", Address="Bangalore", Age=67}

           };

            var Pnames = person.FindAll(x => x.Age > 60).Take(2);
            foreach (Person p in Pnames)
            {
                Console.WriteLine(p.Name);
            }

            var Record = person.FindAll(x => x.Age >= 13 && x.Age <= 18);
            foreach (Person p in Record)
            {
                Console.WriteLine($"SSN : {p.SSN}  Name:{p.Name} Address:{p.Address} Age: {p.Age}");
            }

            var Average = person.Average(x => x.Age);

            Console.WriteLine("Average: " + Average);


            var contains = person.Where(x => x.Name.Contains("Yashu"));
            foreach (Person p in contains)
            {
                Console.WriteLine(p.Name);
            }
        }


        

    }
}
