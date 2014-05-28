using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string names = Console.ReadLine();
        string[] lineNames = names.Split(new char[] { ' ' });
        List<string> firsNames = lineNames.ToList<string>();
        firsNames.Sort();
        int count = 1;
        for (int i = 1; i < firsNames.Count; i++)
        {
            if (firsNames[i] == firsNames[i - 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", firsNames[i - 1], count);
                count = 1;
            }
            if (i == firsNames.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", firsNames[i], count);
            }
        }
    }
}
