using System;

class TheBiggest
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double biggest;
        if ((a > b) && (a > c))
        {
            biggest = a;
            Console.WriteLine("Biggest = {0}",biggest);
        }
        else if ((b > a) && (b > c))
        {
            biggest = b;
            Console.WriteLine("Biggest = {0}", biggest);
        }
        else if ((c > a) && (c > b))
        {
            biggest = c;
            Console.WriteLine("Biggest = {0}", biggest);
        }
        else
        {
            Console.WriteLine("a == b == c");
        }
    }
}

