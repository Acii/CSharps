using System;

class Quotes
{
    static void Main()
    {
        string aText = "The \"use\" of quotations";
        string bText = "causes difficulties";
        Console.WriteLine(aText + " " + bText);
        string cText = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(cText);
    }
}

