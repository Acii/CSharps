using System;
class Lognest
{
    static void Main()
    {
        string strText = Console.ReadLine();
        string[] text = strText.Split(new char[] { ' ',',','.','`','!','?' });
        int count = 0;
        for (int i = 1; i < text.Length; i++)
        {
            if(text[i].Length > text[count].Length)
            {
                count = i;
            }
            
        }
        Console.WriteLine(text[count]);
    }
}

