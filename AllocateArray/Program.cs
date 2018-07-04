using System;

namespace AllocateArray
{
    internal static class Program
    {
        private static void Main()
        {
            var num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 20) return;
            for (var i = 0; i < num; i++)
                Console.WriteLine(i * 5);
        }
    }
}