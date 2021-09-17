using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProject1
{
    class EmpPresent
    {
		const int IS_PRESENT = 1;
		public void Attendance()
		{
			Random random = new Random();
			int employeecheck = random.Next(0, 2);
			if (employeecheck == IS_PRESENT)
				Console.WriteLine("Present");
			else
				Console.WriteLine("Absent");
		}
	}
}
