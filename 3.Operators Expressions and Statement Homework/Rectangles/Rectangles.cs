using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("width = ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("height = ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter ={0} ", (width + height) * 2);
        Console.WriteLine("Area ={0} ", width * height);
    }
}

