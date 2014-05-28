using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("decimal: ");
        string number = Console.ReadLine();
        int val = int.Parse(number);
        string hex = val.ToString("X");
        Console.WriteLine("hexadecimal: " + hex);
    }
}

