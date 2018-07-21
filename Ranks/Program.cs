using System;
using System.Linq;
using System.Collections.Generic;

namespace Ranks
{
    class Program
    {
        class Custom
        {
            public Custom(int num, bool isChanged)
            {
                this.number = num;
                this.isChanged = isChanged;
            }

            public int number { get; set; }
            public bool isChanged { get; set; }
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var NumbersDictionary = new Dictionary<int, Custom>(arrayNumbers.Length);
            int indexer = 1;
            foreach (var num in arrayNumbers)
            {
                //NumbersDictionary.Add(num, new Custom(num, false));

            }
            /*foreach (var num in NumbersDictionary)
            {
                if (!num.Value.isChanged && num.Value.number == NumbersDictionary.Values.Select(x => x.number).Max())
                {
                    num.Value.number = indexer;
                    num.Value.isChanged = true;
                    indexer++;
                }
            }*/
            //Console.WriteLine(string.Join(" ", NumbersDictionary.Values.Select(x => x.number)));
            Console.WriteLine(string.Join(" ", arrayNumbers));
        }
    }
}