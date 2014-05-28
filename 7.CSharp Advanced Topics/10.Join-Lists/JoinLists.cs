using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string number = Console.ReadLine();
        string[] lineArr = number.Split(new char[] { ' ' });
        string remNumber = Console.ReadLine();
        string[] lineRem = remNumber.Split(new char[] { ' ' });
        List<int> addNumber = new List<int>();
        List<int> addNumber2 = new List<int>();
        for (int i = 0; i < lineArr.Length; i++)
        {
            addNumber2.Add(int.Parse(lineArr[i]));
        }
        for (int i = 0; i < lineRem.Length; i++)
        {
            addNumber2.Add(int.Parse(lineRem[i]));
        }
        addNumber2.Sort();
        addNumber = addNumber2.Distinct().ToList();
        foreach (int num in addNumber)
        {
            Console.Write(num + " ");
        }
    }
}

