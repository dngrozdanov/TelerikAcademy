using System;
using System.Linq;

namespace EncryptedSMS
{
    internal static class Program
    {
        private static void Main()
        {
            var encryptword = Console.ReadLine();
            encryptword = encryptword.ToLower();
            var encryptedwordArray = encryptword.ToArray();
            var finalResult = "";
            for (var i = 0; i < encryptedwordArray.Length; i++)
            {
                finalResult += finalResult.Insert(0, encryptedwordArray[i].ToString());
            }
            Console.WriteLine(finalResult);
        }
    }
}