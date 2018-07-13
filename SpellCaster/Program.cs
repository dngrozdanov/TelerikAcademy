using System;
using System.Linq;
using System.Collections.Generic;

namespace SpellCaster
{
    static class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split().ToArray();
            // Инициализираме листа
            List<char> wordChars = new List<char>();
            // Буул, който ще се промени когато събере луупа всички числа в листа отгоре
            bool collectedAllChars = false;
            // Да продължава луупа докато буулиъна е false
            while (!collectedAllChars)
            {
                // Ако мине още един път и буулиъна е true (Един вид, че е събрал всичките char-ове в листа)
                // Да излезе от while цикъла
                if (collectedAllChars) break;
                // Да върти в цикъл докато мине през всички думи
                for (int i = 0; i < words.Length; i++)
                {
                    // Запазва думата според индекса (където се намира)
                    string _tempword = words[i];
                    // Ако всички думи са празни, да излезе от цикъла
                    // И да промени буулиъна, че един вид ги е събрал всичките char-ове от всички думи
                    if (words.All(x => x == ""))
                    {
                        collectedAllChars = true;
                        break;
                    }
                    // Ако думата на която сме в момента е празна, да я skip-не
                    if (_tempword == "") continue;
                    // Добави последния char от думата в листа
                    wordChars.Add(_tempword.Last());
                    // Изтрии последния char от думата (Сегашната дума = Новата дума която е без последната буква)
                    words[i] = _tempword.Remove(_tempword.LastIndexOf(_tempword.Last()));
                }
            }
            // Step 1 Completed
            // Да върти в цикъл докато не стигне броя на буквите в листа
            for (int i = 0; i < wordChars.Count(); i++)
            {
                // Запазваме сегашната буква на която сме
                var currentChar = wordChars[i];
                // Запазваме МЯСТОТО КЪДЕТО БУКВАТА ТРЯБВА ДА БЪДЕ
                var currentPosition = FindPosition(wordChars, i);
                // Махаме я от сегашното й място
                wordChars.RemoveAt(i);
                // Insert-ва ме я в новата й позиция
                wordChars.Insert(currentPosition, currentChar); 
            }
            // Принтираме финалния резултат (string-а след всички промени)
            Console.WriteLine(String.Join("", wordChars));
        }

        // Метод който намира къде трябва да се намира дадената буква в string-а
        // Според мястото й в азбуката
        static int FindPosition(List<char> list, int i)
        {
            return (LetterToNumber(list[i]) + i) % list.Count();
        }

        // Метод който връща числото (позицията на дадената буква в азбуката)
        static int LetterToNumber(char letter)
        {
            var charnum = (char.ToLower(letter) - 'a' + 1);
            return charnum;
        }
    }
}