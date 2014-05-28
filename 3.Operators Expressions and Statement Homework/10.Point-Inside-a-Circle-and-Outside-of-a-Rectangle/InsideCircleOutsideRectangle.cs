using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        double c = 1.5d;
        bool insideCircle = ((x - 1) * (x - 1) + (y - 1) * (x - 1)<=c*c);
        bool outsideRectangle = ((x > 1) || (x < 6) && (y > -1) || (y < 2));
        if (x == 0 || y == 0)
        {
            Console.WriteLine("no");
        }
        else if (insideCircle == true && outsideRectangle == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

