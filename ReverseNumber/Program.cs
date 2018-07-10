using System;
using System.Linq;

namespace ReverseNumber
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToArray();
            var reversed = input.Reverse().ToArray();
            Console.WriteLine(new string(reversed));
        }
    }
}