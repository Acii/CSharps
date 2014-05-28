using System;

class Divide
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(((n % 5 == 0) && (n % 7 == 0))? "True" : "False");
    }
}

