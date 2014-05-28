using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        bool result = IsPrime(n);
        Console.WriteLine(result);
    }
    static bool IsPrime(BigInteger n)
    {
        bool prime = true;
        if (n < 2)
        {
            prime = false;
            return prime;
        }
        for (BigInteger i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                prime = false;
                return prime;
            }
        }
        return prime;
        
    }
}

