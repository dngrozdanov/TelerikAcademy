using System;

namespace DigitAsWord
{
    internal static class Program
    {
        internal static void Main()
        {
            int Line;
            try
            {
                Line = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            }
            catch (FormatException)
            {
                Console.WriteLine("not a digit");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("not a digit");
                return;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("not a digit");
                return;
            }
            switch (Line)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("not a digit");
                    break;
            }
        }
    }
}