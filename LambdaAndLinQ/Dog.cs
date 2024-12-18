using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class Dog
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public static void DisplayName()
        {
            List<Dog> Dlist = new List<Dog>()
            {
                new Dog(){Name="Raja",Age=4},
                new Dog(){Name="Jimmy",Age=3 },
                new Dog(){Name="Silent",Age=8}
            };

            var Names = Dlist.Select(dog => dog.Name);
            foreach (var name in Names)
            { 

                Console.WriteLine(name);

            }
        }


        public static void DogDemo()
        {
            List<Dog> Dlist = new List<Dog>()
            {
                new Dog(){Name="Raja",Age=4},
                new Dog(){Name="Jimmy",Age=3 },
                new Dog(){Name="Silent",Age=8}
            };

            var dogs = Dlist.Select(x => new { Age = x.Age, FirstLetter = x.Name[0]  }); 
            foreach(var dog in dogs)
            {
                Console.WriteLine(dog);
            }

            var OrderDog = Dlist.OrderBy(x => x.Age);
            foreach(var dog in OrderDog)
            {
                Console.WriteLine($"Dog {dog.Name} is {dog.Age} years old.");
            }
        }

    }
}
