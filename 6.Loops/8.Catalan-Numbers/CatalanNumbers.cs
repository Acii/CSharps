using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool result = (1 < n && n < 100);
        int a = (2*n);
        int b = (n + 1);
        BigInteger n2Factorial = 1;
        BigInteger n1Factorial = 1;
        BigInteger nFactorial = 1;
        BigInteger resultFactorial = 1;
        if (result)
        {
            for (int i = 1; i <= a; i++ , n-- , b--)
			{
                n2Factorial *= i;
			    if (n > 0)
                {
                    nFactorial *= n;
                }
                if (b > 0)
                {
                    n1Factorial *= b;
                }
			}
             resultFactorial = n2Factorial / (n1Factorial * nFactorial);
            Console.WriteLine("result = " + resultFactorial);
        }
        else
        {
            Console.WriteLine("result = " + 1);
        }
    }
}

