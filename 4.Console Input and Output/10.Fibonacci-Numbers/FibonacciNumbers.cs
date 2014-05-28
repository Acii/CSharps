using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        if (n == 1) 
        {
            Console.Write(0 + " ");
        }
        else 
        {
            int first = 0;
            int second = 1;
            Console.Write(first + " ");
            Console.Write(second + " ");
            int thrid = 0;
            for (int i = 2; i < n; i++)
			{
                thrid = first + second;
                Console.Write(thrid + " ");
                first = second;
                second = thrid;
			}
        }
    }
}

