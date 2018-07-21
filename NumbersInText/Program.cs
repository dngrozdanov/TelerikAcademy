using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersInText
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            var intsList = new List<int>();
            foreach (var num in input)
            {
                if (IsCharDigit(num))
                    intsList.Add(num - '0');
            }
            if (intsList.Count != 0)
                Console.WriteLine(intsList.Sum());
            else
                Console.WriteLine(-1);
        }

        public static bool IsCharDigit(char c)
        {
            return ((c >= '0') && (c <= '9'));
        }
    }
}