using System;

namespace Assignments
{
	public class Program
	{
		public static void Main()
			{
				// EmployeeWage.AttendanceCheck();
				// Console.WriteLine("Welcome to Employeewage computation program on master branch");
			    // Console.WriteLine(Assignments.EmployeeWage.AttendanceCheck()? "Employee is present" : "Employee is absent");
				 Assignments.EmployeeWageCaculation res = new Assignments.EmployeeWageCaculation();
                 Console.WriteLine(res.dailyEmployeeWage());
			}
	}
}

