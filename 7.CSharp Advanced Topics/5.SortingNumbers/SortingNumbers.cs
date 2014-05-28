using System;
using System.Collections;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int result = Numbers(n);
    }
    static int Numbers(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        return 0;
    }
}

