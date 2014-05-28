using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool x = true;
        if (n < 2)
        {
            x = false;
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    x = false;
                }

            }
        }
        Console.WriteLine(x);
    }
}
