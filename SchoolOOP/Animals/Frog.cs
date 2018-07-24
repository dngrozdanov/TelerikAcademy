using System;
using SchoolOOP.Contracts;
using SchoolOOP.Enumerators;

namespace SchoolOOP.Animals
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex sex) : base(name, age, sex)
        {

        }

        public void Skill()
        {
            Console.WriteLine($"{this.Name} croaks...");
        }
    }
}
