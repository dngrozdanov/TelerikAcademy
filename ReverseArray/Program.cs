using System;
using System.Linq;

namespace ReverseArray
{
    internal static class Program
    {
        internal static void Main()
        {
            var ArrayInts = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            if (ArrayInts != null) Console.WriteLine(string.Join(", ", ArrayInts.Reverse()));
        }
    }
}