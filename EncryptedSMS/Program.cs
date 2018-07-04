using System;
using System.Linq;

namespace EncryptedSMS
{
    internal static class Program
    {
        private static void Main()
        {
            var encryptword = Console.ReadLine();
            if (encryptword == null) return;
            if (encryptword.Length > 100) return;
            encryptword = encryptword.ToLower();
            var encryptedwordArray = encryptword.ToArray();
            var finalResult = "";
            for (var i = 0; i < encryptedwordArray.Length; i++)
            {
                var beforeFinal = finalResult?.Insert(0, encryptedwordArray[i].ToString());
                finalResult += beforeFinal;
            }
            Console.WriteLine(finalResult);
            Console.ReadKey();
        }
    }
}