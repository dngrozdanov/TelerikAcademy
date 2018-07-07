using System;
namespace PokemonTrainer
{
    public class Pokemon
    {
        internal string Name { get; set; }
        internal string Element { get; set; }
        internal int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
}
