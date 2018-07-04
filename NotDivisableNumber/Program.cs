using System;

namespace NotDivisableNumber
{
    internal static class Program
    {
        internal static void Main()
        {
            var Number = Convert.ToInt32(Console.ReadLine());
            if (Number < 1 || Number > 1500) return;

            // Alternative to return with True/False accordingly
            /*foreach (var i in Enumerable.Range(0, Number).Select(x => x % 3 != 0 && x % 7 != 0))
            {
                Console.Write(i);
                Console.Write(" ");
            }*/
            for (var i = 1; i <= Number; i++) if (i % 3 != 0 && i % 7 != 0) Console.Write(i + " ");
        }
    }
}