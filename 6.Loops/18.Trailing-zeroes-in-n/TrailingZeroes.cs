using System;
using System.Numerics;

class TraillingZeroesInN
{
    static void Main()
    {
        Console.Write("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger c = 0 , b = 0, a = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            a *= i;
        }
        c = a;
        while(c % 10 == 0)
        {
            b++;
            c = c / 10;
        }
        Console.WriteLine("trailing zeroes of n!: " + b);
        Console.WriteLine("explaination: " + a);
    }

    private static object Parse(string n)
    {
        throw new NotImplementedException();
    }

    private static BigInteger Pow(int a, int p)
    {
        throw new NotImplementedException();
    }
}

