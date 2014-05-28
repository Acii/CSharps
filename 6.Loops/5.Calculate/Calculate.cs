using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        decimal result = 1;
        decimal product = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            product *=x;
            result += (factorial / product);
        }

        Console.WriteLine("S = " + result);
    }
}