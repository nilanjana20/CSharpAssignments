using System;

namespace Assignments
{
	public class EmployeeWage
	{
		public static bool AttendanceCheck()
			{
				{
                  Random attendance = new Random();

                  if(attendance.Next(0, 2) == 1) return true;
                  return false;
                }
			}
	}
}
