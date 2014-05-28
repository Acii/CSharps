using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter a time: hh:mm tt");
        string enterTime = Console.ReadLine();
        DateTime chTime = DateTime.Parse(enterTime);
        string timeBeer1 = "1:00 PM";
        DateTime tb1 = DateTime.Parse(timeBeer1);
        string timeBeer2 = "3:00 AM";
        DateTime tb2 = DateTime.Parse(timeBeer2);
        bool result = (tb1 <= chTime || chTime < tb2 );
        if (result)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

