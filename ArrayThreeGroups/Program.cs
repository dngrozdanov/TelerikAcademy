using System;
using System.Linq;

namespace ArrayThreeGroups
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i <= 2; i++)
            {
                int[] line = nums.Where(x => x % 3 == i).ToArray();
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}