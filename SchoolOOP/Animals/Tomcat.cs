using System;
using SchoolOOP.Contracts;
using SchoolOOP.Enumerators;

namespace SchoolOOP.Animals
{
    public class Tomcat : Animal, ISound
    {
        public Tomcat(string name, int age) : base(name, age, Sex.Male)
        {

        }

        public void Skill()
        {
            Console.WriteLine($"{this.Name} loudly meows...");
        }
    }
}
