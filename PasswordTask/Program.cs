using System;
using System.Linq;

namespace PasswordTask
{
    class Program
    {
        static void Main()
        {
            var N = Console.ReadLine().Split().ToArray();
            int Number = int.Parse(N[0]);
            int K = int.Parse(N[1]);
            int newNumber = int.Parse(string.Join("", Number.ToString().ToArray().Reverse()));
            Console.WriteLine(newNumber % K + newNumber / K);
        }
    }
}
