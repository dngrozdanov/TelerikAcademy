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
            Score = Score - (MarksArray.Max() + MarksArray.Min());
            Score = Score / (MarksCount - 2);
            Console.WriteLine(Math.Round(Score));
        }
    }
}