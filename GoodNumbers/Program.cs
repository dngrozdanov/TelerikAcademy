using System;
using System.Linq;

namespace GoodNumbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int goodCount = 0;
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (IsGood(i))
                    goodCount++;
            }
            Console.WriteLine(goodCount);
        }

        static bool IsGood(int number)
        {
            bool isGood = true;
            int tempNum = number;
            while (isGood && tempNum > 0)
            {
                int digit = tempNum % 10;
                if (digit != 0 && number % digit != 0)
                    isGood = false;

                tempNum /= 10;
            }
            return isGood;
        }
    }
}