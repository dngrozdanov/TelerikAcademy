using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeRunner
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var ListOfBrokenDownNumbers = new List<int>();
            var ListOfCompleteNumbers = new Dictionary<int, string>();
            for (int i = 0; i < N; i++)
            {
                var num = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToArray();
                for (int y = 0; y < num.Length; y++)
                {
                    ListOfBrokenDownNumbers.Add(num[y]);
                }
                int oddSum = 0;
                int evenSum = 0;
                oddSum = ListOfBrokenDownNumbers.Where(IsOdd).Sum(x => x);
                evenSum = ListOfBrokenDownNumbers.Where(x => !IsOdd(x)).Sum(x => x);
                if (oddSum > evenSum)
                    ListOfCompleteNumbers.Add(int.Parse(string.Join("", num)), "right");
                else if (evenSum > oddSum)
                    ListOfCompleteNumbers.Add(int.Parse(string.Join("", num)), "left");
                else if (evenSum == oddSum)
                    ListOfCompleteNumbers.Add(int.Parse(string.Join("", num)), "straight");
                ListOfBrokenDownNumbers.Clear();
            }
            foreach (var number in ListOfCompleteNumbers)
            {
                if (number.Value == "right")
                    Console.WriteLine("right");
                else if (number.Value == "left")
                    Console.WriteLine("left");
                else if (number.Value == "straight")
                    Console.WriteLine("straight");
            }
        }

        static bool IsOdd(int num)
        {
            if ((num & 1) == 1)
                return true;
            else
                return false;
        }
    }
}