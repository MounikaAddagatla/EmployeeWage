using System;
using System.Collections.Generic;
using System.Text;

namespace EmpProject
{
	class EmployeeAttendence
	{
		const int IS_FULLTIME = 0, IS_PRESENT = 1, IS_PARTTIME = 1, WAGE_PER_HOUR = 20,
			FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4;
		int totalwage = 0, emphours = 0;
		public void Attendance()
		{
			Random random = new Random();
			int employeecheck = random.Next(1, 3);
			switch (employeecheck)
			{
				case IS_FULLTIME:
					emphours += FULL_DAY_HOUR;
					break;
				case IS_PARTTIME:
					emphours += PART_TIME_HOUR;
					break;
				default:
					emphours += 0;
					break;
					totalwage = WAGE_PER_HOUR * emphours;
			}
		}
	}
}
