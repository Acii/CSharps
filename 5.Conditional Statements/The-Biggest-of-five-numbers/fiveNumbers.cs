using System;

class fiveNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());
        double biggest;
        bool biggestA = ((a >= b) && (a >= c) && (a >= d) && (a >=e));
        bool biggestB = ((b >= c) && (b >= d) && (b >= e));
        bool biggestC = ((c >= d) && (c >= e));
        bool biggestD = (d >= e);
        if (biggestA)
        {
            biggest = a;
            Console.WriteLine("biggest: {0}",biggest);
        }
        else if (biggestB)
        {
            biggest = b;
            Console.WriteLine("biggest: {0}",biggest);
        }
        else if (biggestC)
        {
            biggest = c;
            Console.WriteLine("biggest: {0}",biggest);
        }
        else if (biggestD)
        {
            biggest = d;
            Console.WriteLine("biggest: {0}",biggest);
        }
        else
        {
            biggest = e;
            Console.WriteLine("biggest: {0}",biggest);
        }
    }
}

