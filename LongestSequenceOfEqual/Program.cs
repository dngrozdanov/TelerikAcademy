using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSequenceOfEqual
{
    class Program
    {
        static void Main()
        {
            int LineNumber = Convert.ToInt32(Console.ReadLine());
            if (LineNumber < 1 || LineNumber > 1024) return;
            var NumbersList = new Dictionary<int, int>(LineNumber);
            int prevInt = 0;
            for (int i = 0; i < LineNumber; i++)
            {
                var TempNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                if (NumbersList.ContainsKey(TempNumber) && prevInt == TempNumber)
                    NumbersList[TempNumber]++;
                else if (NumbersList.ContainsKey(TempNumber) && prevInt != TempNumber)
                    NumbersList.Remove(TempNumber);
                else if (!NumbersList.ContainsKey(TempNumber))
                    NumbersList.Add(TempNumber, 1);
                prevInt = TempNumber;
            }
            var Selected = NumbersList.First(x => x.Value == NumbersList.Values.Max());
            Console.WriteLine("{0}", Selected.Value);
        }
    }
}