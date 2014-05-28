using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            sum += x;
        }
        Console.WriteLine("sum = " + sum);
    }
}

