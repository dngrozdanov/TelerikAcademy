using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        internal string Name { get; set; }
        internal int Badges { get; set; }
        internal List<Pokemon> PokemonCollection { get; set; } = new List<Pokemon>();

        public Trainer(string name, int badges, Pokemon[] pokemons)
        {
            Name = name;
            Badges = badges;
            foreach (var pokemon in pokemons)
            {
                PokemonCollection.Add(pokemon);
            }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            if (pokemon == null) return;
            this.PokemonCollection.Add(pokemon);
        }

        public void AddBadge(int badges)
        {
            if (badges <= 0) return;
            this.Badges += badges;
        }

        public int PokemonTakeDamage(Pokemon pokemon, int damage)
        {
            var targetedPokemon = this.PokemonCollection.First(x => x.Name == pokemon.Name);
            if (damage <= 0) return targetedPokemon.Health;
            if (damage > targetedPokemon.Health)
                this.PokemonCollection.Remove(targetedPokemon);
            else
            {
                targetedPokemon.Health -= damage;
                return targetedPokemon.Health;
            }
            return 0;
        }
    }
}
