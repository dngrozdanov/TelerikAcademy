using System;
using System.Linq;

namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "git is a <<version control>> system for tracking changes in <<computer files>> and coordinating work on those files among multiple people";
            while (text.Contains("<<"))
            {
                int startIndex = text.IndexOf("<<");
                int endIndex = text.IndexOf("<<") + 2;
                int length = endIndex - startIndex;
                string subString = text.Substring(startIndex, length);
                string newsubString = text.Substring(startIndex + 2, length - 4);

                text.Replace(subString, newsubString).ToUpper();
            }
            Console.WriteLine(text);
        }
    }
}
