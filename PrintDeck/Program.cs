using System;

namespace PrintDeck
{
    class Program
	{
        static void Main()
        {
            var Input = Console.ReadLine();
            switch(Input)
            {
                case "A":
                    {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "A");
                    }
                break;
                case "K":
                    {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                    }
                break;
                case "Q":
                    {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                    }
                break;
                case "J":
                    {
                        for (int i = 2; i <= 10; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                    }
                break;
                default:
                    {
                        int Card = int.Parse(Input);
                        if (Card < 2 || Card > 10) return;
                        for (int i = 2; i <= Card; i++)
                        {
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                        }
                    }
                    break;
            }
        }
    }
}
