using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string _name;
        private int _badges;
        private List<Pokemon> _pokemons;

        public string Name{ get { return this._name; } set { this._name = value; }}
        public int Badges { get { return this._badges; } set { this._badges = value; }}
        public List<Pokemon> GetPokemons { get { return this._pokemons; } set { this._pokemons = value; } }

        public Trainer(string name, int badges, Pokemon[] pokemons)
        {
            this._name = name;
            this._badges = badges;
            this._pokemons = new List<Pokemon>();
            foreach (var pokemon in pokemons)
            {
                _pokemons.Add(pokemon);
            }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            if (pokemon == null) return;
            this._pokemons.Add(pokemon);
        }

        public void AddBadge(int badges)
        {
            if (badges <= 0) return;
            this._badges += badges;
        }

        public void PokemonTakeDamage(Pokemon pokemon, int damage)
        {
            var targetedPokemon = this._pokemons.First(x => x.Name == pokemon.Name);
            if (damage <= 0) return;
            if (damage > targetedPokemon.Health)
                this._pokemons.Remove(targetedPokemon);
            else
            {
                targetedPokemon.Health -= damage;
            }
        }
    }
}
