using System;

namespace Assignments;
internal class LineComparisonuc1
{
    public static double LengthOfLine(int x1, int y1, int x2, int y2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }
    public static void Solution()
    {
        Console.Write("x1 = ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y1 = ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("x2 = ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y2 = ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"length of line is {LengthOfLine(x1, y1, x2, y2)} unit");

        Console.WriteLine("Welcome to Line Comparison Computation Program");
    }
}
