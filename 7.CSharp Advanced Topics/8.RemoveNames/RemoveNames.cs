using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        string addNames = Console.ReadLine();
        string[] firstName = addNames.Split(new char[] { ' ' });
        string remNames = Console.ReadLine();
        string[] secondName = remNames.Split(new char[] { ' ' });
        List<string> lineAddNames = firstName.ToList<string>();
        List<string> secondLineNames = secondName.ToList<string>();
        for (int i = 0; i < secondLineNames.Count; i++)
        {
            for (int j = 0; j < lineAddNames.Count; j++)
            {
                if(lineAddNames.Contains(secondLineNames[i]))
                {
                    lineAddNames.Remove(secondLineNames[i]);
                }
            }
        }
        foreach (var x in lineAddNames)
        {
            Console.Write(x +" ");
        }
    }
}

