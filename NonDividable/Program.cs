using System;
using System.Linq;

class Program
{
    static void Main()
    {
        short[] arrayOfNumbers = new short[1];
        arrayOfNumbers = Console.ReadLine().Split().Select(short.Parse).ToArray();
        for (short i = 2; i <= (short)100; i++)
        {
            while (arrayOfNumbers[0] % i == (short)0 && arrayOfNumbers[1] % i == 0)
            {
                arrayOfNumbers[0] = (short)(arrayOfNumbers[0] / i);
                arrayOfNumbers[1] = (short)(arrayOfNumbers[1] / i);
            }
        }
        Console.WriteLine(String.Join(" ", arrayOfNumbers));
    }
}