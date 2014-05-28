using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int bit = ~(1 << p);
            int result = n & bit;
            Console.WriteLine("result: {0}", result);
        }
        else 
        {
            int bit = v << p;
            int result = n | bit;
            Console.WriteLine("result: {0}", result);
        }
    }
}

