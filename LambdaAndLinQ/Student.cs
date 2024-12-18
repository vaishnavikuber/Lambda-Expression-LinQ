using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){Id=101,Name="Raam",Course="JFS"},
                new Student(){Id=101,Name="Shaam",Course="PFS"},
                new Student(){Id=101,Name="Bhaam",Course=".NETFS"},
                new Student(){Id=101,Name="Seeta",Course="Automation"},
                new Student(){Id=101,Name="Shri",Course="DevOps"},
                new Student(){Id=101,Name="Hari",Course="PFS"},
            };
            return studentList;
        }

        public static void DisplayStudent()
        {
            //method syntax
            var students = Student.GetAllStudents();

            //query syntax
            var student = from stud in Student.GetAllStudents() select stud;
            foreach (var i in students)
            {
                Console.WriteLine($"{i.Id} , {i.Name} , {i.Course}");
            }
            Console.WriteLine(  "   ");
            foreach(var i in student)
            {
                Console.WriteLine($"{i.Id} , {i.Name} , {i.Course}");

            }
        }

    }
}
