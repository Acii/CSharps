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
        decimal z = (n - k);
        BigInteger nkFacturial = 1;
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger resultFactorial = 1;
        if (result)
        {
            for (int i = 1; i <= n; i++ , k--)
            {
                nFactorial *= i;
                if (k > 0)
                {
                    kFactorial *= k;
                }
            }
            for (int u = 1; u <= z; u++)
            {
                nkFacturial *= u;
            }
            resultFactorial = nFactorial / (kFactorial * nkFacturial);
            Console.WriteLine("n! / k!(n-k)! = " + resultFactorial);
        }
    }
}

