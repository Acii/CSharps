using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = Fib(n);
        Console.WriteLine(result);
    }
     static BigInteger Fib(int n)
    {
        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger numNew;
        for (int i = 1; i <= n; i++)
        {
            numNew = first + second;
            first = second;
            second = numNew;
            if (i == n)
            {
                return numNew;
            }
        }
        return 1;
    }
}

