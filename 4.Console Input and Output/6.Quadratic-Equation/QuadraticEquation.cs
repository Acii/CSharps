using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;
        double z = Math.Round(Math.Sqrt(d));
        bool result = (z >= 0);
        if (result)
        {
            double x1 =  ((-b - z)/ (2*a));
            double x2 = ((-b + z)/ (2 * a));
            Console.WriteLine("x1 = {0}, x2 = {1}",x1,x2);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}

