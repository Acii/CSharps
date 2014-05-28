using System;

class BooleanVariable
{
    static void Main()
    {
        int sex;
        string m = Console.ReadLine();
        sex = int.Parse(m);
        bool isFemale = (sex == 0);
        Console.WriteLine("is Female:{0}",isFemale);
        bool isMale = (sex == 1);
        Console.WriteLine("is Male:{0}",isMale);
    }
}

