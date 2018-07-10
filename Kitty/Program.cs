using System;
using System.Linq;

namespace Kitty
{
    class Program
    {
        static int Souls, Food, DeadLocks, Position, Step;
        static char[] PositionsOfItems;
        static int[] Steps;

        static void Main()
        {
            PositionsOfItems = Console.ReadLine().ToArray();
            Steps = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < PositionsOfItems.Length; i++)
            {
                CollectItem(0);
                if (Position < 0)
                {
                    Position = PositionsOfItems.Length + (Steps[Step] % PositionsOfItems.Length);
                }
                else if (Position >= 0)
                {
                    Position = Steps[Step] % PositionsOfItems.Length;
                }
                CollectItem(Position);
                if (Step++ > Steps.Length)
                {
                    Console.WriteLine($"{Souls} | {Food} | {DeadLocks}");
                    return;
                }
                Step++;
            }
        }

        static void CollectItem(int position)
        {
            if (PositionsOfItems[position] == '@')
                Souls++;
            else if (PositionsOfItems[position] == '*')
                Food++;
            else if (PositionsOfItems[position] == 'x')
            {
                DeadLocks++;
                if (Food == 0 && Souls == 0)
                {
                    Console.WriteLine("You are deadlocked, you greedy kitty!");
                    Console.WriteLine($"Jumps before deadlock: {Step}");
                    return;
                }
                if (IsOdd(position))
                    Food--;
                else
                    Souls--;
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
