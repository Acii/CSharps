using System;

class Matrix
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string[,] matrix = new string[r, c];
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = ""+(char)('a' + row) + (char)('a' + col);
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }
    }
}

