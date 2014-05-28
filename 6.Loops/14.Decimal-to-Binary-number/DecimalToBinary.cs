using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("decimal: ");
        int num = int.Parse(Console.ReadLine());
        int rem = 0;
        string result = string.Empty;
        while (num > 0)
        {
            rem = num % 2;
            num = num / 2;
            result = rem.ToString() + result;
        }
        Console.WriteLine("Binary: " + result);
    }
}

