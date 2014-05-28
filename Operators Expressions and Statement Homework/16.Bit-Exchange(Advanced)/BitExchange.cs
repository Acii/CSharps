using System;

class BitExchange
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        if (Math.Abs(Math.Abs(q) - Math.Abs(p)) < k)
        {
            Console.WriteLine("overlapping");
        }
        else if ((p + k > 32) || (q + k > 32) ||
                 (p < 0) || (q < 0))
        {
            Console.WriteLine("out of range");
        }
        else
        {
            uint mask = Convert.ToUInt32(new string('1', k), 2);
            uint bitP = ((mask << p) & n) >> p;
            uint bitQ = ((mask << q) & n) >> q;
            n = ~(mask << p) & n;
            n = ~(mask << q) & n;
            n = (bitP << q) | n;
            n = (bitQ << p) | n;
            Console.WriteLine(n);
        }
    }
}

