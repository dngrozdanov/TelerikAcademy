using System;

namespace BonusScore
{
    internal static class Program
    {
        internal static void Main()
        {
            var Number = Convert.ToInt32(Console.ReadLine());
            if (Number <= 0 || Number > 9)
            {
                Console.WriteLine("invalid score");
                return;
            }
            if (Number > 0 && Number < 4)
                Console.WriteLine(Number * 10);
            else if (Number > 3 && Number < 7)
                Console.WriteLine(Number * 100);
            else if (Number > 6 && Number < 10)
                Console.WriteLine(Number * 1000);
        }
    }
}