using System;

class Gravitation
{
    static void Main()
    {
        double weightMoon;
        Console.Write("Weight = ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Weight on the Moon = " + (weightMoon = (weight * 0.17)));
    }
}

