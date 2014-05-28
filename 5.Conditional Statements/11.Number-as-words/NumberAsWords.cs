using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("numbers = ");
        string digit = Console.ReadLine();
        int numbers = int.Parse(digit);
        bool bolTen = (14 <= numbers && numbers <= 19);
        int xNum = numbers % 10;
        int yTens = numbers / 10;
        yTens = yTens % 10;
        int z = numbers / 100;
        string[] number = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] tens = {"", "", "Twenty", "Thirty", "Forty", "Fifty" , "Sixty", "Seventy", "Eighty", "Ninety"  };
        switch (digit)
        {
            case "0": Console.WriteLine("Zero"); break;
            case "1": Console.WriteLine("One"); break;
            case "2": Console.WriteLine("Two"); break;
            case "3": Console.WriteLine("Three"); break;
            case "4": Console.WriteLine("Four"); break;
            case "5": Console.WriteLine("Five"); break;
            case "6": Console.WriteLine("Six"); break;
            case "7": Console.WriteLine("Seven"); break;
            case "8": Console.WriteLine("Eight"); break;
            case "9": Console.WriteLine("Nine"); break;
            case "10": Console.WriteLine("Ten"); break;
            case "11": Console.WriteLine("Eleven"); break;
            case "12": Console.WriteLine("Twelve"); break;
            case "13": Console.WriteLine("Thriteen"); break;
            default:
                if (bolTen)
                {
                    Console.WriteLine("{0}teen", number[xNum]);
                }
                else  if (numbers < 100)
                {
                    Console.WriteLine("{0} {1}",tens[yTens], number[xNum]);
                }
                else if (numbers % 100 == 0)
                {
                    Console.WriteLine("{0} hundred", number[z]);
                }
                else if (numbers < 1000)
                {
                    Console.WriteLine("{0} hunderd and {1} {2}", number[z], tens[yTens], number[xNum]);
                }
                else
                {
                    Console.WriteLine("number > 999");
                }
                break;
        }
    }
}

