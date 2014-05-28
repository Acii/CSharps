using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        int x = n >> p;
        int bit = x & 1;
        Console.WriteLine("bit #p: {0}", bit);
    }
}

