﻿using System;

class sortNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a >= b && a >= c)
        {
            if (b >= c)
            {
                Console.WriteLine("result: {0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("result: {0} {1} {2}", a, c, b);
            }
        }
        else if (b >= a && b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine("result: {0} {1} {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("result: {0} {1} {2}", b, c, a);
            }
        }
        else if (c >= a && c >= b)
        {
            if (a >= b)
            {
                Console.WriteLine("result: {0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("result: {0} {1} {2}", c, b, a); 
            }
        }
        else
        {
            Console.WriteLine("result: {0} {1} {2}", a , b, c);
        }
    }
}

