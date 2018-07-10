using System;
using System.Linq;

namespace Kitty
{
    class Program
    {
        static int Souls, Food, DeadLocks, Position = 0, Step;
        static char[] PositionsOfItems;
        static int[] Steps;

        static void Main()
        {
            PositionsOfItems = Console.ReadLine().ToArray();
            Steps = Console.ReadLine().Split().Select(int.Parse).ToArray();
            CollectItem(0);

            for (int i = 0; i < Steps.Length; i++)
            {
                if (Steps[i] < 0)
                {
                    Position = (Position + PositionsOfItems.Length + (Steps[i] % PositionsOfItems.Length)) % PositionsOfItems.Length;
                }
                else if (Steps[i] >= 0)
                {
                    Position = (Position + Steps[i]) % PositionsOfItems.Length;
                }
                //Console.WriteLine(Position);
                Step++;
                CollectItem(Position);
            }
            Console.WriteLine($"Coder souls collected: {Souls}{Environment.NewLine}Food collected: {Food}{Environment.NewLine}Deadlocks: {DeadLocks}");
        }

        static void CollectItem(int position)
        {
            switch (PositionsOfItems[position])
            {
                case '@':
                    PositionsOfItems[position] = '-';
                    Souls++;
                    break;
                case '*':
                    PositionsOfItems[position] = '-';
                    Food++;
                    break;
                case 'x':
                    if (IsOdd(position) && Food > 0)
                    {
                        PositionsOfItems[position] = '*';
                        Food--;
                        DeadLocks++;
                        break;
                    }
                    else if (!IsOdd(position) && Souls > 0)
                    {
                        PositionsOfItems[position] = '@';
                        Souls--;
                        DeadLocks++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine($"Jumps before deadlock: {Step}");
                        Environment.Exit(0);
                    }
                    break;
            }
        }

        static bool IsOdd(int num)
        {
            if ((num & 1) == 1)
                return true;
            else
                return false;
        }
    }
}