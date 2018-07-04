using System;
using System.Linq;

namespace Sort
{
    internal static class Program
    {
        internal static void Main()
        {
            var Numbers = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            if (Numbers == null) return;
            if (Numbers[0] < 0 || Numbers[1] < 0 || Numbers[2] < 0 || Numbers[3] < 0) return;
            if (Numbers[0] > 100 || Numbers[1] > 100 || Numbers[2] > 100 || Numbers[3] > 100) return;
            if (Numbers[0] < Numbers[1] && Numbers[1] < Numbers[2] && Numbers[2] < Numbers[3])
                Console.WriteLine("Ascending");
            else if (Numbers[0] > Numbers[1] && Numbers[1] > Numbers[2] && Numbers[2] > Numbers[3])
                Console.WriteLine("Descending");
            else
                Console.WriteLine("Mixed");
        }
    }
}