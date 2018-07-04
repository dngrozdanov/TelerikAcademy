using System;
using System.Linq;

namespace MinDigit
{
    class Program
    {
        static void Main()
        {
            int[] Exceptions = { 0 };
            int[] IntegerArray = Console.ReadLine()?.Select(x => int.Parse(x.ToString())).ToArray();
            Console.WriteLine(IntegerArray.Except(Exceptions).Min());
        }
    }
}
