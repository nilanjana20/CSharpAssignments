using System;

namespace Assignments
{
	public class EmployeeWageCaculation
	{
        private int wagePerHour = 20;
        private int fullDayInHour = 8;
		public string dailyEmployeeWage()
    {
        return $"Daily Employee Wage is {(wagePerHour * fullDayInHour)}";
    }

    }
}