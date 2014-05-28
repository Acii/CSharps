using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] line = str.Split(new char[] {' '});
        List<string> firstLine = line.ToList<string>();
        firstLine.Sort();
        int count = 1;
        for (int i = 1; i < firstLine.Count; i++)
        {
            if (firstLine[i] == firstLine[i - 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}",firstLine[i-1],count);
                count = 1;
            }
            if(i == firstLine.Count-1)
            {
                Console.WriteLine("{0} -> {1}", firstLine[i], count);
            }
        }
    }
}
