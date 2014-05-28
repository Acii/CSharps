using System;

class Trapeziods
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h = ");
        double h = double.Parse(Console.ReadLine());
        double s = (0.5 * (a + b)) * h;
        Console.WriteLine("Area = {0}" , s);
    }
}

