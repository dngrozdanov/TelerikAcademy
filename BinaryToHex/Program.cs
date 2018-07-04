using System;
using System.Text;

namespace BinaryToHex
{
    internal static class Program
    {
        private static void Main()
        {
            var ToHex = BinaryStringToHexString(Console.ReadLine());
            if (ToHex.Length > 32768) return;
            Console.WriteLine(ToHex);
        }

        internal static string BinaryStringToHexString(string binary)
        {
            var result = new StringBuilder(binary.Length / 8 + 1);

            var Length = binary.Length % 8;
            if (Length != 0)
                binary = binary.PadLeft((binary.Length / 8 + 1) * 8, '0');

            for (var i = 0; i < binary.Length; i += 8)
            {
                var eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
    }
}