using System;

class Print52Cards
{
    static void Main()
    {
        char clubs = '♣';
        char diamonds = '♦';
        char hearts = '♥';
        char spades = '♠';
        string[] card = { "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10", "J ", "Q ", "K ", "A " };
        for (int i = 0; i < card.Length; i++)
        {
            Console.WriteLine(card[i] + (char)clubs + " " + card[i] + (char)diamonds + " " + card[i] + (char)hearts + " " + card[i] + (char)spades);
        }
    }
}

