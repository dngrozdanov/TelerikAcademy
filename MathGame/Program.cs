using System;
using System.Linq;

namespace MathGame
{
    static class Program
    {
        static void Main()
        {
            var FirstLine = Console.ReadLine();
            if (FirstLine == null) return;
            if (FirstLine.Length > 3 || FirstLine.Length < 3) return;
            var numbers = Array.ConvertAll(FirstLine.ToArray(), s => int.Parse(s.ToString()));

            int firstsum = numbers[0] + numbers[1] + numbers[2];
            int secondsum = numbers[0] + numbers[1] * numbers[2];
            int thirdsum = numbers[0] * numbers[1] + numbers[2];
            int multiply = numbers[0] * numbers[1] * numbers[2];

            int FirstMax = Math.Max(firstsum, secondsum);
            int SecondMax = Math.Max(thirdsum, multiply);
            Console.WriteLine(Math.Max(FirstMax, SecondMax));
        }
    }
}