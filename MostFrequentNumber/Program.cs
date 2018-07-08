using System;

static class Program
{
    static void Main()
    {
        short[] occuredShorts = new short[10001];
        for (int i = 0; i < short.Parse(Console.ReadLine()); i++)
        {
            short number = short.Parse(Console.ReadLine());
            occuredShorts[number]++;
        }

        short bestNumber = 0;
        short mostOccured = 0;

        for (short i = 0; i < occuredShorts.Length; i++)
        {
            if (occuredShorts[i] > mostOccured)
            {
                mostOccured = occuredShorts[i];
                bestNumber = i;
            }
        }

        Console.WriteLine($"{bestNumber} ({mostOccured} times)");
    }
}