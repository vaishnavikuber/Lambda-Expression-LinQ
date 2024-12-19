using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class Employee
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation {  get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetAllEmployee()
        {
            List<Employee> EmpList = new List<Employee>()
            {
                new Employee(){ EmployeeId = 101, EmployeeName = "Prabha" , Designation=".NET FullStack Developer", Salary=700000  },
                new Employee(){ EmployeeId = 102, EmployeeName = "Anu" , Designation="Java FullStack Developer", Salary=300000  },
                new Employee(){ EmployeeId = 103, EmployeeName = "Namrata" , Designation="Python FullStack Developer", Salary=600000  },
                new Employee(){ EmployeeId = 104, EmployeeName = "Rachana" , Designation="Software Developer", Salary=400000  },
                new Employee(){ EmployeeId = 102, EmployeeName = "Bhanu" , Designation="Java FullStack Developer", Salary=500000  }
            };
            return EmpList;
        }

        public static void EmpDisplay()
        {
            var employee = Employee.GetAllEmployee().Where(x=>x.EmployeeName=="Namrata");
            foreach(var emp in employee)
            {
                Console.WriteLine($"Id: {emp.EmployeeId}   Name : {emp.EmployeeName}  Salary: {emp.Salary}  Designation: {emp.Designation}");
            }

            var emp2 = from empl in Employee.GetAllEmployee() where empl.Salary == 400000 select empl;
            foreach (var emp in emp2)
            {
                Console.WriteLine($"{emp.EmployeeName} earns {emp.Salary} per month");
            }
        }

    }
}
