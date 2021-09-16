using System;
public class EmpStatus
{
	public EmpStatus()
	{
		const int IS_PRESENT = 1,
			WAGE_PER_HOUR = 20,
			FULL_DAY_HOUR = 8;
		public void Attendence()
		{
			Random random = new Random();
			int employeecheck = random.Next(1, 2);
			if (employeecheck == IS_PRESENT)
			{
				int totalwage = WAGE_PER_HOUR * FULL_DAY_HOUR;
				Console.WriteLine(totalwage);
			}
			else
				Console.WriteLine("Absent");
		}
		static void Main(String args[])
        {
			EmpStatus e = new EmpStatus();
			e.Attendence();
			Console.ReadLine();
        }
       
	}
}
