using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Counting
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToArray();
            List<int> Numbers = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i].ToString(), out int tempNumber)) continue;
                    Numbers.Add(tempNumber);
            }
            var tempNumberLocal = BigInteger.Parse(String.Join("", Numbers));
            for (BigInteger i = tempNumberLocal + 1; i < tempNumberLocal + 11; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}