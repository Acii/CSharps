using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("n = ");
        decimal n = decimal.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }
    }
}

