using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumber
{
    internal static class Program
    {
        private static void Main()
        {
            var LineNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            if (LineNumber < 1 || LineNumber > 1024) return;
            var NumbersList = new Dictionary<int, int>(LineNumber);
            for (var i = 0; i < LineNumber; i++)
            {
                var TempNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                if (NumbersList.ContainsKey(TempNumber))
                    NumbersList[TempNumber]++;
                else
                    NumbersList.Add(TempNumber, 1);
            }
            var Selected = NumbersList.First(x => x.Value == NumbersList.Values.Max());
            Console.WriteLine("{0} ({1} times)", Selected.Key,
                Selected.Value);
        }
    }
}