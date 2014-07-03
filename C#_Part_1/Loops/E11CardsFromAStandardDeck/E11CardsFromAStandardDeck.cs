using System;

class E11CardsFromAStandardDeck
{
    static void Main ()
    {
        // Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
        // The cards should be printed with their English names. Use nested for loops and switch-case.
        int kardNumber = 1;

        for (int color = 1; color < 5; color++)
        {
            for (int rank = 1; rank < 14; rank++)
            {
                Console.Write ((kardNumber++) + " ");
                ranks (rank);
                Console.Write (" of ");
                colors (color);
            }
        }
    }


    static void ranks (int position)
    {
        switch (position)
        {
            case 1:
                Console.Write ("Ace");
                break;
            case 2:
                Console.Write ("Two");
                break;
            case 3:
                Console.Write ("Three");
                break;
            case 4:
                Console.Write ("Four");
                break;
            case 5:
                Console.Write ("Five");
                break;
            case 6:
                Console.Write ("Six");
                break;
            case 7:
                Console.Write ("Seven");
                break;
            case 8:
                Console.Write ("Eight");
                break;
            case 9:
                Console.Write ("Nine");
                break;
            case 10:
                Console.Write ("Ten");
                break;
            case 11:
                Console.Write ("Jack");
                break;
            case 12:
                Console.Write ("Queen");
                break;
            case 13:
                Console.Write ("King");
                break;
        }
    }


    static void colors (int position)
    {
        switch (position)
        {
            case 1:
                Console.WriteLine ("Clubs");
                break;
            case 2:
                Console.WriteLine ("Diamonds");
                break;
            case 3:
                Console.WriteLine ("Hearts");
                break;
            case 4:
                Console.WriteLine ("Spades");
                break;
        }
    }
}
