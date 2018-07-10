using System;
using System.Linq;

namespace AppearanceCount
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            short[] ArrayNumbers = Console.ReadLine().Split().Select(short.Parse).ToArray();
            short FindArrayNumber = short.Parse(Console.ReadLine());
            Console.WriteLine(ArrayNumbers.Count(x => x == FindArrayNumber));
        }
    }
}