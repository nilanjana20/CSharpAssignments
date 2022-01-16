using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments;

internal class EmployeeWagePerMonth
{
    private const int wagePerHour = 20;
    private const int fullDayInHour = 8;
    private const int partTimeInHour = 4;
    private const int workingDayPerMonth = 20;

    private double FullDayEmployeeWage()
    {
        return (double)(wagePerHour * fullDayInHour);
    }

    private double PartTimeEmployeeWage()
    {
        return (double)(wagePerHour * partTimeInHour);
    }

    private string AttendanceCheck()
    {
        Random random = new Random();
        int attendance = random.Next(0, 3);

        if (attendance == 1) return "full_time";
        if (attendance == 2) return "part_time";
        return "absent";
    }

    public static void Solution()
    {
        int totalFullDayPresent = 0, totalPartTimePresent = 0, totalAbsent = 0;

        EmployeeWagePerMonth app = new EmployeeWagePerMonth();
        for (int i=0; i < workingDayPerMonth; i++)
        {
            string todayEmpAttendance = app.AttendanceCheck();
            switch (todayEmpAttendance)
            {
                case "full_time":
                    totalFullDayPresent++;
                    break;
                case "part_time":
                    totalPartTimePresent++;
                    break;
                case "absent":
                    totalAbsent++;
                    break;
            }

            double salary = todayEmpAttendance == "full_time" ? app.FullDayEmployeeWage() : (todayEmpAttendance == "part_time"? app.PartTimeEmployeeWage(): 0);

            Console.WriteLine($"{i+1}). {salary}\t | \t{todayEmpAttendance}");
        }

        double monthEndSalary = (totalFullDayPresent * app.FullDayEmployeeWage()) + (totalPartTimePresent * app.PartTimeEmployeeWage());

        Console.WriteLine($"This month's salary is {monthEndSalary}");
    }
}