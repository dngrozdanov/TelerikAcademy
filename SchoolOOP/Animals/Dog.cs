using System;
using SchoolOOP.Contracts;
using SchoolOOP.Enumerators;

namespace SchoolOOP.Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Sex sex) : base(name, age, sex)
        {

        }

        public void Skill()
        {
            Console.WriteLine($"{this.Name} barks...");
        }
    }
}
