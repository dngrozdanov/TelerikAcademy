using System;
using SchoolOOP.Contracts;
using SchoolOOP.Enumerators;

namespace SchoolOOP.Animals
{
    public class Kitten : Animal, ISound
    {
        public Kitten(string name, int age) : base(name, age, Sex.Female)
        {

        }

        public void Skill()
        {
            Console.WriteLine($"{this.Name} quietly meows...");
        }
    }
}
