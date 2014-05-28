using System;

class Comparing
{
    static void Main()
    {
        decimal a, b;
        string numberA = Console.ReadLine();
        string numberB = Console.ReadLine();
        a = decimal.Parse(numberA);
        b = decimal.Parse(numberB);
        if (Math.Abs(a - b) < 0.000001m)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

