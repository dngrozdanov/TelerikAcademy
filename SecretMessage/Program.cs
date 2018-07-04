using System;
using System.Text.RegularExpressions;

namespace SecretMessage
{
    internal static class Program
    {
        internal static void Main()
        {
            var Line = Console.ReadLine();
            if (Line == null) return;
            if (Line.Length > 10000) return;
            if (!Regex.IsMatch(Line, @"^[a-zA-Z0-9]+$")) return;
            var Reformed = Regex.Replace(Line, @"[\d-]", string.Empty).ToCharArray();
            Array.Reverse(Reformed);
            Console.WriteLine(Reformed);
        }
    }
}