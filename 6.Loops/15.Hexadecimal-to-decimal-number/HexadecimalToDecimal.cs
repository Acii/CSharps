using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("hexadecimal: ");
        string hexa = Console.ReadLine();
        int decValue = Convert.ToInt32(hexa, 16);
        Console.WriteLine("decimal = "+ decValue);
    }
}

