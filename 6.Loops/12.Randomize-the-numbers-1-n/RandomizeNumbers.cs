using System;

class RandomizeNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int min = 1;
        Random rnd = new Random();
        Console.WriteLine("Randomize Numbers 1..n");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(rnd.Next(min,n) + " ");
        }
    }
}

