using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 7;
        uint bit345 = ((mask << 3) & n) >> 3;
        uint bits = ((mask << 24) & n) >> 24;
        n = ~(mask << 24) & n;                         
        n = ~(mask << 3) & n;
        n = (bit345 << 24) | n;
        n = (bits << 3) | n;
        Console.WriteLine(n);
        
    }
}

