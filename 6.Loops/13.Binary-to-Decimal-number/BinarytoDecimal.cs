using System;

class BinarytoDecimal
{
    static void Main()
    {
        Console.Write("binary: ");
        string bin = Console.ReadLine();
        string str = Convert.ToInt32(bin, 2).ToString();
        Console.WriteLine(str);
     }
}

