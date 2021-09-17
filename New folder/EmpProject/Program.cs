using System;
namespace EmpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAttendence e = new EmployeeAttendence();
            int wage= e.totalwage;
            Console.WriteLine(wage);
            Console.ReadLine();
        }
    }
}
