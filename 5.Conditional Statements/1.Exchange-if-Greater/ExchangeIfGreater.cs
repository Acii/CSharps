﻿using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            double c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("result:{0} {1}", a, b);
    }
}

