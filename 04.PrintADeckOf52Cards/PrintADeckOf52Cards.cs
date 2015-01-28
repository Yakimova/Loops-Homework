using System;
/*
    Problem 4. Print a Deck of 52 Cards

    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
        The card faces should start from 2 to A.
        Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
 */
class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.WriteLine("All possible cards from a standard deck of 52 cards are:");
        string allcards = "23456789JDKA";
        for (int i=0 ; i<12; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                Console.Write(allcards[i]);
                switch (j)
                {
                    case 1:
                        Console.Write(" of spades, ");
                        break;
                    case 2:
                        Console.Write(" of clubs, ");
                        break;
                    case 3:
                        Console.Write(" of hearts, ");
                        break;
                    case 4:
                        Console.Write(" of diamonds");
                        break;
                }
            }
            Console.WriteLine();
        }

    }
}