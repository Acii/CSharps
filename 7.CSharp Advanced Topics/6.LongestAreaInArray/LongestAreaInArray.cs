using System;
using System.Collections;
using System.Linq;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] str = new string[n];
        for (int i = 0; i < str.Length; i++)
        {
            str[i] = Console.ReadLine();
        }
        int max = 0;
        int count = 0;
        string line = null;
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if(str[i] == str[j])
                {
                    count++;
                    if(max < count)
                    {
                        max = count;
                        line = str[i];
                    }
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(line);
    }
}

