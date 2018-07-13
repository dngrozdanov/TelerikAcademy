using System;
using System.Linq;
using System.Collections.Generic;

namespace EvenNumbers
{
    class Program
    {
        static void Main()
        {
            var Line = Console.ReadLine().Split().ToArray();
            List<int> Numbers = new List<int>();
            foreach (var number in Line)
            {
                int.TryParse(number, out int newNumber);
                if (newNumber == 0) continue;
                Numbers.Add(newNumber);
            }
            if (Numbers.Any(IsEven))
                Console.WriteLine(Numbers.Where(IsEven).Max());
            else
                Console.WriteLine("-1");
        }

        static bool IsEven(int number)
        {
            if ((number & 1) == 1)
                return false;
            return true;
        }
    }
}
