using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int x = n >> 3;
        int bit = x & 1;
        Console.WriteLine("bit #3: {0}",bit);
    }
}

