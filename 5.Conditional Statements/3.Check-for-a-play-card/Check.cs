﻿using System;

class Check
{
    static void Main()
    {
        Console.Write("Card: ");
        string character = Console.ReadLine();
        switch (character)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A": Console.WriteLine("yes"); break;
            default: Console.WriteLine("no"); break;
        }

    }
}

