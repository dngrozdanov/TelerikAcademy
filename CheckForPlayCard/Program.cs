using System;
using System.Linq;

namespace CheckForPlayCard
{
    class Program
    {
        static void Main()
        {
			string[] Cards = {"2" , "3", "4" , "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            var input = Console.ReadLine();
            if (Cards.Contains(input))
                Console.WriteLine($"yes {input}");
            else
                Console.WriteLine($"no {input}");
        }
    }
}