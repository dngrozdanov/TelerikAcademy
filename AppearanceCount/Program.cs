using System;
using System.Linq;

namespace AppearanceCount
{
    class Program
    {
        static void Main()
        {
            int ArraySize = Convert.ToInt32(Console.ReadLine());
            int[] ArrayNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int FindArrayNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ArrayNumbers.Count(x => x == FindArrayNumber));
        }
    }
}
