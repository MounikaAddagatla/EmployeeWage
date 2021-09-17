using System;
namespace EmpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage caluclation");
            EmployeeAttendence e = new EmployeeAttendence();
            e.Attendance();
            Console.ReadLine();
        }
    }
}
