using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int a = n / 1000;
        int b = n / 100;
        b = b % 10;
        int c = n / 10;
        c = c % 10;
        int d = n % 10;
        Console.WriteLine("sum of digits = " +(a + b + c + d));
        Console.WriteLine("reversed = {0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("last digit in front = {0}{1}{2}{3}",d,a,b,c);
        Console.WriteLine("Second and third digits exchanged = {0}{1}{2}{3}",a,c,b,d);
    }
}

