using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaAndLinQ
{
    internal class DistinctEmployeeLINQ
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }

        public static List<DistinctEmployeeLINQ> GetAllEmployee()
        {
            List<DistinctEmployeeLINQ> EmpList = new List<DistinctEmployeeLINQ>()
            {
                new DistinctEmployeeLINQ(){ EmployeeId = 101, EmployeeName = "Prabha" , Designation=".NET FullStack Developer", Salary=400000  },
                new DistinctEmployeeLINQ(){ EmployeeId = 101, EmployeeName = "Prabha" , Designation=".NET FullStack Developer", Salary=400000  },
                new DistinctEmployeeLINQ(){ EmployeeId = 102, EmployeeName = "Anu" , Designation="Java FullStack Developer", Salary=300000  },
                new DistinctEmployeeLINQ(){ EmployeeId = 103, EmployeeName = "Namrata" , Designation="Python FullStack Developer", Salary=600000  },
                new DistinctEmployeeLINQ(){ EmployeeId = 104, EmployeeName = "Rachana" , Designation="Software Developer", Salary=400000  }
            };
            return EmpList;
        }

        public static void EmpDisplay()
        {
            var employee = DistinctEmployeeLINQ.GetAllEmployee().Select(x=>x.EmployeeId).Distinct();
            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }

            var emp2 = (from empl in DistinctEmployeeLINQ.GetAllEmployee() select empl.Salary).Distinct();
            foreach (var emp in emp2)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
