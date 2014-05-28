using System;
using System.Text;

class ACIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (char i = '\u0000'; i < 256; i++)
        {
            Console.WriteLine(@"Symbol: ""{0}""           value: ""{1}""",i,(int)i); 
        }
    }
}

