using System;
using System.Linq;
using System.Collections.Generic;

namespace Emp_WageCaluclation
{
    class Employee
    {
        int ID;
        string Name;
        private int Salary;
        private string Department;

        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Employee Wage Computation");
            }
            bool isExist = false;

            List<Employee> employees = new List<Employee>()
            {
             new Employee {ID=101,   Name="Amit  "    , Salary=4000,Department="ABC"},
             new Employee {ID=102,   Name="Amit  "    , Salary=3000,Department="XYZ"},
             new Employee {ID=103,   Name="Salman"    , Salary=3000,Department="ABC"},
             new Employee {ID=104,   Name="Ram   "    , Salary=2000,Department="XYZ"},
             new Employee {ID=105,   Name="Shyam "    , Salary=7000,Department="ABC"},
             new Employee {ID=106,   Name="Kishor"    , Salary=5000,Department="XYZ"},
            };
            Employee Emp1 = new Employee()
            { 
                ID = 101, Name = "Amit", Salary = 4000, Department = "ABC" 
            };

            isExist = employees.AsEnumerable().Contains(Emp1);

            if (isExist == true)
            {
                Console.WriteLine("Emp1 exists in the employees list"+Emp1);
            }
            else
            {
                Console.WriteLine("Emp1 does not exist in the employee's list"+Emp1);
            }
            
        }
    
    }S
}
