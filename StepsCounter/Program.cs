using System;

namespace StepsCounter
{
    internal static class Program
    {
        internal static void Main()
        {
            var milesWalked = Convert.ToInt32(Console.ReadLine());
            var MetersWalked = milesWalked * 1609;
            //if (milesWalked < 1 || milesWalked > 100000) return;
            //if (MetersWalked < 1 || MetersWalked > 100000) return;
            Console.WriteLine(MetersWalked); // 1609 Meters = 1 Mile
        }
    }
}