using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments;

internal class EmployeeWageSwitchCase
{
    private const int wagePerHour = 20;
    private const int fullDayInHour = 8;
    private const int partTimeInHour = 4;

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
        int attendance = random.Next(1, 3);

        if (attendance == 1) return "full_time";
        if (attendance == 2) return "part_time";
        return "absent";
    }

    public static void Solution()
    {
        EmployeeWageSwitchCase app = new EmployeeWageSwitchCase();
        string todayEmpAttendance = app.AttendanceCheck();
        double salary = 0;
        switch (todayEmpAttendance)
        {
            case "full_time":
                salary = app.FullDayEmployeeWage();
                break;
            case "part_time":
                salary = app.PartTimeEmployeeWage();
                break;
        }

        Console.WriteLine($"{todayEmpAttendance}:> Today's salary is {salary}");
    }
}