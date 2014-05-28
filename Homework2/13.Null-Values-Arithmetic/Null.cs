using System;

class Null
{
    static void Main()
    {
        int? someInteger = null;
        Console.WriteLine(someInteger);
        someInteger = 25;
        Console.WriteLine(someInteger);
        double? someDouble = null;
        Console.WriteLine(someDouble);
        someDouble = 10.05d;
        Console.WriteLine(someDouble);
    }
}

