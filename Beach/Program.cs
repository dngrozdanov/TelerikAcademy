using System;

namespace Beach
{
    internal static class Program
    {
        private static void Main()
        {
            var firstHour = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
            var firstMinutes = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
            var secondHour = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
            var secondMinutes = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
            var thirdHour = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
            var thirdMinutes = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
            var fourthHour = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
            var fourthMinutes = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
            var FirstDate = firstHour * 60 + firstMinutes;
            var ThirdDate = secondHour * 60 + secondMinutes;
            var SecondDate = thirdHour * 60 + thirdMinutes;
            var FourthDate = fourthHour * 60 + fourthMinutes;
            if (ThirdDate < SecondDate || FourthDate < FirstDate)
            {
                Console.Write("No");
            }
            else
            {
                if (SecondDate >= FirstDate && SecondDate <= ThirdDate)
                {
                    if (FourthDate <= ThirdDate)
                    {
                        Console.Write(SecondDate / 60);
                        Console.Write(' ');
                        Console.Write(SecondDate % 60);
                        Console.Write(' ');
                        Console.Write(FourthDate / 60);
                        Console.Write(' ');
                        Console.Write(FourthDate % 60);
                    }
                    else
                    {
                        Console.Write(SecondDate / 60);
                        Console.Write(' ');
                        Console.Write(SecondDate % 60);
                        Console.Write(' ');
                        Console.Write(ThirdDate / 60);
                        Console.Write(' ');
                        Console.Write(ThirdDate % 60);
                    }
                }
                else
                {
                    if (FourthDate >= FirstDate && FourthDate <= ThirdDate)
                    {
                        Console.Write(FirstDate / 60);
                        Console.Write(' ');
                        Console.Write(FirstDate % 60);
                        Console.Write(' ');
                        Console.Write(FourthDate / 60);
                        Console.Write(' ');
                        Console.Write(FourthDate % 60);
                    }
                    else
                    {
                        Console.Write(FirstDate / 60);
                        Console.Write(' ');
                        Console.Write(FirstDate % 60);
                        Console.Write(' ');
                        Console.Write(ThirdDate / 60);
                        Console.Write(' ');
                        Console.Write(ThirdDate % 60);
                    }
                }
            }
        }
    }

    internal static class ConsoleInput
    {
        internal static bool LastReadWasGood { get; private set; }

        internal static string ReadToWhiteSpace(bool skipLeadingWhiteSpace)
        {
            var input = "";

            char nextChar;
            while (char.IsWhiteSpace(nextChar = (char) Console.Read()))
                if (!skipLeadingWhiteSpace)
                    input += nextChar;
            input += nextChar;

            while (!char.IsWhiteSpace(nextChar = (char) Console.Read()))
                input += nextChar;

            LastReadWasGood = input.Length > 0;
            return input;
        }

        internal static string ScanfRead(string unwantedSequence = null, int maxFieldLength = -1)
        {
            var input = "";

            char nextChar;
            if (unwantedSequence != null)
            {
                nextChar = '\0';
                for (var charIndex = 0; charIndex < unwantedSequence.Length; charIndex++)
                    if (char.IsWhiteSpace(unwantedSequence[charIndex]))
                    {
                        while (char.IsWhiteSpace(nextChar = (char) Console.Read()))
                        {
                        }
                    }
                    else
                    {
                        nextChar = (char) Console.Read();
                        if (nextChar != unwantedSequence[charIndex])
                            return null;
                    }

                input = nextChar.ToString();
                if (maxFieldLength == 1)
                    return input;
            }

            while (!char.IsWhiteSpace(nextChar = (char) Console.Read()))
            {
                input += nextChar;
                if (maxFieldLength == input.Length)
                    return input;
            }

            return input;
        }
    }
}