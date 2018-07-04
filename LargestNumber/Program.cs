using System;
using System.Linq;

namespace LargestNumber
{
    internal static class Program
    {
        internal static void Main()
        {
            Console.WriteLine(Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray().Max());
        }
    }
}