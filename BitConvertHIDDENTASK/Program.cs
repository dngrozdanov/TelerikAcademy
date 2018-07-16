using System;
using System.Linq;
using System.Collections.Generic;

namespace BitConvertHIDDENTASK
{
    class Program
    {
        static void Main()
        {
            int[] arrayNumbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            List<string> newNumbers = new List<string>();
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                var number = arrayNumbers[i];
                var bitNumber = Convert.ToString(number, 2);
                var bits = bitNumber.PadLeft(8, '0');

                if (i % 2 == 0)
                {
                    for (int y = 0; y < bits.Length; y++)
                    {
                        bits = bits.Remove(y, 1);
                    }
                }
                else
                {
                    for (int t = 1; t < bits.Length; t++)
                    {
                        bits = bits.Remove(t, 1);
                    }
                }
                newNumbers.Add(bits);
            }
            Console.WriteLine(string.Join("", newNumbers));
        }
    }
}