using System;

namespace Assignments;
internal class LineComparisonUC3
{
    public static double LengthOfLine()
    {
        Console.Write("x1 = ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y1 = ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("x2 = ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y2 = ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }

    public static void Solution()
    {
        string comparision = "";
        Console.WriteLine("Insert data for 1st line: ");
        double line1Length = LengthOfLine();
        Console.WriteLine("Insert data for 2nd line: ");
        double line2Length = LengthOfLine();
        if (line1Length > line2Length) comparision = "is greater than";
        else if (line1Length < line2Length) comparision = "is less than";
        else if (line1Length == line2Length) comparision = "is equals to";
        else
        {
            comparision = "unknown";
            Console.WriteLine($"Error: something went worng");
        }
        Console.WriteLine($"{line1Length} {comparision} {line2Length}");
    }
}