﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpProject
{
    class EmployeeAttendence
    {
		const int IS_PRESENT = 1, WAGE_PER_HOUR=20,FULL_DAY_HOUR =8 ,PART_TIME_HOUR=4;
		int totalwage = 0;
		public void Attendance()
		{
			Random random = new Random();
		 int employeecheck = random.Next(0, 2);
			if (employeecheck == IS_PRESENT)
			{
				this.totalwage = WAGE_PER_HOUR * FULL_DAY_HOUR;
			}
			else
				this.totalwage = WAGE_PER_HOUR * PART_TIME_HOUR;
		}
		
    }
}