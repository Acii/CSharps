using System;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("input: ");
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];
        for (int i = 0; i <number.Length; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum = " + number.Sum());
        Console.WriteLine("Max = " + number.Max());
        Console.WriteLine("Min = " + number.Min());
        Console.WriteLine("Avg = " + number.Average());
    }
}
