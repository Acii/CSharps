using System;
using System.Linq;

class ZeroSubset
{
    static void Main()
    {
        int[] number = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("n = ");
            number[i] = int.Parse(Console.ReadLine());
        }
        int x = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if(number.Sum() == 0)
            {
                Console.WriteLine();
            }
        }
    }
}

