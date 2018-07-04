using System;
using System.Linq;

namespace Marks
{
    class Program
    {
        static void Main()
        {
            int MarksCount = Convert.ToInt32(Console.ReadLine());
            int[] MarksArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double Score = 0;
            foreach (var num in MarksArray)
            {
                Score += num;
            }
            Score = Score / MarksCount;
            Console.WriteLine(Math.Round(Score));
        }
    }
}
