using System;
using System.Collections.Generic;

class Extract
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] line = str.Split(new char[] { ' ' });
        List<string> listStr = new List<string>();
        foreach (var word in line)
        {
            if (!listStr.Contains(word) && word.Length > 6)
            {
                if (word.Substring(0, 7) == "http://" || word.Substring(0, 4) == "www.")
                {
                    listStr.Add(word);
                }
            }
        }
        foreach (var ar in listStr)
        {
            Console.WriteLine(ar);
        }
    }
}
