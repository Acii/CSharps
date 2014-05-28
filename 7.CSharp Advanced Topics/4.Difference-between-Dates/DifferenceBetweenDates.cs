using System;
using System.IO;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("startDate: MM.dd.yyyy");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.Write("endDate: MM.dd.yyyy");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        double days = CountDays(startDate, endDate);
        Console.WriteLine("Days between: {0}", days);
    }
    private static double CountDays(DateTime start, DateTime end)
    {
        TimeSpan span = end - start;
        double result = span.TotalDays;
        return result;
    }
}

