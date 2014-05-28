using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        bool result = ((1 < k) && (k < n) && (n < 100));
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger resultFactorial = 1;
        if (result)
        {
            for (int i = 1; i <= n; i++ ,k-- )
            {
                nFactorial *= i;
                if(k > 0)
                {
                    kFactorial *= k;
                }
            }
            resultFactorial = nFactorial / kFactorial;
            Console.WriteLine("n! / k! = " + resultFactorial);
        }
    }
}

