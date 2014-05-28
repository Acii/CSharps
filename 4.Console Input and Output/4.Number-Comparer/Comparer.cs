using System;

class Comparer
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("a = " + a);
        }
        else
        {
            Console.WriteLine("b = " + b);
        }
    }
}

