using System;

class Circle
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = {0:F2}",(2 * Math.PI * a));
        Console.WriteLine("Perimetyr = {0:F2}",(Math.PI * a * a));
    }
}

