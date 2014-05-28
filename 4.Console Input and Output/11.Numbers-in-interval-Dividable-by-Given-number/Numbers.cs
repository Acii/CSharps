using System;

class Numbers
{
    static void Main()
    {
        Console.Write("start = ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("end = ");
        int end = int.Parse(Console.ReadLine());
        int p= 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ",");
                p++;
            }
        }
        Console.WriteLine("p = " + p);
    }
}

