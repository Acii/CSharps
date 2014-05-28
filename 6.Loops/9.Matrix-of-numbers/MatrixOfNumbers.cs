using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        if (1 < n || n < 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < n + row ; col++)
                {
                    Console.Write(" {0,2} ",col);
                }
                Console.WriteLine();
            }
        }
    }
}

